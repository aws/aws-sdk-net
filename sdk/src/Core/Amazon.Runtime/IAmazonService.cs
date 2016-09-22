/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// All Amazon service interfaces like IAmazonS3 extend from this interface. This allows all the 
    /// Amazon service interfaces be identified by this base interface and helps with generic constraints.
    /// </summary>
    public interface IAmazonService
    {
        /// <summary>
        /// A readonly view of the configuration for the service client.
        /// </summary>
        IClientConfig Config
        {
            get;
        }
    }
}