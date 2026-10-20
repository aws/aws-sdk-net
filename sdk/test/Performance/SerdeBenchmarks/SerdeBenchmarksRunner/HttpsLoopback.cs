/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using Amazon.Runtime;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>The HTTP transport used by the --cpu-time cases.</summary>
public enum BenchmarkTransportKind
{
    /// <summary>In-process MockHttpHandler: no sockets, no server (the default).</summary>
    Stub,
    /// <summary>SocketsHttpHandler over TLS to a fixture server on loopback.</summary>
    Https
}

/// <summary>
/// Transport selection for the --cpu-time cases (--transport, --https-server, --fixture-control).
/// The BenchmarkDotNet suites always use the stub.
/// </summary>
public static class BenchmarkTransport
{
    public const string DefaultHttpsServer = "127.0.0.1:18443";
    public const string DefaultFixtureControl = "127.0.0.1:18080";

    public static BenchmarkTransportKind Kind { get; private set; } = BenchmarkTransportKind.Stub;
    public static IPEndPoint HttpsServer { get; private set; } = ParseEndpoint("--https-server", DefaultHttpsServer);
    public static IPEndPoint FixtureControl { get; private set; } = ParseEndpoint("--fixture-control", DefaultFixtureControl);

    /// <summary>Applies the command-line values. Throws ArgumentException for an invalid value.</summary>
    public static void Configure(string transport, string httpsServer, string fixtureControl)
    {
        Kind = transport switch
        {
            "stub" => BenchmarkTransportKind.Stub,
            "https" => BenchmarkTransportKind.Https,
            _ => throw new ArgumentException($"--transport {transport}: expected stub or https")
        };
        HttpsServer = ParseEndpoint("--https-server", httpsServer);
        FixtureControl = ParseEndpoint("--fixture-control", fixtureControl);
    }

    public static string Describe() => Kind == BenchmarkTransportKind.Stub
        ? "stub (in-process MockHttpHandler, no network I/O)"
        : $"https (SocketsHttpHandler, HTTP/1.1 over TLS with keep-alive, sockets redirected to {HttpsServer}; " +
          $"fixtures posted to {FixtureControl}; certificate not verified)";

    /// <summary>Fails fast if the fixture server's addresses don't accept connections.</summary>
    public static void CheckFixtureServer()
    {
        CheckConnect("--https-server", HttpsServer);
        CheckConnect("--fixture-control", FixtureControl);
    }

    internal static IPEndPoint ParseEndpoint(string option, string hostPort)
    {
        var example = option == "--https-server" ? DefaultHttpsServer : DefaultFixtureControl;
        // IPEndPoint.TryParse accepts a missing port as 0, so require one explicitly.
        if (!IPEndPoint.TryParse(hostPort, out var endpoint) || endpoint.Port == 0)
            throw new ArgumentException($"{option} {hostPort}: expected IP:PORT, for example {example}");
        // The server's certificate isn't verified, and the server runs on this host, so allow loopback only.
        if (!IPAddress.IsLoopback(endpoint.Address))
            throw new ArgumentException($"{option} {hostPort}: must be a loopback address, for example {example}");
        return endpoint;
    }

    private static void CheckConnect(string option, IPEndPoint endpoint)
    {
        try
        {
            using var tcp = new TcpClient();
            tcp.Connect(endpoint);
        }
        catch (SocketException e)
        {
            throw new InvalidOperationException(
                $"The fixture server isn't reachable at {option} {endpoint}: {e.Message}. Start it first (see README.md, HTTPS loopback mode).", e);
        }
    }
}

/// <summary>
/// The https transport: before each case the case's canned response is posted to the fixture server's control
/// address; the SDK client then sends every call through a real SocketsHttpHandler whose sockets connect to the
/// server's HTTPS address. Only the socket is redirected: endpoint resolution, the URL, the Host header, TLS SNI
/// and the SigV4 signature stay those of the real endpoint.
/// </summary>
internal static class HttpsLoopback
{
    /// <summary>
    /// Builds the HttpClient the way the SDK does when no HttpClientFactory is set (HttpRequestMessageFactory's
    /// CreateManagedHttpClient on .NET 8+), from the same client config. The only differences are the two this
    /// transport needs: a ConnectCallback that dials the fixture server, and accepting its self-signed certificate.
    /// </summary>
    public static HttpClient CreateClient(IClientConfig clientConfig)
    {
        var data = BenchmarkTransport.HttpsServer;
        var sockets = new SocketsHttpHandler
        {
            EnableMultipleHttp2Connections = true,
            ConnectCallback = async (ctx, ct) =>
            {
                var socket = new Socket(SocketType.Stream, ProtocolType.Tcp) { NoDelay = true };
                try
                {
                    await socket.ConnectAsync(data, ct).ConfigureAwait(false);
                    return new NetworkStream(socket, ownsSocket: true);
                }
                catch
                {
                    socket.Dispose();
                    throw;
                }
            },
        };
        sockets.SslOptions.RemoteCertificateValidationCallback = (_, _, _, _) => true; // the fixture server's certificate is self-signed

        // The rest mirrors CreateManagedHttpClient.
        if (clientConfig.ConnectTimeout.HasValue)
            sockets.ConnectTimeout = clientConfig.ConnectTimeout.Value;
        if (clientConfig.MaxConnectionsPerServer.HasValue)
            sockets.MaxConnectionsPerServer = clientConfig.MaxConnectionsPerServer.Value;
        sockets.AllowAutoRedirect = clientConfig.AllowAutoRedirect;
        sockets.AutomaticDecompression = DecompressionMethods.None;
        var proxy = clientConfig.GetWebProxy();
        if (proxy != null)
            sockets.Proxy = proxy;
        if (sockets.Proxy != null && clientConfig.ProxyCredentials != null)
            sockets.Proxy.Credentials = clientConfig.ProxyCredentials;

        var httpClient = new HttpClient(sockets);
        if (clientConfig.Timeout.HasValue)
            httpClient.Timeout = clientConfig.Timeout.Value;
        return httpClient;
    }

    // Posts fixtures to the control address. No proxy: the control address is on this host. The timeout makes a
    // control server that accepts but never answers fail the run instead of hanging it.
    private static readonly HttpClient ControlClient = new(new SocketsHttpHandler { UseProxy = false })
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    /// <summary>Replaces the fixture server's response (POST /fixture on its control address) and checks it was accepted.</summary>
    public static void PostFixture(byte[] fixture)
    {
        var control = BenchmarkTransport.FixtureControl;
        HttpResponseMessage response;
        try
        {
            response = ControlClient.Send(new HttpRequestMessage(HttpMethod.Post, $"http://{control}/fixture") { Content = new ByteArrayContent(fixture) });
        }
        catch (Exception e) when (e is HttpRequestException or TaskCanceledException)
        {
            throw new InvalidOperationException($"Couldn't post the fixture to --fixture-control {control}: {e.Message}", e);
        }
        using (response)
        {
            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new InvalidOperationException($"The fixture server at --fixture-control {control} rejected the fixture: {(int)response.StatusCode} {response.ReasonPhrase}");
        }
    }
}
