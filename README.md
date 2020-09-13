# CAP.Extensions

 [![Build status](https://ci.appveyor.com/api/projects/status/uya4v6998ee4xn6u/branch/master?svg=true)](https://ci.appveyor.com/project/MaiKeBing/cap-extensions/branch/master) 



![License](https://img.shields.io/github/license/maikebing/CAP.Extensions.svg)

CAP.Extensions 是 CAP的扩展版本库， 提供了针对CAP的两个组件：

- MaiKeBing.CAP.ZeroMQ [![MaiKeBing.CAP.ZeroMQ](https://img.shields.io/nuget/v/MaiKeBing.CAP.ZeroMQ.svg)](https://www.nuget.org/packages/MaiKeBing.CAP.ZeroMQ/)
  

  ![MaiKeBing.CAP.ZeroMQ](docs/cap_zeromq.png)
  

  ZeroMQ（也称为 ØMQ，0MQ 或 zmq）是一个可嵌入的网络通讯库（对 Socket 进行了封装）。 它提供了携带跨越多种传输协议（如：进程内，进程间，TCP 和多播）的原子消息的 sockets 。 有了ZeroMQ，我们可以通过发布-订阅、任务分发、和请求-回复等模式来建立 N-N 的 socket 连接。 ZeroMQ 的异步 I / O 模型为我们提供可扩展的基于异步消息处理任务的多核应用程序。当前组件使用了NetMQ 为CAP提供了 发布-订阅， 推送-拉取两种消息模式。 示例请参见Sample.ZeroMQ.InMemory， 当测试 推送-拉取 消息模式时 ， 可以启动 Sample.ConsoleApp 可以测试负载均衡。

   `Install-Package MaiKeBing.CAP.ZeroMQ`  

   

- MaiKeBing.CAP.LiteDB  [![MaiKeBing.CAP.LiteDB](https://img.shields.io/nuget/v/MaiKeBing.CAP.LiteDB.svg)](https://www.nuget.org/packages/MaiKeBing.CAP.LiteDB/)

    ![MaiKeBing.CAP.LiteDB](docs/cap_litedb.png)
   
   [LiteDB](http://www.litedb.org/)是一个小型的.NET平台开源的NoSQL类型的轻量级文件数据库。特点是小和快，dll文件只有200K大小，而且支持LINQ和命令行操作，数据库是一个单一文件，类似Sqlite。为CAP存储了本地文件的NoSQL存储方式， 示例请参见 Sample.LiteDB.InMemory
   
   `Install-Package MaiKeBing.CAP.LiteDB`


- MaiKeBing.HostedService.ZeroMQ  [![MaiKeBing.HostedService.ZeroMQ](https://img.shields.io/nuget/v/MaiKeBing.HostedService.ZeroMQ.svg)](https://www.nuget.org/packages/MaiKeBing.HostedService.ZeroMQ/)

    ![MaiKeBing.HostedService.ZeroMQ](docs/zeromq.jpg)
   
  将ZeroMQ作为HostedService 运行， 通过配置可以实现Pub-Sub、Push-Pull 两种分发模式
   
   `Install-Package MaiKeBing.HostedService.ZeroMQ`


## Contribute

One of the easiest ways to contribute is to participate in discussions and discuss issues. You can also contribute by submitting pull requests with code changes.

### License

[MIT](https://github.com/maikebing/CAP.Extensions/blob/master/LICENSE.txt)
