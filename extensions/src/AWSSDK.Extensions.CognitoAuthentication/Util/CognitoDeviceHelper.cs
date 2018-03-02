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
using System.Collections.Generic;
using System.Security.Cryptography;
using Amazon.Extensions.CognitoAuthentication.ThirdParty;

namespace Amazon.Extensions.CognitoAuthentication
{
    /// <summary>
    /// Class that helps with device SRP authentication
    /// </summary>
    internal static class CognitoDeviceHelper
    {
        internal static byte[] Salt { get; set; }
        internal static BigInteger Verifier { get; set; }
     
        /// <summary>
        /// Generates the salt, verifier, and secret verification parameters for device SRP
        /// </summary>
        /// <param name="deviceKey">The device key for the associated CognitoDevice</param>
        /// <param name="deviceGroup">The device group key for the associated CognitoDevice</param>
        /// <returns>Returns a dictionary with key-value pairings for the salt, verifier, and secret for 
        /// the associated CognitoDevice</returns>
        internal static IDictionary<string, string> GenerateVerificationParameters(string deviceKey, string deviceGroup)
        {
            string deviceSecret = GenerateRandomString();
            GenerateDeviceSaltAndVerifier(deviceGroup, deviceKey, deviceSecret);

            byte[] srpVerifier = Verifier.ToByteArray();

            Dictionary<string, string> verificationParams = new Dictionary<string, string>()
            {
                { "salt", Convert.ToBase64String(Salt) },
                { "verifier", Convert.ToBase64String(srpVerifier) },
                { "secret", deviceSecret }
            };

            return verificationParams;
        }

        /// <summary>
        /// Generates the device salt and verifier values and stores them in the appropriate 
        /// CognitoDeviceHelper properties
        /// </summary>
        /// <param name="deviceGroupKey">The device group key for the associated CognitoDevice</param>
        /// <param name="deviceKey">The device key for the CognitoDevice</param>
        /// <param name="password">The password for the CognitoUser associated with the device</param>
        internal static void GenerateDeviceSaltAndVerifier(string deviceGroupKey, string deviceKey, string password)
        {
            byte[] deviceKeyHash = GetDeviceKeyHash(deviceGroupKey, deviceKey, password);

            Salt = new byte[16];
            using(var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(Salt);
            }

            Verifier = CalculateVerifier(Salt, deviceKeyHash);
        }

        /// <summary>
        /// Calculates the device verifier for the device given the salt and device key hash 
        /// </summary>
        /// <param name="salt">The salt for the SHA256 hash to compute the device verifier</param>
        /// <param name="deviceKeyHash">The device key hash for the associated CognitoDevice</param>
        /// <returns>Returns the device verifier for the associated CognitoDevice</returns>
        internal static BigInteger CalculateVerifier(byte[] salt, byte[] deviceKeyHash)
        {
            byte[] contentBytes = Util.CombineBytes(new byte[][] { salt, deviceKeyHash });
            byte[] digest = Util.Sha256.ComputeHash(contentBytes);

            BigInteger x = new BigInteger(1, digest);
            return (AuthenticationHelper.g).ModPow(x, (AuthenticationHelper.N));
        }

        /// <summary>
        /// Computes the device key hash given the device group key, device key, and user password
        /// </summary>
        /// <param name="deviceGroupKey">The device group key for the CognitoDevice</param>
        /// <param name="deviceKey">The device key for the CognitoDevice</param>
        /// <param name="password">The password for the CognitoUser associated with the device</param>
        /// <returns>Returns the device key hash for the given device</returns>
        internal static byte[] GetDeviceKeyHash(string deviceGroupKey, string deviceKey, string password)
        {
            byte[] contentBytes = Util.CombineBytes(new byte[][] { Encoding.UTF8.GetBytes(deviceGroupKey),
                Encoding.UTF8.GetBytes(deviceKey), Encoding.UTF8.GetBytes(":"), Encoding.UTF8.GetBytes(password) });

            return Util.Sha256.ComputeHash(contentBytes);
        }

        /// <summary>
        /// Generates a random string using a globally unique identifier
        /// </summary>
        /// <returns>Returns a random string</returns>
        internal static string GenerateRandomString()
        {
            return Guid.NewGuid().ToString();
        }
    }
}