/*
 * Author: David Iffland, Heavy Code LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 * http://aws.amazon.com/apache2.0
 */

using System;

namespace AWSSDK.Amazon.TVMClient
{
    public class AwsTemporaryCredentialFactory
    {
        private const string AccessKeyName = "accessKey";
        private const string SecretKeyName = "secretKey";
        private const string SecurityTokenKeyName = "securityToken";
        private const string ExpirationDateKeyName = "expirationDate";



        /// <summary>
        /// Used to create a set of temporary security credentials from the response provided by the
        /// Token Vending Machine.
        /// </summary>
        /// <param name="credentialString">The response from the Token Vending Machine</param>
        /// <returns>A set of temporary AWS credentials</returns>
        public static AwsTemporaryCredentials Create(string credentialString)
        {
            AwsTemporaryCredentials credentials = new AwsTemporaryCredentials
                                                      {
                                                          AccessKey = ExtractElement(credentialString, AccessKeyName),
                                                          SecretKey = ExtractElement(credentialString, SecretKeyName),
                                                          SecurityToken =
                                                              ExtractElement(credentialString, SecurityTokenKeyName),
                                                          ExpirationDate =
                                                              AwsTemporaryCredentials.GetExpirationTimeFromMilliseconds(
                                                                  ExtractElement(credentialString,
                                                                                 ExpirationDateKeyName))
                                                      };

            return credentials;

        }

        /// <summary>
        /// Used to extract a piece of data from a json string.
        /// </summary>
        /// <remarks>This is a C# port of the Java version written by Amazon.com</remarks>
        /// <param name="json">The raw string to exctract the element from.</param>
        /// <param name="element">the name of the piece of data to extract.</param>
        /// <returns>The value of the exctracted element.</returns>
        private static String ExtractElement(String json, String element)
        {
            bool hasElement = (json.IndexOf(element) != -1);
            if (hasElement)
            {
                int elementIndex = json.IndexOf(element);
                int startIndex = json.IndexOf("\"", elementIndex);
                int endIndex = json.IndexOf("\"", startIndex + 1);

                return json.Substring(startIndex + 1, endIndex - (startIndex + 1));
            }

            return null;
        }
    }
}
