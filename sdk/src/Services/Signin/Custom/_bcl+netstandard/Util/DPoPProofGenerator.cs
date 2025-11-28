#if NETSTANDARD20 || NETCOREAPP3_1 || BCL
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using System;
using System.Linq;
#else
using System;
using System.Security.Cryptography;
using Amazon.Util.Internal;
#endif

using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Amazon.Runtime.Credentials.Internal;

namespace Amazon.Signin.Util
{
#if NETSTANDARD20 || NETCOREAPP3_1 || BCL
    /// <summary>
    /// Utility class for generating DPoP Proof as a signed JSON Web Token (JWT).
    /// </summary>
    public static class DPoPProofGenerator
    {
        /// <summary>
        /// Generates DPoP Proof as a signed JSON Web Token (JWT).
        /// </summary>
        /// <param name="httpMethod">The HTTP method of the request the DPoP proof is for, such as POST for token requests and GET for API calls.</param>
        /// <param name="uri">The HTTP URI of the request the DPoP Proof JWT is for, without the fragment and query parameters.</param>
        /// <param name="dpopKey">PEM file contents containing the base64-encoding of the Elliptic Curve Private Key.</param>
        /// <returns>JWT token representing DPoP Proof.</returns>
        public static string GenerateProof(string httpMethod, string uri, ref string dpopKey)
        {
            var keyPair = GetOrCreateKeyPair(dpopKey);

            // Set the private key PEM in the ref parameter.
            dpopKey = GetPrivateKeyPEM(keyPair);

            var header = new JwtHeader
            {
                Type = "dpop+jwt",
                Algorithm = "ES256",
                Jwk = CreateJwk(keyPair.Public)
            };

            var payload = new JwtPayload
            {
                Jti = Guid.NewGuid().ToString(),
                HttpMethod = httpMethod,
                HttpUri = uri,
                IssuedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            };

            return CreateJwt(header, payload, keyPair.Private);
        }

        private static AsymmetricCipherKeyPair GetOrCreateKeyPair(string dpopKey)
        {
            if (dpopKey != null)
            {
                return LoadKeyPair(dpopKey);
            }

            return GenerateKeyPair();
        }

        private static AsymmetricCipherKeyPair GenerateKeyPair()
        {
            string curveName = "prime256v1"; // 'prime256v1' is the standard OID name for 'P-256'/'secp256r1'

            // Get the OID (Object Identifier) for the named curve
            DerObjectIdentifier curveOid = X962NamedCurves.GetOid(curveName);

            if (curveOid == null)
            {
                // Fallback/Error handling if the standard name isn't found
                throw new InvalidOperationException($"Named curve '{curveName}' not found.");
            }

            var generator = new ECKeyPairGenerator();
            generator.Init(new ECKeyGenerationParameters(curveOid, new SecureRandom()));

            return generator.GenerateKeyPair();
        }

        private static AsymmetricCipherKeyPair LoadKeyPair(string dpopKey)
        {
            using (var reader = new StringReader(dpopKey))
            {
                var pemReader = new Org.BouncyCastle.OpenSsl.PemReader(reader);
                var pemObject = pemReader.ReadObject();

                if (pemObject is AsymmetricCipherKeyPair keyPair)
                    return keyPair;

                if (pemObject is ECPrivateKeyParameters privateKey)
                {
                    var publicKey = new ECPublicKeyParameters(
                        privateKey.Parameters.G.Multiply(privateKey.D),
                        privateKey.Parameters);
                    return new AsymmetricCipherKeyPair(publicKey, privateKey);
                }

                throw new InvalidOperationException("Invalid key format");
            }
        }

        private static string GetPrivateKeyPEM(AsymmetricCipherKeyPair keyPair)
        {
            using (var writer = new StringWriter())
            {
                var pemWriter = new Org.BouncyCastle.OpenSsl.PemWriter(writer);
                pemWriter.WriteObject(keyPair.Private);
                return writer.ToString();
            }
        }

        private static JsonWebKey CreateJwk(AsymmetricKeyParameter publicKey)
        {
            var ecPublicKey = (ECPublicKeyParameters)publicKey;
            var point = ecPublicKey.Q.Normalize();

            var x = point.XCoord.ToBigInteger().ToByteArrayUnsigned();
            var y = point.YCoord.ToBigInteger().ToByteArrayUnsigned();

            return new JsonWebKey
            {
                KeyType = "EC",
                Curve = "P-256",
                X = LoginUtils.Base64UrlEncode(PadTo32Bytes(x)),
                Y = LoginUtils.Base64UrlEncode(PadTo32Bytes(y))
            };
        }

        private static string CreateJwt(JwtHeader header, JwtPayload payload, AsymmetricKeyParameter privateKey)
        {
            var headerJson = JsonSerializer.Serialize(header);
            var payloadJson = JsonSerializer.Serialize(payload);

            var headerBase64 = LoginUtils.Base64UrlEncode(Encoding.UTF8.GetBytes(headerJson));
            var payloadBase64 = LoginUtils.Base64UrlEncode(Encoding.UTF8.GetBytes(payloadJson));

            var signingInput = $"{headerBase64}.{payloadBase64}";
            var signature = SignData(Encoding.UTF8.GetBytes(signingInput), privateKey);
            var signatureBase64 = LoginUtils.Base64UrlEncode(signature);

            return $"{signingInput}.{signatureBase64}";
        }

