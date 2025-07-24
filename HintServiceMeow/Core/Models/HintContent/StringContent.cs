using HintServiceMeow.Core.Models.Arguments;

namespace HintServiceMeow.Core.Models.HintContent
{
    public class StringContent : AbstractHintContent
    {       
        private static readonly Regex CoreRegex = new("(<.*?>)");
        
        private static string AddLower(string old)
        {
            var s = CoreRegex.Split(old);
            string txt = "";
            foreach (var i in s)
            {
                if (CoreRegex.IsMatch(i)) txt += i;
                else
                    foreach (var p in i)
                    {
                        if (IsUpper(p))
                            txt += $"<uppercase>{p}</uppercase>";
                        else
                            txt += p;
                    }
            }
            return $"<lowercase>{txt}</lowercase>";
        }
        private string _text = string.Empty;

        public string Text
        {
            get => _text;
            set
            {
                if (_text == value)
                    return;

                _text = value;

                OnUpdated();
            }
        }

        public StringContent(string content)
        {
            this.Text = content;
        }

        public override string GetText() => AddLower(Text);

        public override void TryUpdate(ContentUpdateArg ev) { }
    }
}
