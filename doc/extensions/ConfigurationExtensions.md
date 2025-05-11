---
uid: Uno.Recipes.Configuration
---

# Persistent App Settings

## Problem

There is a need for a uniform way to read configuration data as well as write configuration values at runtime.

## Solution

Writable configuration from `Uno.Extensions.Configuration` provides you an interface for using and updating local persistent data.

### Create a new record

[!code-csharp[](../../Chefs/Business/Models/AppConfig.cs#L5-L11)]

### Add to your `IConfigBuilder`

Use `Section<T>()` inside `UseConfiguration`. You can chain multiple configs.

[!code-csharp[](../../Chefs/App.xaml.host.cs#L48-L54)]

### Get and Update the value

#### UserService.cs

1. Inject `IWritableOptions<AppConfig>` in the primary constructor of the UserService and store it in a `private readonly` property.

    [!code-csharp[](../../Chefs/Services/Users/UserService.cs#L7-L12)]

#### SettingsService
<!-- markdownlint-disable MD029 -->
2. Implement the logic to read from to the configuration.

    [!code-csharp[](../../Chefs/Services/Settings/SettingsService.cs#L5-L6)]

3. To update them, which includes awaiting the current Settings from the ValueTask we just implemented

    [!code-csharp[](../../Chefs/Services/Settings/SettingsService.cs#L13-L23)]

4. Implement the logic to write them back to the configuration.

    [!code-csharp[](../../Chefs/Services/Settings/SettingsService.cs#L8-L11)]

5. And then of course, connect the Update with the write-back.

    [!code-csharp[](../../Chefs/Services/Settings/SettingsService.cs#L13-L27?highlight=25)]

## Source Code

- [App UseConfiguration](https://github.com/unoplatform/uno.chefs/blob/04a93886dd0b530386997179b80453a59e832fbe/Chefs/App.xaml.host.cs#L65-L71)
- [App UserService](https://github.com/unoplatform/uno.chefs/blob/04a93886dd0b530386997179b80453a59e832fbe/Chefs/App.xaml.cs#L68)
- [UserService](https://github.com/unoplatform/uno.chefs/blob/139edc9eab65b322e219efb7572583551c40ad32/Chefs/Services/Users/UserService.cs)
- [SettingModel](https://github.com/unoplatform/uno.chefs/blob/139edc9eab65b322e219efb7572583551c40ad32/Chefs/Presentation/SettingsModel.cs#L22-L34)
- [SettingPage](https://github.com/unoplatform/uno.chefs/blob/139edc9eab65b322e219efb7572583551c40ad32/Chefs/Views/SettingsPage.xaml#L120)

## Documentation

- [Uno.Extensions Configuration Documentation](xref:Uno.Extensions.Configuration.Overview)