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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationVpcConfiguration operation.
    /// Adds a Virtual Private Cloud (VPC) configuration to the application. Applications
    /// can use VPCs to store and access resources securely.
    /// 
    ///  
    /// <para>
    /// Note the following about VPC configurations for Managed Service for Apache Flink applications:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// VPC configurations are not supported for SQL applications.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When a VPC is added to a Managed Service for Apache Flink application, the application
    /// can no longer be accessed from the Internet directly. To enable Internet access to
    /// the application, add an Internet gateway to your VPC.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AddApplicationVpcConfigurationRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private string _conditionalToken;
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
        /// Gets and sets the property ConditionalToken. 
        /// <para>
        /// A value you use to implement strong concurrency for application updates. You must
        /// provide the <c>ApplicationVersionID</c> or the <c>ConditionalToken</c>. You get the
        /// application's current <c>ConditionalToken</c> using <a>DescribeApplication</a>. For
        /// better concurrency support, use the <c>ConditionalToken</c> parameter instead of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ConditionalToken
        {
            get { return this._conditionalToken; }
            set { this._conditionalToken = value; }
        }

        // Check to see if ConditionalToken property is set
        internal bool IsSetConditionalToken()
        {
            return this._conditionalToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version of the application to which you want to add the VPC configuration. You
        /// must provide the <c>CurrentApplicationVersionId</c> or the <c>ConditionalToken</c>.
        /// You can use the <a>DescribeApplication</a> operation to get the current application
        /// version. If the version specified is not the current version, the <c>ConcurrentModificationException</c>
        /// is returned. For better concurrency support, use the <c>ConditionalToken</c> parameter
        /// instead of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long? CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId; }
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