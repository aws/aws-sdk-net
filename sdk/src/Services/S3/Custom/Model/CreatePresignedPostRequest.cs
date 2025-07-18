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
using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to create a presigned POST request for S3.
    /// </summary>
    public class CreatePresignedPostRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Gets or sets the name of the S3 bucket for the presigned POST.
        /// </summary>
        public string BucketName { get; set; }
        
        /// <summary>
        /// Gets or sets the key (name) of the object for the presigned POST.
        /// </summary>
        public string Key { get; set; }
        
        /// <summary>
        /// Gets or sets the expiration time for the presigned POST.
        /// Defaults to one hour from the time the request is created.
        /// </summary>
        public DateTime? Expires { get; set; }
        
        /// <summary>
        /// Gets or sets additional form fields to include in the presigned POST.
        /// </summary>
        public Dictionary<string, string> Fields { get; set; }
        
        /// <summary>
        /// Gets or sets the policy conditions for the presigned POST.
        /// </summary>
        public List<S3PostCondition> Conditions { get; set; }

        /// <summary>
        /// Initializes a new instance of the CreatePresignedPostRequest class.
        /// </summary>
        public CreatePresignedPostRequest() 
        {
            Expires = AWSSDKUtils.CorrectedUtcNow.AddHours(1);
            Fields = new Dictionary<string, string>();
            Conditions = new List<S3PostCondition>();
        }
    }
}
