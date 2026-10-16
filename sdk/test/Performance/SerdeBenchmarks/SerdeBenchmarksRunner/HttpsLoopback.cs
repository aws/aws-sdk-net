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
using System.Text;

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
        int colon = hostPort.LastIndexOf(':');
        if (colon <= 0
            || !IPAddress.TryParse(hostPort[..colon], out var address)
            || !int.TryParse(hostPort[(colon + 1)..], out var port)
            || port < 1 || port > 65535)
        {
            throw new ArgumentException($"{option} {hostPort}: expected IP:PORT, for example 127.0.0.1:18443");
        }
        return new IPEndPoint(address, port);
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
    public static HttpClient CreateClient(MockHttpHandler handler)
    {
        PostFixture(BenchmarkTransport.FixtureControl, handler.BuildRawResponse());
        var data = BenchmarkTransport.HttpsServer;
        var sockets = new SocketsHttpHandler
        {
            UseProxy = false,
            AllowAutoRedirect = false,
            // Connections of earlier cases' clients are never reused; let them close.
            PooledConnectionIdleTimeout = TimeSpan.FromSeconds(10),
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
        return new HttpClient(sockets);
    }

    /// <summary>Replaces the fixture server's response (POST /fixture on its control address) and checks it was accepted.</summary>
    private static void PostFixture(IPEndPoint control, byte[] fixture)
    {
        using var tcp = new TcpClient();
        try
        {
            tcp.Connect(control);
        }
        catch (SocketException e)
        {
            throw new InvalidOperationException($"Couldn't post the fixture to --fixture-control {control}: {e.Message}", e);
        }
        var stream = tcp.GetStream();
        stream.Write(Encoding.ASCII.GetBytes($"POST /fixture HTTP/1.1\r\nHost: fixture\r\nContent-Length: {fixture.Length}\r\nConnection: close\r\n\r\n"));
        stream.Write(fixture);
        var status = new StringBuilder();
        int b;
        while ((b = stream.ReadByte()) >= 0 && b != '\n') status.Append((char)b);
        if (!status.ToString().StartsWith("HTTP/1.1 204"))
            throw new InvalidOperationException($"The fixture server rejected the fixture: {status.ToString().Trim()}");
    }
}
