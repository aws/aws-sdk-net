/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Text;
using System.Security.Cryptography;

using Amazon.Extensions.CognitoAuthentication.ThirdParty;

namespace Amazon.Extensions.CognitoAuthentication
{
    /// <summary>
    /// Class that provides utility methods for performing the Secure Remote Password protocol
    /// Adapted from http://srp.stanford.edu/design.html
    /// </summary>
    internal class AuthenticationHelper
    {
        // Static variables for computing SRP
        internal const string HexN =
            "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD129024E088A67CC74020BBEA63B139B22514A08798E3404DD"
            + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED"
            + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3DC2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F"
            + "83655D23DCA3AD961C62F356208552BB9ED529077096966D670C354E4ABC9804F1746C08CA18217C32905E462E36CE3B"
            + "E39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9DE2BCBF6955817183995497CEA956AE515D2261898FA0510"
            + "15728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7"
            + "ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6BF12FFA06D98A0864D87602733EC86A64521F2B18177B200C"
            + "BBE117577A615D6C770988C0BAD946E208E24FA074E5AB3143DB5BFCE0FD108E4B82D120A93AD2CAFFFFFFFFFFFFFFFF";

        internal static BigInteger N = new BigInteger(HexN, 16);
        internal static BigInteger g = BigInteger.ValueOf(2);

        // 1024 bits
        private const int EphemeralKeyByteLength = 128;
        private const int DerivedKeySize = 16;
        private const string DerivedKeyInfo = "Caldera Derived Key";

        /// <summary>
        /// Return the Tuple of (A, a) for SRP
        /// </summary>
        /// <returns></returns>
        internal static Tuple<BigInteger, BigInteger> CreateAaTuple()
        {
            BigInteger a, A;
            do
            {
                a = CreateEphemeralRandom();
                A = g.ModPow(a, N);
            } while (A.Mod(N).Equals(BigInteger.Zero));

            return Tuple.Create<BigInteger, BigInteger>(A, a);
        }

        /// <summary>
        /// Generates the claim for authenticating a user through the SRP protocol
        /// </summary>
        /// <param name="username"> Username of CognitoUser</param>
        /// <param name="password"> Password of CognitoUser</param>
        /// <param name="poolName"> PoolName of CognitoUserPool (from poolID: <region>_<poolName>)</param>
        /// <param name="TupleAa"> TupleAa from CreateAaTuple</param>
        /// <param name="saltString"> salt provided in ChallengeParameters from Cognito </param>
        /// <param name="srpbString"> srpb provided in ChallengeParameters from Cognito</param>
        /// <param name="secretBlock">secret block provided in ChallengeParameters from Cognito</param>
        /// <param name="formattedTimestamp">En-US Culture of Current Time</param>
        /// <returns>Returns the claim for authenticating the given user</returns>
        internal static byte[] AuthenticateUser(string username, 
            string password, 
            string poolName,
            Tuple<BigInteger, BigInteger> tupleAa, 
            string saltString, 
            string srpbString,
            string secretBlockBase64, 
            string formattedTimestamp)
        {
            BigInteger B = new BigInteger(srpbString, 16);
            if (B.Mod(AuthenticationHelper.N).Equals(BigInteger.Zero))
            {
                throw new ArgumentException("B mod N cannot be zero.", "srpbString");
            }

            byte[] secretBlockBytes = Convert.FromBase64String(secretBlockBase64);
            
            BigInteger salt = new BigInteger(saltString, 16);

            // Need to generate the key to hash the response based on our A and what AWS sent back
            byte[] key = GetPasswordAuthenticationKey(username, password, poolName, tupleAa, B, salt);

            // HMAC our data with key (HKDF(S)) (the shared secret)
            byte[] hmacBytes;
            byte[] contentBytes = Util.CombineBytes(new byte[][] { Encoding.UTF8.GetBytes(poolName), Encoding.UTF8.GetBytes(username),
                                               secretBlockBytes, Encoding.UTF8.GetBytes(formattedTimestamp) });

            using (HMACSHA256 hashAlgorithm = new HMACSHA256(key))
            {
                hmacBytes = hashAlgorithm.ComputeHash(contentBytes);
            }

            return hmacBytes;
        }

        /// <summary>
        /// Internal method for generating k for the input key material to HKDF
        /// </summary>
        /// <returns>Returns the BigInteger k value for the HKDF protocol's ikm</returns>
        internal static BigInteger CreateKForGeneratingIkm()
        {
            // Create k for generating the ikm S
            byte[] content = Util.CombineBytes(new byte[][] { N.ToByteArray(), g.ToByteArray() });
            byte[] messageDigest = Util.Sha256.ComputeHash(content);
           return new BigInteger(1, messageDigest);
        }

        /// <summary>
        /// Creates the Password Authentication Key based on the SRP protocol
        /// </summary>
        /// <param name="userID"> Username of CognitoUser</param>
        /// <param name="userPassword">Password of CognitoUser</param>
        /// <param name="poolName">PoolName of CognitoUserPool (part of poolID after "_")</param>
        /// <param name="Aa">Returned from TupleAa</param>
        /// <param name="B">BigInteger SRPB from AWS ChallengeParameters</param>
        /// <param name="salt">BigInteger salt from AWS ChallengeParameters</param>
        /// <returns>Returns the password authentication key for the SRP protocol</returns>
        internal static byte[] GetPasswordAuthenticationKey(string userID, 
            string userPassword, 
            string poolName,
            Tuple<BigInteger, BigInteger> Aa, 
            BigInteger B, 
            BigInteger salt)
        {
            // Authenticate the password
            // u = H(A, B)
            byte[] contentBytes = Util.CombineBytes(new byte[][] { Aa.Item1.ToByteArray(), B.ToByteArray() });
            byte[] digest = Util.Sha256.ComputeHash(contentBytes);

            BigInteger u = new BigInteger(1, digest);
            if (u.Equals(BigInteger.Zero))
            {
                throw new ArgumentException("Hash of A and B cannot be zero.");
            }

            // x = H(salt | H(poolName | userId | ":" | password))
            byte[] userIdContent = Util.CombineBytes(new byte[][] { Encoding.UTF8.GetBytes(poolName), Encoding.UTF8.GetBytes(userID),
                                                Encoding.UTF8.GetBytes(":"), Encoding.UTF8.GetBytes(userPassword)});
            byte[] userIdHash = Util.Sha256.ComputeHash(userIdContent);
            byte[] xBytes = Util.CombineBytes(new byte[][] { salt.ToByteArray(), userIdHash });

            byte[] xDigest = Util.Sha256.ComputeHash(xBytes);
            BigInteger x = new BigInteger(1, xDigest);

            // Create k for generating the ikm S
            BigInteger k = CreateKForGeneratingIkm();

            // Use HKDF to get final password authentication key
            BigInteger ikm = (B.Subtract(k.Multiply(g.ModPow(x, N))).ModPow(Aa.Item2.Add(u.Multiply(x)), N)).Mod(N);
            Hkdf hkdf = new Hkdf(u.ToByteArray(), ikm.ToByteArray());
            return hkdf.Expand(Encoding.UTF8.GetBytes(DerivedKeyInfo), DerivedKeySize);
        }

        internal static BigInteger CreateEphemeralRandom()
        {
            return new BigInteger(1, CreateEphemeralRandomBytes());
        }

        internal static byte[] CreateEphemeralRandomBytes()
        {
            var bytes = new byte[EphemeralKeyByteLength];
            using (var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(bytes);
            }

            return bytes;
        }
    }
}