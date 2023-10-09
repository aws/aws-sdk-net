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
namespace Amazon.Runtime.Internal.Endpoints.StandardLibrary
{
    /// <summary>
    /// Object model for json partition data.
    /// </summary>
    public class PartitionAttributesShape
    {
        public string name { get; set; }
        public string dnsSuffix { get; set; }
        public string dualStackDnsSuffix { get; set; }
        public bool supportsFIPS { get; set; }
        public bool supportsDualStack { get; set; }
        public string implicitGlobalRegion { get; set; }
    }
}