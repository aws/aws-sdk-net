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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplicationVpcConfiguration operation.
    /// Removes a VPC configuration from a Kinesis Data Analytics application.
    /// </summary>
    public partial class DeleteApplicationVpcConfigurationRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private string _vpcConfigurationId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an existing application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The current application version ID. You can retrieve the application version ID using
        /// <a>DescribeApplication</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId.GetValueOrDefault(); }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfigurationId. 
        /// <para>
        /// The ID of the VPC configuration to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string VpcConfigurationId
        {
            get { return this._vpcConfigurationId; }
            set { this._vpcConfigurationId = value; }
        }

        // Check to see if VpcConfigurationId property is set
        internal bool IsSetVpcConfigurationId()
        {
            return this._vpcConfigurationId != null;
        }

    }
}