using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

WebHost.Start(routes => routes.MapGet(
    "hello/{name}", (req, res, data) => res.WriteAsync($"Hello, {data.Values["name"]}")));
Console.ReadKey();
