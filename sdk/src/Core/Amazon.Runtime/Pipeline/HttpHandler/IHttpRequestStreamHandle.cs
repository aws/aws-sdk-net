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

using System;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Provides a handle to the Http request stream. It is used when the request stream should not be disposed once the 
    /// initial request is complete. The typical scenario is bi-directional event stream. The handle
    /// is provided to the response object so that request stream will be disposed when the response is disposed.
    /// </summary>
    public interface IHttpRequestStreamHandle : IDisposable
    {

    }
}
