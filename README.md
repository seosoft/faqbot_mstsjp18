# FAQ Bot サンプル (Tech Summit 2018)


この Bot アプリケーションは、[Microsoft Bot Service](https://docs.microsoft.com/ja-jp/azure/bot-service/?view=azure-bot-service-4.0) 上で動作するアプリケーションです。  
[QnA Maker](https://www.qnamaker.ai/) を利用する FAQ ボットです。


Tech Summit 2018 [DA09 ユーザー インターフェースとしてのチャット ボット開発手法と Microsoft Bot Framework v4](https://www.microsoft.com/ja-jp/events/techsummit/2018/session.aspx#DA09) で使用しました。


# Bot アプリケーション実行前の準備

- [Microsoft Azure ポータルサイト](https://portal.azure.com/) で、**Web App Bot (C#)** のサービスを作成します。
- リソースグループに QnA Maker リソースを作成します。
- [QnA Maker](https://www.qnamaker.ai/) で、前の手順で作成した QnA Maker リソースに接続する [ナレッジベースを作成](https://www.qnamaker.ai/Create) します。
- 作成したナレッジベースの Knowledgebase Id, Host, Endpoint Key を確認します。
- 作成した Web アプリボット の [Application Id](https://apps.dev.microsoft.com/) を確認します。
- 作成した Bot アプリケーションを Azure に発行する場合は、作成した Web アプリボット の [Application Id](https://apps.dev.microsoft.com/) に対して新しい **パスワード(アプリケーションシークレット)** を追加します。パスワードは設定時に一度しか表示されないため、メモ帳などに貼り付けておきます。

なお、Bot アプリケーションでは、Web アプリボットの **アプリケーション設定** で BotFileSecret がされています。  
正常にどうさせるためには、ソリューションの  **appsettings.json** および **TsBasicBot.bot** に BotFileSecret の値をコピーしなければなりません。  
このサンプルでは設定を簡易にするために、BotFileSecret を削除（空白）にしています。Web アプリボットのアプリケーション設定画面でも、BotFileSecret のエントリを削除してください。

# 参考情報
- [Bot Framework Documentation](https://docs.botframework.com)
- [Bot basics](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0)
- [QnA Maker](https://qnamaker.ai)
- [QnA Mak](https://luis.ai)
- [Prompt Types](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-prompts?view=azure-bot-service-4.0&tabs=javascript)
- [Azure Bot Service Introduction](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-overview-introduction?view=azure-bot-service-4.0)
- [Channels and Bot Connector Service](https://docs.microsoft.com/en-us/azure/bot-service/bot-concepts?view=azure-bot-service-4.0)
