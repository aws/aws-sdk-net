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

using Amazon.Runtime;
using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Security.Cryptography;

namespace UnitTests.NetStandard.Core
{
    [TestClass]
    public class AWS4aSignerTests
    {
        private const string SigningTestAccessKeyId = "AKIDEXAMPLE";
        private const string SigningTestSecretAccessKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";

        /* The public coordinates of the ecc key derived from the above credentials pair */
        private const string SigningTestEccPubX = "b6618f6a65740a99e650b33b6b4b5bd0d43b176d721a3edfea7e7d2d56d936b1";
        private const string SigningTestEccPubY = "865ed22a7eadc9c5cb9d2cbaca1b3699139fedc5043dc6661864218330c8e518";

        [TestMethod]
        public void ComputeSigningKey()
        {
            using var key = AWS4aSigner.ComputeSigningKey(SigningTestAccessKeyId, SigningTestSecretAccessKey);
            var parameters = key.ExportParameters(false);
            CollectionAssert.AreEqual(AWSSDKUtils.HexStringToBytes(SigningTestEccPubX), parameters.Q.X);
            CollectionAssert.AreEqual(AWSSDKUtils.HexStringToBytes(SigningTestEccPubY), parameters.Q.Y);
        }

        [TestMethod]
        public void SignBlob()
        {
            var credentials = new ImmutableCredentials(SigningTestAccessKeyId, SigningTestSecretAccessKey, "");
            var data = new byte[] { 0x01, 0x02, 0x03, 0x04 };
            var signature = AWS4aSigner.SignBlob(credentials, data);
            Assert.IsNotNull(signature);
            using var publicKey = ECDsa.Create(new ECParameters
            {
                Curve = ECCurve.NamedCurves.nistP256,
                Q = new ECPoint
                {
                    X = AWSSDKUtils.HexStringToBytes(SigningTestEccPubX),
                    Y = AWSSDKUtils.HexStringToBytes(SigningTestEccPubY)
                }
            });
            // ECDSA signatures are non-deterministic, so unlike key derivation we can't compare against
            // a known-good signature. Instead, we sign a message and immediately verify it with the public key.
#if NET7_0_OR_GREATER
            Assert.IsTrue(publicKey.VerifyData(data, signature, HashAlgorithmName.SHA256, DSASignatureFormat.Rfc3279DerSequence));
#else
            Assert.IsTrue(VerifyDerSignature(publicKey, data, signature));
#endif
        }

        [TestMethod]
        // Test vectors ported from aws-c-auth tests/key_derivation_tests.c (be_sequence_compare).
        [DataRow([new byte[] { 0x00, 0x00, 0x00 }, new byte[] { 0x00, 0x00, 0x01 }, -1], DisplayName = "less")]
        [DataRow([new byte[] { 0xAB, 0xCD, 0x80, 0xFF, 0x01, 0x0A }, new byte[] { 0xAB, 0xCD, 0x80, 0xFF, 0x01, 0x0A }, 0], DisplayName = "equal")]
        [DataRow([new byte[] { 0xFF, 0xCD, 0x80, 0xFF, 0x01, 0x0A }, new byte[] { 0xFE, 0xCD, 0x80, 0xFF, 0x01, 0x0A }, 1], DisplayName = "greater")]
        public void CompareConstantTimeMatchesReference(byte[] lhs, byte[] rhs, int expectedResultSign)
        {
            Assert.AreEqual(expectedResultSign, Math.Sign(AWS4aSigner.CompareConstantTime(lhs, rhs)));
            Assert.AreEqual(-expectedResultSign, Math.Sign(AWS4aSigner.CompareConstantTime(rhs, lhs)));
        }

        [TestMethod]
        // Test vectors ported from aws-c-auth tests/key_derivation_tests.c (be_sequence_add_one).
        [DataRow([new byte[] { 0x00, 0x00, 0x00 }, new byte[] { 0x00, 0x00, 0x01 }])]
        [DataRow([new byte[] { 0x00, 0x00, 0xFF }, new byte[] { 0x00, 0x01, 0x00 }])]
        [DataRow([new byte[] { 0x00, 0xFF, 0xFF }, new byte[] { 0x01, 0x00, 0x00 }])]
        [DataRow([new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }, new byte[] { 0x00, 0x00, 0x00, 0x00 }])]
        public void AddOneConstantTimeMatchesReference(byte[] input, byte[] expectedOutput)
        {
            var output = new byte[input.Length];
            Array.Copy(input, output, input.Length);
            AWS4aSigner.AddOneConstantTime(output);
            CollectionAssert.AreEqual(expectedOutput, output);
        }

#if !NET7_0_OR_GREATER
        private static bool VerifyDerSignature(ECDsa publicKey, byte[] data, byte[] signature)
        {
            return publicKey.VerifyData(data, ConvertDerToIeee1363(signature, 256), HashAlgorithmName.SHA256);
        }

        // https://github.com/dotnet/runtime/blob/600c5b67ae4680acf39f6e85529973930bda4168/src/libraries/Common/src/System/Security/Cryptography/AsymmetricAlgorithmHelpers.Der.cs#L46-L112
        // Adapted to work with earlier frameworks.

        /// <summary>
        /// Convert Der format of (r, s) to Ieee1363 format
        /// </summary>
        private static byte[] ConvertDerToIeee1363(byte[] input, int fieldSizeBits)
        {
            int fieldSizeBytes = BitsToBytes(fieldSizeBits);
            int encodedSize = 2 * fieldSizeBytes;
            byte[] response = new byte[encodedSize];

            ConvertDerToIeee1363(input, fieldSizeBits, response);
            return response;
        }

        internal static int ConvertDerToIeee1363(byte[] input, int fieldSizeBits, Span<byte> destination)
        {
            int fieldSizeBytes = BitsToBytes(fieldSizeBits);
            int encodedSize = 2 * fieldSizeBytes;

            Debug.Assert(destination.Length >= encodedSize);

            AsnReader reader = new AsnReader(input, AsnEncodingRules.DER);
            AsnReader sequenceReader = reader.ReadSequence();
            reader.ThrowIfNotEmpty();
            ReadOnlyMemory<byte> rDer = sequenceReader.ReadIntegerBytes();
            ReadOnlyMemory<byte> sDer = sequenceReader.ReadIntegerBytes();
            sequenceReader.ThrowIfNotEmpty();

            CopySignatureField(rDer.Span, destination.Slice(0, fieldSizeBytes));
            CopySignatureField(sDer.Span, destination.Slice(fieldSizeBytes, fieldSizeBytes));
            return encodedSize;
        }

        private static void CopySignatureField(ReadOnlySpan<byte> signatureField, Span<byte> response)
        {
            if (signatureField.Length > response.Length)
            {
                if (signatureField.Length != response.Length + 1 ||
                    signatureField[0] != 0 ||
                    signatureField[1] <= 0x7F)
                {
                    // The only way this should be true is if the value required a zero-byte-pad.
                    Debug.Fail($"A signature field was longer ({signatureField.Length}) than expected ({response.Length})");
                    throw new CryptographicException();
                }

                signatureField = signatureField.Slice(1);
            }

            // If the field is too short then it needs to be prepended
            // with zeroes in the response.
            int writeOffset = response.Length - signatureField.Length;
            response.Slice(0, writeOffset).Clear();
            signatureField.CopyTo(response.Slice(writeOffset));
        }

        internal static int BitsToBytes(int bitLength)
        {
            int byteLength = (bitLength + 7) / 8;
            return byteLength;
        }
#endif
    }
}
