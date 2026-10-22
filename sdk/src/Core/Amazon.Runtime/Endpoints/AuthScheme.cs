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
using System.Collections.Generic;

namespace Amazon.Runtime.Endpoints
{
    /// <summary>
    /// Typed representation of a resolved endpoint auth scheme.
    /// </summary>
    public class AuthScheme
    {
        public AuthScheme(
            string name,
            string signingName,
            string signingRegion,
            IList<string> signingRegionSet,
            bool disableDoubleEncoding)
        {
            Name = name;
            SigningName = signingName;
            SigningRegion = signingRegion;
            SigningRegionSet = signingRegionSet;
            DisableDoubleEncoding = disableDoubleEncoding;
        }

        public string Name { get; }
        public string SigningName { get; }
        public string SigningRegion { get; }
        public IList<string> SigningRegionSet { get; }
        public bool DisableDoubleEncoding { get; }
    }
}