        private static byte[] SignData(byte[] data, AsymmetricKeyParameter privateKey)
        {
            var signer = new ECDsaSigner();
            signer.Init(true, privateKey);

            var hash = DigestUtilities.CalculateDigest("SHA-256", data);
            var signature = signer.GenerateSignature(hash);

            return EncodeDerSignature(signature[0], signature[1]);
        }

        private static byte[] EncodeDerSignature(BigInteger r, BigInteger s)
        {
            var rBytes = r.ToByteArrayUnsigned();
            var sBytes = s.ToByteArrayUnsigned();

            rBytes = PadTo32Bytes(rBytes);
            sBytes = PadTo32Bytes(sBytes);

            var result = new byte[64];
            Array.Copy(rBytes, 0, result, 0, 32);
            Array.Copy(sBytes, 0, result, 32, 32);

            return result;
        }

        private static byte[] PadTo32Bytes(byte[] input)
        {
            if (input.Length == 32) return input;
            if (input.Length > 32) return input.Skip(input.Length - 32).ToArray();

            var padded = new byte[32];
            Array.Copy(input, 0, padded, 32 - input.Length, input.Length);
            return padded;
        }
    }
#else
    /// <summary>
    /// Utility class for generating DPoP Proof as a signed JSON Web Token (JWT).
    /// </summary>
    public static class DPoPProofGenerator
    {
        /// <summary>
        /// Generates DPoP Proof as a signed JSON Web Token (JWT).
        /// </summary>
        /// <param name="httpMethod">The HTTP method of the request the DPoP proof is for, such as POST for token requests and GET for API calls.</param>
        /// <param name="uri">The HTTP URI of the request the DPoP Proof JWT is for, without the fragment and query parameters.</param>
        /// <param name="dpopKey">PEM file contents containing the base64-encoding of the Elliptic Curve Private Key.</param>
        /// <returns>JWT token representing DPoP Proof.</returns>
        public static string GenerateProof(string httpMethod, string uri, ref string dpopKey)
        {
            var privateKey = GetOrCreatePrivateKey(dpopKey);

            // Set the private key PEM in the ref parameter.
            dpopKey = GetPrivateKeyPEM(privateKey);

            var header = new JwtHeader
            {
                Type = "dpop+jwt",
                Algorithm = "ES256",
                Jwk = CreateJwk(privateKey)
            };

            var payload = new JwtPayload
            {
                Jti = Guid.NewGuid().ToString(),
                HttpMethod = httpMethod,
                HttpUri = uri,
                IssuedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            };

            return CreateJwt(header, payload, privateKey);
        }

        private static ECDsa GetOrCreatePrivateKey(string dpopKey)
        {
            if (dpopKey != null)
            {
                var key = ECDsa.Create();
                key.ImportFromPem(dpopKey);
                return key;
            }

            return ECDsa.Create(ECCurve.NamedCurves.nistP256);
        }

        private static string GetPrivateKeyPEM(ECDsa privateKey)
        {
            return privateKey.ExportECPrivateKeyPem();
        }

        private static JsonWebKey CreateJwk(ECDsa privateKey)
        {
            var publicKey = privateKey.ExportParameters(false);

            return new JsonWebKey
            {
                KeyType = "EC",
                Curve = "P-256",
                X = LoginUtils.Base64UrlEncode(publicKey.Q.X),
                Y = LoginUtils.Base64UrlEncode(publicKey.Q.Y)
            };
        }

        private static string CreateJwt(JwtHeader header, JwtPayload payload, ECDsa privateKey)
        {
            var headerJson = JsonSerializerHelper.Serialize<JwtHeader>(header, new DPoPJsonSerializerContexts());
            var payloadJson = JsonSerializerHelper.Serialize<JwtPayload>(payload, new DPoPJsonSerializerContexts());

            var headerBase64 = LoginUtils.Base64UrlEncode(Encoding.UTF8.GetBytes(headerJson));
            var payloadBase64 = LoginUtils.Base64UrlEncode(Encoding.UTF8.GetBytes(payloadJson));

            var signingInput = $"{headerBase64}.{payloadBase64}";
            var signature = privateKey.SignData(Encoding.UTF8.GetBytes(signingInput), HashAlgorithmName.SHA256);
            var signatureBase64 = LoginUtils.Base64UrlEncode(signature);

            return $"{signingInput}.{signatureBase64}";
        }
    }

    [JsonSerializable(typeof(JsonWebKey))]
    [JsonSerializable(typeof(JwtHeader))]
    [JsonSerializable(typeof(JwtPayload))]
    internal partial class DPoPJsonSerializerContexts : JsonSerializerContext
    {
    }
#endif

    internal class JwtHeader
    {
        [JsonPropertyName("typ")]
        public string Type { get; set; }
        
        [JsonPropertyName("alg")]
        public string Algorithm { get; set; }
        
        [JsonPropertyName("jwk")]
        public JsonWebKey Jwk { get; set; }
    }

    internal class JwtPayload
    {
        [JsonPropertyName("jti")]
        public string Jti { get; set; }
        
        [JsonPropertyName("htm")]
        public string HttpMethod { get; set; }
        
        [JsonPropertyName("htu")]
        public string HttpUri { get; set; }
        
        [JsonPropertyName("iat")]
        public long IssuedAt { get; set; }
    }

    internal class JsonWebKey
    {
        [JsonPropertyName("kty")]
        public string KeyType { get; set; }

        [JsonPropertyName("crv")]
        public string Curve { get; set; }
        
        [JsonPropertyName("x")]
        public string X { get; set; }
        
        [JsonPropertyName("y")]
        public string Y { get; set; }
    }
}
