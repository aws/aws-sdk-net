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
using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the RenameObject operation.
    /// </summary>
    public partial class RenameObjectResponse : AmazonWebServiceResponse
    {
        // The RenameObject operation returns an empty response with success status code 
        // when the operation succeeds. No additional response fields are needed.
    }
}