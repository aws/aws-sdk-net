/*
 *Copyright Amazon.com, Inc.or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 *You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 *
 *or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    
    public partial class GetBucketIntelligentTieringConfigurationRequest : AmazonWebServiceRequest
	{
        
        private string bucketName;
        private string intelligentTieringId;

        /// <summary>
        /// <para>The name of the Amazon S3 bucket whose configuration you want to modify or retrieve.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// <para>The ID used to identify the S3 Intelligent-Tiering configuration.</para>
        /// </summary>
        public string IntelligentTieringId
		{
            get { return this.intelligentTieringId; }
            set { this.intelligentTieringId = value; }
        }

        // Check to see if IntelligentTieringId property is set
        internal bool IsSetIntelligentTieringId()
        {
            return !(string.IsNullOrEmpty(this.intelligentTieringId));
        }
    }
}
