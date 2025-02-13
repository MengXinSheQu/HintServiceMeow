# 简介
**HintServiceMeow (HSM)** 是一个用于在玩家屏幕指定位置显示文字的Hint框架。

---

# 安装

请按照以下步骤安装该插件：

1. 进入 [发行页面](https://github.com/MeowServer/HintServiceMeow/releases)，下载最新的 `HintServiceMeow.dll` 文件。
2. 如果您使用的是 **PluginAPI**（默认 API），请将 `Harmony.dll` 放入 **dependencies** 文件夹。
3. 将这些文件粘贴到插件文件夹中，然后重启服务器完成安装。

---

# 文档

以下是一些有用的资源，帮助您快速上手：

- [功能简介](Features.md)
- [开始使用](GettingStarted.md)
- [核心功能](CoreFeatures.md)

---

# 常见问题

### 1. 为什么插件安装后没有工作？
- 请确保 **HintServiceMeow** 已正确安装。
- 检查是否有与 **HintServiceMeow** 冲突的插件。
- 查看是否有插件报错。

### 2. 为什么提示文字相互重叠？
- 当多个插件将提示文字放在同一位置时，可能会出现这种情况。您可以检查各插件的配置文件，看看是否能调整提示文字的位置。
- 如果无法通过配置文件调整位置，请联系相应插件的作者以寻求帮助。
