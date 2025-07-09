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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Response from creating a presigned POST request for S3.
    /// Contains the URL and form fields needed for a browser-based file upload directly to S3.
    /// </summary>
    public class CreatePresignedPostResponse
    {
        /// <summary>
        /// Gets the URL where the POST request should be submitted.
        /// </summary>
        public string Url { get; set; }
        
        /// <summary>
        /// Gets the form fields that must be included in the POST request.
        /// These fields contain the policy, signature, and other AWS-required parameters.
        /// </summary>
        public Dictionary<string, string> Fields { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the CreatePresignedPostResponse class.
        /// </summary>
        public CreatePresignedPostResponse()
        {
            Fields = new Dictionary<string, string>();
        }
    }

}
