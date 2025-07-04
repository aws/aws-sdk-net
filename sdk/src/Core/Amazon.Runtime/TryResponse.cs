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

namespace Amazon.Runtime
{
    /// <summary>
    /// Helper class to support a TryGetFoo(out var foo) pattern for async operations.
    /// This is necessary because async methods do not support output parameters.
    /// </summary>
    public class TryResponse<T>
    {
        public bool Success { get; set; }
        public T Value { get; set; }

#pragma warning disable CA1000 // Do not declare static members on generic types
        public static TryResponse<T> Failure => new TryResponse<T>{ Success = false };
#pragma warning restore CA1000 // Do not declare static members on generic types

    }
}