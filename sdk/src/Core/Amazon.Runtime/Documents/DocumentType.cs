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

namespace Amazon.Runtime.Documents
{
    /// <summary>
    /// Valid types for <see cref="Document" /> 
    /// </summary>
    public enum DocumentType
    {
        Null = 0,
        Bool = 1,
        Dictionary = 10,
        Double = 100,
        Int = 1000,
        Long = 10000,
        List = 100000,
        String = 1000000
    }
}