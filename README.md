# CAP.Extensions

CAP.Extensions 是 CAP的扩展版本库， 提供了针对CAP的两个组件：

- DotNetCore.CAP.ZeroMQ

  ZeroMQ（也称为 ØMQ，0MQ 或 zmq）是一个可嵌入的网络通讯库（对 Socket 进行了封装）。 它提供了携带跨越多种传输协议（如：进程内，进程间，TCP 和多播）的原子消息的 sockets 。 有了ZeroMQ，我们可以通过发布-订阅、任务分发、和请求-回复等模式来建立 N-N 的 socket 连接。 ZeroMQ 的异步 I / O 模型为我们提供可扩展的基于异步消息处理任务的多核应用程序。当前组件使用了NetMQ 为CAP提供了 发布-订阅， 推送-拉取两种消息模式。 示例请参见Sample.ZeroMQ.InMemory， 当测试 推送-拉取 消息模式时 ， 可以启动 Sample.ConsoleApp 可以测试负载均衡。 

   

- DotNetCore.CAP.LiteDB

   [LiteDB](http://www.litedb.org/)是一个小型的.NET平台开源的NoSQL类型的轻量级文件数据库。特点是小和快，dll文件只有200K大小，而且支持LINQ和命令行操作，数据库是一个单一文件，类似Sqlite。为CAP存储了本地文件的NoSQL存储方式， 示例请参见 Sample.LiteDB.InMemory