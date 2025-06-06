using clojure.lang;

// start up Clojure runtime including compiler
RT.Init();

// compile nREPL lib
var ns = "clojure.tools.nrepl";
RT.var("clojure.core", "require").invoke(Symbol.intern(ns));

// create nREPL server (default port is 1667)
var startServer = RT.var(ns, "start-server!");
var server = startServer.invoke();

// allow exit on Ctrl-C by shutting down server
var stopServer = RT.var(ns, "stop-server!");
Console.CancelKeyPress += (_, _) => stopServer.invoke(server);
