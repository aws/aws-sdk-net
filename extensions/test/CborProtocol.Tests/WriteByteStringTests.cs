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
using System.Formats.Cbor;
using System.IO;
using Amazon.Extensions.CborProtocol;
using Xunit;

namespace Amazon.CborProtocol.Tests;

public class WriteByteStringTests
{
    // Produces the reference bytes using the System.Formats.Cbor WriteByteString approach.
    private static byte[] EncodeViaToArray(MemoryStream stream)
    {
        var writer = new CborWriter();
        writer.WriteByteString(stream.ToArray());
        return writer.Encode();
    }

    private static byte[] EncodeViaExtension(MemoryStream stream)
    {
        var writer = new CborWriter();
        writer.WriteByteString(stream); // extension overload under test
        return writer.Encode();
    }

    [Fact]
    public void ExposableStream_TakesZeroCopyPath_AndMatchesToArray()
    {
        var payload = new byte[] { 1, 2, 3, 4, 5 };
        // Parameterless ctor + Write => buffer is publicly visible, so TryGetBuffer succeeds.
        var stream = new MemoryStream();
        stream.Write(payload, 0, payload.Length);

        Assert.True(stream.TryGetBuffer(out _), "Expected an exposable buffer for this test");
        Assert.Equal(EncodeViaToArray(stream), EncodeViaExtension(stream));
    }

    [Fact]
    public void NonExposableStream_FallsBackToToArray_AndMatches()
    {
        var payload = new byte[] { 10, 20, 30 };
        // MemoryStream(byte[]) is NOT publicly visible, so TryGetBuffer returns false
        // and the extension must fall back to ToArray().
        var stream = new MemoryStream(payload);

        Assert.False(stream.TryGetBuffer(out _), "Expected a non-exposable buffer for this test");
        Assert.Equal(EncodeViaToArray(stream), EncodeViaExtension(stream));
    }

    [Fact]
    public void EmptyStream_WritesEmptyByteString()
    {
        var stream = new MemoryStream();
        Assert.Equal(EncodeViaToArray(stream), EncodeViaExtension(stream));
    }

    [Fact]
    public void StreamWithNonZeroPosition_WritesFullContents_IndependentOfPosition()
    {
        var payload = new byte[] { 7, 8, 9, 10 };
        var stream = new MemoryStream();
        stream.Write(payload, 0, payload.Length);
        stream.Position = 2; // mid-stream position must not affect what is written

        Assert.Equal(EncodeViaToArray(stream), EncodeViaExtension(stream));
    }

    [Fact]
    public void LargeExposableStream_MatchesToArray()
    {
        var payload = new byte[100_000];
        new Random(42).NextBytes(payload);
        var stream = new MemoryStream();
        stream.Write(payload, 0, payload.Length);

        Assert.Equal(EncodeViaToArray(stream), EncodeViaExtension(stream));
    }
}
