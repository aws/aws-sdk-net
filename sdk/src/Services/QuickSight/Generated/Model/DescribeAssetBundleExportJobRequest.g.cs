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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAssetBundleExportJob operation. Describes
    /// an existing export job. <para> Poll job descriptions after a job starts to know the
    /// status of the job. When a job succeeds, a URL is provided to download the exported
    /// assets' data from. Download URLs are valid for five minutes after they are generated.
    /// You can call the <c>DescribeAssetBundleExportJob</c> API for a new download URL as
    /// needed. </para> <para> Job descriptions are available for 14 days after the job starts.
    /// </para>
    /// </summary>
    public partial class DescribeAssetBundleExportJobRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AssetBundleExportJobId. 
        /// <para>
        /// The ID of the job that you want described. The job ID is set when you start a new
        /// job with a <c>StartAssetBundleExportJob</c> API call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AssetBundleExportJobId { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleExportJobId property is set.
        /// </summary>
        internal bool IsSetAssetBundleExportJobId() => this.AssetBundleExportJobId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account the export job is executed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;
    }
}
