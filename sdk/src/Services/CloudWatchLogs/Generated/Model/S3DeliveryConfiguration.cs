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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains delivery configurations that apply only when the delivery
    /// destination resource is an S3 bucket.
    /// </summary>
    public partial class S3DeliveryConfiguration
    {
        private bool? _enableHiveCompatiblePath;
        private string _suffixPath;

        /// <summary>
        /// Gets and sets the property EnableHiveCompatiblePath. 
        /// <para>
        /// This parameter causes the S3 objects that contain delivered logs to use a prefix structure
        /// that allows for integration with Apache Hive.
        /// </para>
        /// </summary>
        public bool? EnableHiveCompatiblePath
        {
            get { return this._enableHiveCompatiblePath; }
            set { this._enableHiveCompatiblePath = value; }
        }

        // Check to see if EnableHiveCompatiblePath property is set
        internal bool IsSetEnableHiveCompatiblePath()
        {
            return this._enableHiveCompatiblePath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuffixPath. 
        /// <para>
        /// This string allows re-configuring the S3 object prefix to contain either static or
        /// variable sections. The valid variables to use in the suffix path will vary by each
        /// log source. To find the values supported for the suffix path for each log source,
        /// use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeConfigurationTemplates.html">DescribeConfigurationTemplates</a>
        /// operation and check the <c>allowedSuffixPathFields</c> field in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SuffixPath
        {
            get { return this._suffixPath; }
            set { this._suffixPath = value; }
        }

        // Check to see if SuffixPath property is set
        internal bool IsSetSuffixPath()
        {
            return this._suffixPath != null;
        }

    }
}