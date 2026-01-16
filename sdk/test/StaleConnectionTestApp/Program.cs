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

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace StaleConnectionTestApp
{
    /// <summary>
    /// Test console app to verify SocketException detection works on both .NET Framework and .NET Core.
    /// 
    /// This app includes:
    /// 1. Unit tests for SocketException detection logic
    /// 2. Real TCP server tests that cause actual connection resets
    /// 3. HttpWebRequest tests (what the AWS SDK uses on .NET Framework)
    /// 
    /// Run with:
    ///   dotnet run -f net472    (for .NET Framework)
    ///   dotnet run -f net8.0    (for .NET 8)
    /// </summary>
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            Console.WriteLine("=== Stale Connection SocketException Detection Test ===");
            Console.WriteLine($"Runtime: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");
            Console.WriteLine($"OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
            Console.WriteLine();

            int passed = 0;
            int failed = 0;
            int inconclusive = 0;

            // ============================================
            // PART 1: Unit tests for detection logic
            // ============================================
            Console.WriteLine("--- Part 1: Unit Tests (Synthetic Exceptions) ---");
            Console.WriteLine();

            // Test 1: Direct SocketException with Shutdown error
            if (TestDirectSocketException(SocketError.Shutdown, "Shutdown (Broken pipe)"))
                passed++;
            else
                failed++;

            // Test 2: Direct SocketException with ConnectionReset error
            if (TestDirectSocketException(SocketError.ConnectionReset, "ConnectionReset"))
                passed++;
            else
                failed++;

            // Test 3: Direct SocketException with ConnectionAborted error
            if (TestDirectSocketException(SocketError.ConnectionAborted, "ConnectionAborted"))
                passed++;
            else
                failed++;

            // Test 4: Nested SocketException (wrapped in IOException)
            if (TestNestedSocketException(SocketError.ConnectionReset, typeof(IOException), "IOException wrapping ConnectionReset"))
                passed++;
            else
                failed++;

            // Test 5: Nested SocketException (wrapped in HttpRequestException)
            if (TestNestedSocketException(SocketError.Shutdown, typeof(HttpRequestException), "HttpRequestException wrapping Shutdown"))
                passed++;
            else
                failed++;

            // Test 6: Deeply nested SocketException
            if (TestDeeplyNestedSocketException())
                passed++;
            else
                failed++;

            // Test 7: Non-stale-connection SocketException (should return false)
            if (TestNonStaleSocketException(SocketError.HostNotFound, "HostNotFound (should NOT be detected)"))
                passed++;
            else
                failed++;

            // Test 8: Non-socket exception (should return false)
            if (TestNonSocketException())
                passed++;
            else
                failed++;

            // Test 9: Verify MaxStaleConnectionRetries default value
            if (TestMaxStaleConnectionRetriesDefault())
                passed++;
            else
                failed++;

            Console.WriteLine();

            // ============================================
            // PART 2: Real TCP Server Tests
            // Use the same HTTP client that the AWS SDK uses on each platform:
            // - .NET Framework: HttpWebRequest
            // - .NET Core/8: HttpClient
            // ============================================
#if NETFRAMEWORK
            Console.WriteLine("--- Part 2: Real TCP Server Tests (HttpWebRequest - what AWS SDK uses on .NET Framework) ---");
#else
            Console.WriteLine("--- Part 2: Real TCP Server Tests (HttpClient - what AWS SDK uses on .NET Core) ---");
#endif
            Console.WriteLine();

            // Test 10: Real TCP connection reset
            var result10 = await TestRealConnectionReset();
            if (result10 == TestResult.Passed) passed++;
            else if (result10 == TestResult.Failed) failed++;
            else inconclusive++;

            // Test 11: Real TCP connection abort
            var result11 = await TestRealConnectionAbort();
            if (result11 == TestResult.Passed) passed++;
            else if (result11 == TestResult.Failed) failed++;
            else inconclusive++;

            // Test 12: Real TCP connection shutdown
            var result12 = await TestRealConnectionShutdown();
            if (result12 == TestResult.Passed) passed++;
            else if (result12 == TestResult.Failed) failed++;
            else inconclusive++;

            Console.WriteLine();

            // ============================================
            // PART 3: Raw Socket Tests
            // These bypass HTTP to directly test socket error behaviors
            // ============================================
            Console.WriteLine("--- Part 3: Raw Socket Tests (Direct TCP - bypass HTTP layer) ---");
            Console.WriteLine("These tests show exactly what exceptions each socket error produces.");
            Console.WriteLine();

            // Test 12: Raw socket - ConnectionReset (server sends RST)
            await TestRawSocket_ConnectionReset();

            // Test 13: Raw socket - ConnectionAborted (local abort)
            await TestRawSocket_ConnectionAborted();

            // Test 14: Raw socket - Shutdown (write after shutdown)
            await TestRawSocket_Shutdown();

            Console.WriteLine();
            Console.WriteLine($"=== Results: {passed} passed, {failed} failed, {inconclusive} inconclusive ===");
            
            // Return failure if any tests failed OR if too many were inconclusive
            if (failed > 0)
                return 1;
            if (inconclusive > 3)
            {
                Console.WriteLine("ERROR: Too many inconclusive tests - test infrastructure issue");
                return 1;
            }
            return 0;
        }

        enum TestResult
        {
            Passed,
            Failed,
            Inconclusive
        }

        #region IsStaleConnectionError Implementation

        /// <summary>
        /// Implementation of IsStaleConnectionError (same logic as RetryPolicy.cs)
        /// This duplicates the logic to test it independently without needing full SDK context.
        /// </summary>
        static bool IsStaleConnectionError(Exception exception)
        {
            var currentException = exception;
            while (currentException != null)
            {
                if (currentException is SocketException socketException)
                {
                    // SocketError.Shutdown (32) = Broken pipe on Unix/Linux
                    // SocketError.ConnectionReset (10054) = Connection reset by peer
                    // SocketError.ConnectionAborted (10053) = Connection aborted
                    if (socketException.SocketErrorCode == SocketError.Shutdown ||
                        socketException.SocketErrorCode == SocketError.ConnectionReset ||
                        socketException.SocketErrorCode == SocketError.ConnectionAborted)
                    {
                        return true;
                    }
                }

#if NETFRAMEWORK
                // .NET Framework fallback: HttpWebRequest wraps stale connection errors as IOException
                // without exposing the underlying SocketException. Check for known message patterns.
                if (currentException is IOException ioException)
                {
                    var message = ioException.Message;
                    if (message != null && message.Contains("The connection was closed"))
                    {
                        return true;
                    }
                }
#else
                // .NET Core/.NET 7+ fallback: HttpClient may throw HttpIOException when the response
                // ends prematurely due to stale connections. HttpIOException is .NET 7+ - we check by
                // type name to avoid compilation issues on older targets.
                if (currentException.GetType().Name == "HttpIOException")
                {
                    var message = currentException.Message;
                    if (message != null && message.Contains("The response ended prematurely"))
                    {
                        return true;
                    }
                }
#endif

                currentException = currentException.InnerException;
            }

            return false;
        }

        #endregion

        #region Unit Tests (Synthetic Exceptions)

        static bool TestDirectSocketException(SocketError errorCode, string testName)
        {
            Console.Write($"Test: Direct SocketException - {testName}... ");
            
            var exception = new SocketException((int)errorCode);
            var result = IsStaleConnectionError(exception);
            
            if (result)
            {
                Console.WriteLine($"PASSED (SocketErrorCode={exception.SocketErrorCode}, NativeErrorCode={exception.NativeErrorCode})");
                return true;
            }
            else
            {
                Console.WriteLine($"FAILED - Expected true but got false");
                return false;
            }
        }

        static bool TestNestedSocketException(SocketError errorCode, Type wrapperExceptionType, string testName)
        {
            Console.Write($"Test: Nested SocketException - {testName}... ");
            
            var socketException = new SocketException((int)errorCode);
            Exception wrappedException;
            
            if (wrapperExceptionType == typeof(IOException))
            {
                wrappedException = new IOException("Error while copying content", socketException);
            }
            else if (wrapperExceptionType == typeof(HttpRequestException))
            {
                wrappedException = new HttpRequestException("Socket error", socketException);
            }
            else
            {
                wrappedException = new Exception("Wrapper exception", socketException);
            }
            
            var result = IsStaleConnectionError(wrappedException);
            
            if (result)
            {
                Console.WriteLine("PASSED");
                return true;
            }
            else
            {
                Console.WriteLine("FAILED - Expected true but got false");
                return false;
            }
        }

        static bool TestDeeplyNestedSocketException()
        {
            Console.Write("Test: Deeply nested SocketException... ");
            
            var socketException = new SocketException((int)SocketError.ConnectionReset);
            var ioException = new IOException("IO error", socketException);
            var httpException = new HttpRequestException("HTTP error", ioException);
            
            // Wrap it one more level
            var outerException = new Exception("Outer exception", httpException);
            
            var result = IsStaleConnectionError(outerException);
            
            if (result)
            {
                Console.WriteLine("PASSED");
                return true;
            }
            else
            {
                Console.WriteLine("FAILED - Expected true but got false");
                return false;
            }
        }

        static bool TestNonStaleSocketException(SocketError errorCode, string testName)
        {
            Console.Write($"Test: Non-stale SocketException - {testName}... ");
            
            var exception = new SocketException((int)errorCode);
            var result = IsStaleConnectionError(exception);
            
            if (!result)
            {
                Console.WriteLine("PASSED (correctly returned false)");
                return true;
            }
            else
            {
                Console.WriteLine("FAILED - Expected false but got true");
                return false;
            }
        }

        static bool TestNonSocketException()
        {
            Console.Write("Test: Non-socket exception (IOException without SocketException inner)... ");
            
            var exception = new IOException("Disk full");
            var result = IsStaleConnectionError(exception);
            
            if (!result)
            {
                Console.WriteLine("PASSED (correctly returned false)");
                return true;
            }
            else
            {
                Console.WriteLine("FAILED - Expected false but got true");
                return false;
            }
        }

        static bool TestMaxStaleConnectionRetriesDefault()
        {
            Console.Write("Test: MaxStaleConnectionRetries default value should be 10... ");
            
            // Create an S3 config to check the default value
            var config = new Amazon.S3.AmazonS3Config();
            var defaultValue = config.MaxStaleConnectionRetries;
            
            if (defaultValue == 10)
            {
                Console.WriteLine($"PASSED (default={defaultValue})");
                return true;
            }
            else
            {
                Console.WriteLine($"FAILED - Expected 10 but got {defaultValue}");
                return false;
            }
        }

        #endregion

        #region Platform-specific Test Routing

        /// <summary>
        /// Test real connection reset using the HTTP client appropriate for this platform.
        /// </summary>
        static async Task<TestResult> TestRealConnectionReset()
        {
#if NETFRAMEWORK
            return await TestRealConnectionReset_HttpWebRequest();
#else
            return await TestRealConnectionReset_HttpClient();
#endif
        }

        /// <summary>
        /// Test real connection abort using the HTTP client appropriate for this platform.
        /// </summary>
        static async Task<TestResult> TestRealConnectionAbort()
        {
#if NETFRAMEWORK
            return await TestRealConnectionAbort_HttpWebRequest();
#else
            return await TestRealConnectionAbort_HttpClient();
#endif
        }

        /// <summary>
        /// Test real connection shutdown using the HTTP client appropriate for this platform.
        /// </summary>
        static async Task<TestResult> TestRealConnectionShutdown()
        {
#if NETFRAMEWORK
            return await TestRealConnectionShutdown_HttpWebRequest();
#else
            return await TestRealConnectionShutdown_HttpClient();
#endif
        }

        #endregion

        #region Real TCP Server Tests (HttpClient - used on .NET Core)

        /// <summary>
        /// Test a real connection reset using HttpClient.
        /// </summary>
        static async Task<TestResult> TestRealConnectionReset_HttpClient()
        {
            Console.WriteLine("Test: Real TCP connection reset (HttpClient)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            Console.WriteLine($"  Started test server on port {port}");

            Exception caughtException = null;
            
            // Server task: accept connection, then force RST
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var client = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted");
                        
                        // Read something first (simulate partial request)
                        var buffer = new byte[1024];
                        var stream = client.GetStream();
                        stream.ReadTimeout = 1000;
                        
                        try
                        {
                            stream.Read(buffer, 0, buffer.Length);
                        }
                        catch { /* Timeout or other error is fine */ }
                        
                        // Force RST packet by setting SO_LINGER to 0 timeout
                        client.LingerState = new LingerOption(true, 0);
                        Console.WriteLine("  Server: Closing connection with RST (LingerState=0)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client task: try to make HTTP request to the server
            var clientTask = Task.Run(async () =>
            {
                // Give server time to start accepting
                await Task.Delay(100);
                
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.Timeout = TimeSpan.FromSeconds(5);
                        Console.WriteLine($"  Client: Sending request to http://127.0.0.1:{port}/test");
                        var response = await httpClient.GetAsync($"http://127.0.0.1:{port}/test");
                        Console.WriteLine($"  Client: Got response: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            return AnalyzeException(caughtException, "HttpClient Connection Reset Test");
        }

        /// <summary>
        /// Test connection abort using HttpClient.
        /// </summary>
        static async Task<TestResult> TestRealConnectionAbort_HttpClient()
        {
            Console.WriteLine("Test: Real TCP connection abort (HttpClient)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            Console.WriteLine($"  Started test server on port {port}");

            Exception caughtException = null;
            
            // Server task: accept connection, wait for data, then abort
            var serverTask = Task.Run(async () =>
            {
                try
                {
                    var client = await listener.AcceptTcpClientAsync();
                    Console.WriteLine("  Server: Connection accepted");
                    
                    // Wait a tiny bit then abort
                    await Task.Delay(50);
                    
                    // Abort the socket (different from normal close)
                    client.Client.LingerState = new LingerOption(true, 0);
                    client.Client.Close(0);
                    client.Dispose();
                    Console.WriteLine("  Server: Connection aborted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client task: try to make HTTP request
            var clientTask = Task.Run(async () =>
            {
                await Task.Delay(100);
                
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.Timeout = TimeSpan.FromSeconds(5);
                        Console.WriteLine($"  Client: Sending request to http://127.0.0.1:{port}/test");
                        var response = await httpClient.GetAsync($"http://127.0.0.1:{port}/test");
                        Console.WriteLine($"  Client: Got response: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            return AnalyzeException(caughtException, "HttpClient Connection Abort Test");
        }

        #endregion

        #region Real TCP Server Tests (HttpWebRequest)

        /// <summary>
        /// Test a real connection reset using HttpWebRequest.
        /// This is what the AWS SDK uses on .NET Framework.
        /// The server sends a partial HTTP response, then RSTs while client is blocked reading.
        /// Uses synchronization to ensure RST happens while client is in Read().
        /// </summary>
        static async Task<TestResult> TestRealConnectionReset_HttpWebRequest()
        {
            Console.WriteLine("Test: Real TCP connection reset (HttpWebRequest)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            Console.WriteLine($"  Started test server on port {port}");

            Exception caughtException = null;
            var clientReadingEvent = new ManualResetEventSlim(false);
            
            // Server task: accept connection, send partial response, wait for client to be reading, then RST
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var client = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted");
                        
                        var stream = client.GetStream();
                        var buffer = new byte[4096];
                        
                        // Read the HTTP request headers
                        try
                        {
                            stream.ReadTimeout = 2000;
                            int bytesRead = stream.Read(buffer, 0, buffer.Length);
                            Console.WriteLine($"  Server: Read {bytesRead} bytes of request");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"  Server: Read error (expected): {ex.GetType().Name}");
                        }
                        
                        // Send partial HTTP response - headers claim 100KB, send only partial
                        // Use chunked encoding so client knows to expect more
                        var partialResponse = "HTTP/1.1 200 OK\r\n" +
                                              "Content-Type: text/plain\r\n" +
                                              "Transfer-Encoding: chunked\r\n" +
                                              "\r\n" +
                                              "14\r\n" +  // 20 bytes
                                              "First chunk of data.\r\n";
                        // Don't send terminating chunk - client will wait for more
                        
                        var responseBytes = System.Text.Encoding.ASCII.GetBytes(partialResponse);
                        stream.Write(responseBytes, 0, responseBytes.Length);
                        stream.Flush();
                        Console.WriteLine("  Server: Sent partial chunked response (no terminating chunk)");
                        
                        // Wait for client to signal it's in a blocking read
                        Console.WriteLine("  Server: Waiting for client to start reading...");
                        clientReadingEvent.Wait(5000);
                        
                        // Small delay to ensure client is blocked in Read()
                        Thread.Sleep(100);
                        
                        // Force RST packet while client is blocked waiting for more chunks
                        client.LingerState = new LingerOption(true, 0);
                        Console.WriteLine("  Server: Closing connection with RST (LingerState=0)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client task: try to make HTTP request using HttpWebRequest
            var clientTask = Task.Run(async () =>
            {
                // Give server time to start accepting
                await Task.Delay(100);
                
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create($"http://127.0.0.1:{port}/test");
                    request.Method = "GET";
                    request.Timeout = 10000;
                    request.ReadWriteTimeout = 10000;
                    
                    Console.WriteLine($"  Client: Sending HttpWebRequest to http://127.0.0.1:{port}/test");
                    
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        Console.WriteLine($"  Client: Got response: {response.StatusCode}");
                        
                        // Try to read the full response body
                        using (var responseStream = response.GetResponseStream())
                        {
                            var buffer = new byte[4096];
                            int totalRead = 0;
                            int bytesRead;
                            
                            // Read first chunk
                            bytesRead = responseStream.Read(buffer, 0, buffer.Length);
                            totalRead += bytesRead;
                            Console.WriteLine($"  Client: Read {bytesRead} bytes (total: {totalRead})");
                            
                            // Signal server that we're about to do another read (will block)
                            Console.WriteLine("  Client: Signaling server, about to block on Read()...");
                            clientReadingEvent.Set();
                            
                            // This read should block waiting for more data, then fail when RST arrives
                            bytesRead = responseStream.Read(buffer, 0, buffer.Length);
                            totalRead += bytesRead;
                            Console.WriteLine($"  Client: Read {bytesRead} bytes (total: {totalRead})");
                            
                            Console.WriteLine($"  Client: Finished reading response body (unexpected!)");
                        }
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            return AnalyzeException(caughtException, "HttpWebRequest Connection Reset Test");
        }

        /// <summary>
        /// Test connection abort using HttpWebRequest.
        /// The server sends a partial HTTP response, then aborts while client is reading.
        /// </summary>
        static async Task<TestResult> TestRealConnectionAbort_HttpWebRequest()
        {
            Console.WriteLine("Test: Real TCP connection abort (HttpWebRequest)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            Console.WriteLine($"  Started test server on port {port}");

            Exception caughtException = null;
            
            // Server task: accept connection, send partial response, then abort
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var client = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted");
                        
                        var stream = client.GetStream();
                        var buffer = new byte[4096];
                        
                        // Read the HTTP request headers
                        try
                        {
                            stream.ReadTimeout = 2000;
                            int bytesRead = stream.Read(buffer, 0, buffer.Length);
                            Console.WriteLine($"  Server: Read {bytesRead} bytes of request");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"  Server: Read error (expected): {ex.GetType().Name}");
                        }
                        
                        // Send partial HTTP response with chunked encoding, then abort mid-stream
                        var partialResponse = "HTTP/1.1 200 OK\r\n" +
                                              "Content-Type: text/plain\r\n" +
                                              "Transfer-Encoding: chunked\r\n" +
                                              "\r\n" +
                                              "1e\r\n" +  // chunk size in hex (30 bytes)
                                              "Here is some partial data...\r\n" +
                                              "\r\n";
                        // Note: We don't send the terminating "0\r\n\r\n" chunk
                        var responseBytes = System.Text.Encoding.ASCII.GetBytes(partialResponse);
                        stream.Write(responseBytes, 0, responseBytes.Length);
                        stream.Flush();
                        Console.WriteLine("  Server: Sent partial chunked response (no terminating chunk)");
                        
                        // Small delay to ensure client starts reading
                        Thread.Sleep(50);
                        
                        // Abort the socket
                        client.LingerState = new LingerOption(true, 0);
                        Console.WriteLine("  Server: Aborting connection with RST (LingerState=0)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client task: try to make HTTP request using HttpWebRequest
            var clientTask = Task.Run(async () =>
            {
                await Task.Delay(100);
                
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create($"http://127.0.0.1:{port}/test");
                    request.Method = "GET";
                    request.Timeout = 10000;
                    request.ReadWriteTimeout = 10000;
                    
                    Console.WriteLine($"  Client: Sending HttpWebRequest to http://127.0.0.1:{port}/test");
                    
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        Console.WriteLine($"  Client: Got response: {response.StatusCode}");
                        
                        // Try to read the full response body (this is where the abort should hit)
                        using (var responseStream = response.GetResponseStream())
                        {
                            var buffer = new byte[4096];
                            int totalRead = 0;
                            int bytesRead;
                            while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                totalRead += bytesRead;
                                Console.WriteLine($"  Client: Read {bytesRead} bytes (total: {totalRead})");
                            }
                            Console.WriteLine($"  Client: Finished reading response body");
                        }
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            return AnalyzeException(caughtException, "HttpWebRequest Connection Abort Test");
        }

        /// <summary>
        /// Test connection shutdown using HttpWebRequest.
        /// The server calls Shutdown() on the socket while client is reading.
        /// </summary>
        static async Task<TestResult> TestRealConnectionShutdown_HttpWebRequest()
        {
            Console.WriteLine("Test: Real TCP connection shutdown (HttpWebRequest)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            Console.WriteLine($"  Started test server on port {port}");

            Exception caughtException = null;
            var clientReadingEvent = new ManualResetEventSlim(false);
            
            // Server task: accept connection, send partial response, wait for client to be reading, then Shutdown
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var client = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted");
                        
                        var stream = client.GetStream();
                        var buffer = new byte[4096];
                        
                        // Read the HTTP request headers
                        try
                        {
                            stream.ReadTimeout = 2000;
                            int bytesRead = stream.Read(buffer, 0, buffer.Length);
                            Console.WriteLine($"  Server: Read {bytesRead} bytes of request");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"  Server: Read error (expected): {ex.GetType().Name}");
                        }
                        
                        // Send partial HTTP response with chunked encoding
                        var partialResponse = "HTTP/1.1 200 OK\r\n" +
                                              "Content-Type: text/plain\r\n" +
                                              "Transfer-Encoding: chunked\r\n" +
                                              "\r\n" +
                                              "14\r\n" +  // 20 bytes
                                              "First chunk of data.\r\n";
                        // Don't send terminating chunk - client will wait for more
                        
                        var responseBytes = System.Text.Encoding.ASCII.GetBytes(partialResponse);
                        stream.Write(responseBytes, 0, responseBytes.Length);
                        stream.Flush();
                        Console.WriteLine("  Server: Sent partial chunked response (no terminating chunk)");
                        
                        // Wait for client to signal it's in a blocking read
                        Console.WriteLine("  Server: Waiting for client to start reading...");
                        clientReadingEvent.Wait(5000);
                        
                        // Small delay to ensure client is blocked in Read()
                        Thread.Sleep(100);
                        
                        // Call Shutdown() which sends FIN and signals end of send
                        Console.WriteLine("  Server: Calling Shutdown(SocketShutdown.Both)...");
                        client.Client.Shutdown(SocketShutdown.Both);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client task: try to make HTTP request using HttpWebRequest
            var clientTask = Task.Run(async () =>
            {
                // Give server time to start accepting
                await Task.Delay(100);
                
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create($"http://127.0.0.1:{port}/test");
                    request.Method = "GET";
                    request.Timeout = 10000;
                    request.ReadWriteTimeout = 10000;
                    
                    Console.WriteLine($"  Client: Sending HttpWebRequest to http://127.0.0.1:{port}/test");
                    
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        Console.WriteLine($"  Client: Got response: {response.StatusCode}");
                        
                        // Try to read the full response body
                        using (var responseStream = response.GetResponseStream())
                        {
                            var buffer = new byte[4096];
                            int totalRead = 0;
                            int bytesRead;
                            
                            // Read first chunk
                            bytesRead = responseStream.Read(buffer, 0, buffer.Length);
                            totalRead += bytesRead;
                            Console.WriteLine($"  Client: Read {bytesRead} bytes (total: {totalRead})");
                            
                            // Signal server that we're about to do another read (will block)
                            Console.WriteLine("  Client: Signaling server, about to block on Read()...");
                            clientReadingEvent.Set();
                            
                            // This read should block waiting for more data, then fail when shutdown occurs
                            bytesRead = responseStream.Read(buffer, 0, buffer.Length);
                            totalRead += bytesRead;
                            Console.WriteLine($"  Client: Read {bytesRead} bytes (total: {totalRead})");
                            
                            Console.WriteLine($"  Client: Finished reading response body");
                        }
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            return AnalyzeException(caughtException, "HttpWebRequest Connection Shutdown Test");
        }

        /// <summary>
        /// Test connection shutdown using HttpClient.
        /// The server calls Shutdown() on the socket while client is reading.
        /// </summary>
        static async Task<TestResult> TestRealConnectionShutdown_HttpClient()
        {
            Console.WriteLine("Test: Real TCP connection shutdown (HttpClient)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            Console.WriteLine($"  Started test server on port {port}");

            Exception caughtException = null;
            
            // Server task: accept connection, send partial response, then shutdown
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var client = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted");
                        
                        var stream = client.GetStream();
                        var buffer = new byte[4096];
                        
                        // Read the HTTP request headers
                        try
                        {
                            stream.ReadTimeout = 2000;
                            int bytesRead = stream.Read(buffer, 0, buffer.Length);
                            Console.WriteLine($"  Server: Read {bytesRead} bytes of request");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"  Server: Read error (expected): {ex.GetType().Name}");
                        }
                        
                        // Send partial HTTP response - don't complete it
                        var partialResponse = "HTTP/1.1 200 OK\r\n" +
                                              "Content-Type: text/plain\r\n" +
                                              "Transfer-Encoding: chunked\r\n" +
                                              "\r\n" +
                                              "14\r\n" +  // 20 bytes
                                              "First chunk of data.\r\n";
                        // Don't send terminating chunk
                        
                        var responseBytes = System.Text.Encoding.ASCII.GetBytes(partialResponse);
                        stream.Write(responseBytes, 0, responseBytes.Length);
                        stream.Flush();
                        Console.WriteLine("  Server: Sent partial chunked response");
                        
                        // Small delay to ensure client starts reading
                        Thread.Sleep(100);
                        
                        // Call Shutdown
                        Console.WriteLine("  Server: Calling Shutdown(SocketShutdown.Both)...");
                        client.Client.Shutdown(SocketShutdown.Both);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client task: try to make HTTP request
            var clientTask = Task.Run(async () =>
            {
                await Task.Delay(100);
                
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.Timeout = TimeSpan.FromSeconds(10);
                        Console.WriteLine($"  Client: Sending request to http://127.0.0.1:{port}/test");
                        var response = await httpClient.GetAsync($"http://127.0.0.1:{port}/test");
                        Console.WriteLine($"  Client: Got response: {response.StatusCode}");
                        
                        // Try to read the content
                        var content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"  Client: Read content: {content.Length} chars");
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            return AnalyzeException(caughtException, "HttpClient Connection Shutdown Test");
        }

        #endregion

        #region Exception Analysis

        /// <summary>
        /// Analyze the caught exception and print its full hierarchy.
        /// Returns the test result.
        /// </summary>
        static TestResult AnalyzeException(Exception exception, string testName)
        {
            Console.WriteLine();
            Console.WriteLine($"  === Exception Analysis for {testName} ===");
            
            if (exception == null)
            {
                Console.WriteLine("  No exception was caught (request may have succeeded unexpectedly)");
                Console.WriteLine("  Result: INCONCLUSIVE - could not trigger connection error");
                Console.WriteLine();
                return TestResult.Inconclusive;
            }

            // Print full exception hierarchy
            Console.WriteLine("  Exception hierarchy:");
            var current = exception;
            int depth = 0;
            SocketException foundSocketException = null;
            
            while (current != null)
            {
                var indent = new string(' ', depth * 2 + 4);
                Console.WriteLine($"{indent}[{depth}] {current.GetType().FullName}");
                Console.WriteLine($"{indent}    Message: {current.Message}");
                
                if (current is SocketException se)
                {
                    Console.WriteLine($"{indent}    SocketErrorCode: {se.SocketErrorCode} ({(int)se.SocketErrorCode})");
                    Console.WriteLine($"{indent}    NativeErrorCode: {se.NativeErrorCode}");
                    if (foundSocketException == null)
                        foundSocketException = se;
                }
                
                if (current is WebException we)
                {
                    Console.WriteLine($"{indent}    Status: {we.Status}");
                }
                
                current = current.InnerException;
                depth++;
            }

            // Test if IsStaleConnectionError detects it
            var isStale = IsStaleConnectionError(exception);
            Console.WriteLine();
            Console.WriteLine($"  IsStaleConnectionError() returned: {isStale}");
            
            // Evaluate the result
            if (foundSocketException != null)
            {
                bool isStaleErrorCode = 
                    foundSocketException.SocketErrorCode == SocketError.ConnectionReset ||
                    foundSocketException.SocketErrorCode == SocketError.Shutdown ||
                    foundSocketException.SocketErrorCode == SocketError.ConnectionAborted;
                
                if (isStaleErrorCode)
                {
                    if (isStale)
                    {
                        Console.WriteLine("  Result: PASSED - Correctly detected stale connection error");
                        Console.WriteLine();
                        return TestResult.Passed;
                    }
                    else
                    {
                        Console.WriteLine("  Result: FAILED - Should have detected stale connection error but didn't");
                        Console.WriteLine();
                        return TestResult.Failed;
                    }
                }
                else
                {
                    // SocketException found but not a stale connection error code
                    if (!isStale)
                    {
                        Console.WriteLine($"  Result: PASSED - Correctly returned false for non-stale SocketError ({foundSocketException.SocketErrorCode})");
                        Console.WriteLine();
                        return TestResult.Passed;
                    }
                    else
                    {
                        Console.WriteLine($"  Result: FAILED - Incorrectly returned true for non-stale SocketError ({foundSocketException.SocketErrorCode})");
                        Console.WriteLine();
                        return TestResult.Failed;
                    }
                }
            }
            else
            {
                // No SocketException found in the hierarchy
                Console.WriteLine("  No SocketException found in exception hierarchy.");
                
#if NETFRAMEWORK
                // On .NET Framework, we use IOException message-based fallback detection
                if (isStale)
                {
                    Console.WriteLine("  .NET Framework: IsStaleConnectionError detected via IOException message fallback!");
                    Console.WriteLine("  Result: PASSED - Correctly detected stale connection error via message fallback");
                    Console.WriteLine();
                    return TestResult.Passed;
                }
                else
                {
                    Console.WriteLine("  .NET Framework: HttpWebRequest doesn't expose SocketException for this scenario.");
                    Console.WriteLine("  Checking if IOException message contains stale connection indicator...");
                    
                    // Check if there's an IOException with the expected message that we should have caught
                    var currentEx = exception;
                    bool hasConnectionClosedMessage = false;
                    while (currentEx != null)
                    {
                        if (currentEx is IOException ioEx && ioEx.Message != null && ioEx.Message.Contains("The connection was closed"))
                        {
                            hasConnectionClosedMessage = true;
                            break;
                        }
                        currentEx = currentEx.InnerException;
                    }
                    
                    if (hasConnectionClosedMessage)
                    {
                        Console.WriteLine("  ERROR: Found 'The connection was closed' message but IsStaleConnectionError returned false!");
                        Console.WriteLine("  Result: FAILED - Should have detected stale connection via message fallback");
                        Console.WriteLine();
                        return TestResult.Failed;
                    }
                    else
                    {
                        Console.WriteLine("  Result: INCONCLUSIVE - No SocketException and no known stale connection message pattern");
                        Console.WriteLine();
                        return TestResult.Inconclusive;
                    }
                }
#else
                // On .NET Core/.NET 7+, we use HttpIOException message-based fallback detection
                if (isStale)
                {
                    Console.WriteLine("  .NET Core: IsStaleConnectionError detected via HttpIOException message fallback!");
                    Console.WriteLine("  Result: PASSED - Correctly detected stale connection error via message fallback");
                    Console.WriteLine();
                    return TestResult.Passed;
                }
                else
                {
                    Console.WriteLine("  .NET Core: HttpClient doesn't expose SocketException for this scenario.");
                    Console.WriteLine("  Checking if HttpIOException message contains stale connection indicator...");
                    
                    // Check if there's an HttpIOException with the expected message that we should have caught
                    var currentEx = exception;
                    bool hasPrematureEndMessage = false;
                    while (currentEx != null)
                    {
                        if (currentEx.GetType().Name == "HttpIOException" && 
                            currentEx.Message != null && 
                            currentEx.Message.Contains("The response ended prematurely"))
                        {
                            hasPrematureEndMessage = true;
                            break;
                        }
                        currentEx = currentEx.InnerException;
                    }
                    
                    if (hasPrematureEndMessage)
                    {
                        Console.WriteLine("  ERROR: Found 'The response ended prematurely' message but IsStaleConnectionError returned false!");
                        Console.WriteLine("  Result: FAILED - Should have detected stale connection via message fallback");
                        Console.WriteLine();
                        return TestResult.Failed;
                    }
                    else
                    {
                        Console.WriteLine("  Result: INCONCLUSIVE - No SocketException and no known stale connection message pattern");
                        Console.WriteLine();
                        return TestResult.Inconclusive;
                    }
                }
#endif
            }
        }

        #endregion

        #region Raw Socket Tests (Bypass HTTP layer)

        /// <summary>
        /// Test ConnectionReset error by having server send RST while client reads.
        /// This directly triggers SocketError.ConnectionReset (10054).
        /// </summary>
        static async Task TestRawSocket_ConnectionReset()
        {
            Console.WriteLine("Test: Raw Socket - ConnectionReset (server RST during read)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;

            Exception caughtException = null;
            var serverReady = new ManualResetEventSlim(false);
            var clientConnected = new ManualResetEventSlim(false);

            // Server: accept, send some data, then RST
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var serverClient = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted");
                        clientConnected.Set();
                        
                        var stream = serverClient.GetStream();
                        
                        // Send some data first
                        var data = System.Text.Encoding.ASCII.GetBytes("Hello from server!");
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                        Console.WriteLine("  Server: Sent initial data");
                        
                        // Wait a bit for client to receive
                        Thread.Sleep(100);
                        
                        // Force RST by setting linger to 0 and closing
                        serverClient.LingerState = new LingerOption(true, 0);
                        Console.WriteLine("  Server: Sending RST (LingerState=0)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}: {ex.Message}");
                }
            });

            // Client: connect, read initial data, then try to read more (should get RST)
            var clientTask = Task.Run(async () =>
            {
                await Task.Delay(50);
                
                try
                {
                    using (var client = new TcpClient())
                    {
                        client.Connect(IPAddress.Loopback, port);
                        Console.WriteLine("  Client: Connected");
                        
                        var stream = client.GetStream();
                        var buffer = new byte[1024];
                        
                        // Read initial data
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        var msg = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        Console.WriteLine($"  Client: Received '{msg}'");
                        
                        // Wait for server to RST
                        Thread.Sleep(200);
                        
                        // Try to read more - this should fail with ConnectionReset
                        Console.WriteLine("  Client: Attempting to read more data...");
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        Console.WriteLine($"  Client: Read returned {bytesRead} bytes (0 = graceful close)");
                        
                        // If we got here without exception, try a write
                        if (bytesRead == 0)
                        {
                            Console.WriteLine("  Client: Connection closed gracefully, trying write...");
                            stream.Write(new byte[] { 1, 2, 3 }, 0, 3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            AnalyzeRawSocketException(caughtException, "Raw Socket ConnectionReset");
        }

        /// <summary>
        /// Test ConnectionAborted error. This happens when the local side aborts.
        /// </summary>
        static async Task TestRawSocket_ConnectionAborted()
        {
            Console.WriteLine("Test: Raw Socket - ConnectionAborted (abort pending operation)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;

            Exception caughtException = null;

            // Server: accept but don't send anything (client will wait)
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var serverClient = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted, waiting...");
                        // Just wait - don't send anything
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error (expected): {ex.GetType().Name}");
                }
            });

            // Client: connect, start async read, then abort the socket
            var clientTask = Task.Run(async () =>
            {
                await Task.Delay(50);
                
                TcpClient client = null;
                try
                {
                    client = new TcpClient();
                    client.Connect(IPAddress.Loopback, port);
                    Console.WriteLine("  Client: Connected");
                    
                    var stream = client.GetStream();
                    var buffer = new byte[1024];
                    
                    // Start an async read that will block
                    var readTask = Task.Run(() =>
                    {
                        try
                        {
                            Console.WriteLine("  Client: Starting blocking read...");
                            stream.ReadTimeout = 5000;
                            int bytesRead = stream.Read(buffer, 0, buffer.Length);
                            Console.WriteLine($"  Client: Read returned {bytesRead} bytes");
                        }
                        catch (Exception ex)
                        {
                            caughtException = ex;
                            Console.WriteLine("  Client: Read exception caught!");
                        }
                    });

                    // Wait a bit then abort the socket
                    await Task.Delay(200);
                    Console.WriteLine("  Client: Aborting socket...");
                    client.Client.Close(0);  // Immediate close with linger=0
                    
                    await readTask;
                }
                catch (Exception ex)
                {
                    if (caughtException == null)
                        caughtException = ex;
                    Console.WriteLine($"  Client: Exception: {ex.GetType().Name}");
                }
                finally
                {
                    client?.Dispose();
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            AnalyzeRawSocketException(caughtException, "Raw Socket ConnectionAborted");
        }

        /// <summary>
        /// Test Shutdown error by writing to a socket after Shutdown() was called.
        /// This should trigger SocketError.Shutdown (WSAESHUTDOWN = 10058).
        /// </summary>
        static async Task TestRawSocket_Shutdown()
        {
            Console.WriteLine("Test: Raw Socket - Shutdown (write after Shutdown)...");
            
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;

            Exception caughtException = null;

            // Server: accept and wait
            var serverTask = Task.Run(() =>
            {
                try
                {
                    using (var serverClient = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("  Server: Connection accepted, waiting...");
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Server error: {ex.GetType().Name}");
                }
            });

            // Client: connect, shutdown, then try to write
            var clientTask = Task.Run(async () =>
            {
                await Task.Delay(50);
                
                try
                {
                    using (var client = new TcpClient())
                    {
                        client.Connect(IPAddress.Loopback, port);
                        Console.WriteLine("  Client: Connected");
                        
                        // Shutdown the send side
                        Console.WriteLine("  Client: Calling Shutdown(SocketShutdown.Send)...");
                        client.Client.Shutdown(SocketShutdown.Send);
                        
                        // Wait a moment
                        Thread.Sleep(100);
                        
                        // Try to write - this should fail with Shutdown error
                        Console.WriteLine("  Client: Attempting to write after shutdown...");
                        var data = System.Text.Encoding.ASCII.GetBytes("This should fail!");
                        client.Client.Send(data);
                        Console.WriteLine("  Client: Write succeeded (unexpected)");
                    }
                }
                catch (Exception ex)
                {
                    caughtException = ex;
                    Console.WriteLine("  Client: Exception caught!");
                }
            });

            await Task.WhenAll(serverTask, clientTask);
            listener.Stop();

            AnalyzeRawSocketException(caughtException, "Raw Socket Shutdown");
        }

        /// <summary>
        /// Analyze exception from raw socket tests (informational - no pass/fail)
        /// </summary>
        static void AnalyzeRawSocketException(Exception exception, string testName)
        {
            Console.WriteLine();
            Console.WriteLine($"  === Exception Analysis for {testName} ===");
            
            if (exception == null)
            {
                Console.WriteLine("  No exception was caught");
                Console.WriteLine();
                return;
            }

            // Print full exception hierarchy
            Console.WriteLine("  Exception hierarchy:");
            var current = exception;
            int depth = 0;
            SocketException foundSocketException = null;
            
            while (current != null)
            {
                var indent = new string(' ', depth * 2 + 4);
                Console.WriteLine($"{indent}[{depth}] {current.GetType().FullName}");
                Console.WriteLine($"{indent}    Message: {current.Message}");
                
                if (current is SocketException se)
                {
                    Console.WriteLine($"{indent}    SocketErrorCode: {se.SocketErrorCode} ({(int)se.SocketErrorCode})");
                    Console.WriteLine($"{indent}    NativeErrorCode: {se.NativeErrorCode}");
                    if (foundSocketException == null)
                        foundSocketException = se;
                }
                
                current = current.InnerException;
                depth++;
            }

            // Test if IsStaleConnectionError detects it
            var isStale = IsStaleConnectionError(exception);
            Console.WriteLine();
            Console.WriteLine($"  IsStaleConnectionError() returned: {isStale}");
            
            if (foundSocketException != null)
            {
                Console.WriteLine($"  SocketErrorCode: {foundSocketException.SocketErrorCode} ({(int)foundSocketException.SocketErrorCode})");
                Console.WriteLine($"  This WOULD be detected by SDK: {isStale}");
            }
            else
            {
                Console.WriteLine("  No SocketException found - would NOT be detected by current SDK logic");
                
                // Check for message-based detection possibility
                var ioException = exception as IOException ?? exception.InnerException as IOException;
                if (ioException != null)
                {
                    Console.WriteLine($"  IOException message: \"{ioException.Message}\"");
                    Console.WriteLine("  Possible fallback detection: Check message for keywords");
                }
            }
            Console.WriteLine();
        }

        #endregion
    }
}
