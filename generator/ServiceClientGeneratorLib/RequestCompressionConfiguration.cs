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

using Json.LitJson;
using System;
using System.Collections.Generic;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Contains the supported encodings for the request compression configuration for a given operation, 
    /// read from the <see cref="ServiceModel.RequestCompressionKey"/> trait applied at the operation-level in a service model.
    /// </summary>
    public class RequestCompressionConfiguration
    {
        /// <summary>
        /// Extracted and supported request compression encodings in the same order as in the trait.
        /// The first encoding on the list is used for compressing the request
        /// </summary>
        public List<CompressionEncoding> Encodings { get; }

        /// <summary>
        /// Supported request compression encodings by the SDK
        /// </summary>
        public enum CompressionEncoding
        {
            gzip
        }


        /// <summary>
        /// Instantiates <see cref="RequestCompressionConfiguration"/> object containing
        /// a list of request compression encoding algorithms which are supported by 
        /// both the operation of the service and the .NET SDK.
        /// </summary>
        /// <param name="data"> The Json model which contains a list of compression encodings </param>
        /// <param name="payload"> Payload member of the request </param>
        /// <exception cref="ArgumentOutOfRangeException"> Thrown if we couldn't find a compression encoding which is supported by the .NET SDK </exception>
        /// <exception cref="InvalidOperationException"> Thrown when the request payload is streaming and has a required fixed length </exception>
        public RequestCompressionConfiguration(JsonData data, Member payload)
        {
            if (data[ServiceModel.EncodingsKey] != null)
            {
                if (data[ServiceModel.EncodingsKey].IsArray)
                {
                    Encodings = new List<CompressionEncoding>();
                    var unsupportedEncodings = new List<string>();

                    foreach (JsonData rawAlgorithm in data[ServiceModel.EncodingsKey])
                    {
                        if (Enum.TryParse<CompressionEncoding>((string)rawAlgorithm, true, out var parsedAlgorithm))
                        {
                            Encodings.Add(parsedAlgorithm);
                        }
                        else
                        {
                            unsupportedEncodings.Add(rawAlgorithm.ToString());
                        }
                    }

                    if (Encodings.Count == 0)
                    {
                        Console.Error.WriteLine($"**** Warning: Did not find supported encoding values for {nameof(CompressionEncoding)}: {string.Join(",", unsupportedEncodings)}");
                    }
                    else
                    {
                        if(payload != null && payload.Shape.IsStreaming && payload.RequiresLength) 
                        {
                            throw new InvalidOperationException(
                                "Cannot compress the request payload if the payload is a stream and the length of the request should be fixed"
                            );
                        }
                    }
                }
                else
                {
                    throw new ArgumentException($"{data[ServiceModel.EncodingsKey]} is not a valid array value for {ServiceModel.RequestCompressionKey}");
                }
            }
            else
            {
                throw new ArgumentException($"{ServiceModel.RequestCompressionKey} trait does not contain mandatory field {ServiceModel.EncodingsKey}");
            }
        }

    }
}
