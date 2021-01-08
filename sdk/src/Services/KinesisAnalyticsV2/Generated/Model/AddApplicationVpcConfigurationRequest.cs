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
    /// Container for the parameters to the AddApplicationVpcConfiguration operation.
    /// Adds a Virtual Private Cloud (VPC) configuration to the application. Applications
    /// can use VPCs to store and access resources securely.
    /// 
    ///  
    /// <para>
    /// Note the following about VPC configurations for Kinesis Data Analytics applications:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// VPC configurations are not supported for SQL applications.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When a VPC is added to a Kinesis Data Analytics application, the application can no
    /// longer be accessed from the Internet directly. To enable Internet access to the application,
    /// add an Internet gateway to your VPC.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AddApplicationVpcConfigurationRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private VpcConfiguration _vpcConfiguration;

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
        /// The version of the application to which you want to add the VPC configuration. You
        /// can use the <a>DescribeApplication</a> operation to get the current application version.
        /// If the version specified is not the current version, the <code>ConcurrentModificationException</code>
        /// is returned.
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
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Description of the VPC to add to the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}