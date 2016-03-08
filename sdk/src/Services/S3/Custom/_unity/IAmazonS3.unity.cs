/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;

namespace Amazon.S3
{
    public partial interface IAmazonS3
    {
        #region PostObjects
        /// <summary>
        /// Upload data to Amazon S3 using HTTP POST.
        /// </summary>
        /// <remarks>
        /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
        /// </remarks>
        /// <param name="request">Request object which describes the data to POST</param>
        /// <param name="callback">The callback which needs to be invoked once the PostObjectRequest is completed</param>
        /// <param name="options">An optional configuration parameter</param>
        void PostObjectAsync(PostObjectRequest request,AmazonServiceCallback<PostObjectRequest,PostObjectResponse> callback,  AsyncOptions options = null);
        
        #endregion
    }
}
                                                                                                                                                                                  