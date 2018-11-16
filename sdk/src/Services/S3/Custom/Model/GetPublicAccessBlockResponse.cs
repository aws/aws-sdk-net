/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the GetPublicAccessBlock operation.
    /// </summary>
    public partial class GetPublicAccessBlockResponse : AmazonWebServiceResponse
    {
        private PublicAccessBlockConfiguration publicAccessBlockConfiguration;

        /// <summary>
        /// The Public Access Block configuration currently in effect for this Amazon S3 bucket.
        /// </summary>
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration
        {
            get { return this.publicAccessBlockConfiguration; }
            set { this.publicAccessBlockConfiguration = value; }
        }

        // Check to see if PublicAccessBlockConfiguration property is set
        internal bool IsSetPublicAccessBlockConfiguration()
        {
            return this.publicAccessBlockConfiguration != null;
        }
    }
}
    
