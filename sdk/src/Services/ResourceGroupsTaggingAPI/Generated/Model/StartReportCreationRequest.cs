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

/*
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the StartReportCreation operation.
    /// Generates a report that lists all tagged resources in accounts across your organization,
    /// and whether each resource is compliant with the effective tag policy. 
    /// 
    ///  
    /// <para>
    /// You can call this operation from the organization's master account only and from the
    /// us-east-1 Region only. 
    /// </para>
    /// </summary>
    public partial class StartReportCreationRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private string _s3Bucket;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where the report will be stored.
        /// </para>
        ///  
        /// <para>
        /// For more information on S3 bucket requirements, including an example bucket policy,
        /// see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

    }
}