# OutlookAddIn_OneClickSave

## 【簡単な説明】

Outlookでメールをワンクリックで保存するためのアドインです。 

## 【必要要件】

- Microsoft .NET Framework 4.7.2
- Microsoft Visual Studio 2010 Tools for Office Runtime

不足している場合は、インストール時に自動的にインストールされます。

## 【インストール方法】

1. 「OutlookAddIn_OneClickSave/installer/setup.exe」を実行します。
1. インストーラの指示に従ってインストールしてください。

## 【バージョンアップ方法】

一度アンインストールしてからインストールしなおしてください。

## 【アンインストール方法】

1. スタートメニューより、「設定」→「アプリ」→「アプリと機能」を開きます。
1. 「OutlookAddIn_OneClickSave」をクリックして、「アンインストール」をクリックしてください。

## 【初期設定方法】

初回起動時は以下手順に従って設定をしてください。

1. Outlookを起動します。
1. ホームタブのワンクリック保存にある、「設定」ボタンをクリックしてください。
1. 保存先パスとオプションを指定して「設定保存」ボタンをクリックしてください。

## 【使用方法】

1. Outlookを起動します。
1. 保存したいメールを選択して、ホームタブのワンクリック保存にある、「保存」ボタンをクリックしてください。

## 【注意事項】

- 既に存在するファイルは上書きされます。
- 件名をファイル名にしますが、使用できない文字(/?<>など)は「_」に置き換えられます。
- 添付ファイルを分離して保存する場合、メールはtxt形式で保存されます。
- 添付ファイルを分離しないで保存した場合、msgファイルをダブルクリックで開いてしまうと、Outlookを終了するまでファイルがロック状態(使用中)になります。

## 【開発環境】
Microsoft Visual Studio Community 2019  
Version 16.8.2  

VisualStudio.16.Release/16.8.2+30717.126  
Microsoft .NET Framework  
Version 4.8.03752  

Office Developer Tools for Visual Studio   16.0.30502.00  
Microsoft Office Developer Tools for Visual Studio  

## 【ライセンス】

このプロジェクトはMITライセンスです。
詳細は [LICENSE](LICENSE) を参照してください。

## 【作者】

[overdrive1708](https://github.com/overdrive1708)

## 【変更履歴】

詳細は [CHANGELOG](CHANGELOG.md) を参照してください。