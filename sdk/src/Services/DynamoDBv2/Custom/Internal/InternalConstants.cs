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

using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2
{
    internal static class InternalConstants
    {
        /// <summary>
        /// This is DynamicallyAccessedMemberTypes value that must be used whenever identifing the System.Type that users will
        /// use to the DataModel library for loading and saving data.
        /// </summary>
        internal const DynamicallyAccessedMemberTypes DataModelModeledType = DynamicallyAccessedMemberTypes.All;
    }
}
