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
    /// Describes updates to the VPC configuration used by the application.
    /// </summary>
    public partial class VpcConfigurationUpdate
    {
        private List<string> _securityGroupIdUpdates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIdUpdates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcConfigurationId;

        /// <summary>
        /// Gets and sets the property SecurityGroupIdUpdates. 
        /// <para>
        /// Describes updates to the array of <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SecurityGroup.html">SecurityGroup</a>
        /// IDs used by the VPC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> SecurityGroupIdUpdates
        {
            get { return this._securityGroupIdUpdates; }
            set { this._securityGroupIdUpdates = value; }
        }

        // Check to see if SecurityGroupIdUpdates property is set
        internal bool IsSetSecurityGroupIdUpdates()
        {
            return this._securityGroupIdUpdates != null && (this._securityGroupIdUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIdUpdates. 
        /// <para>
        /// Describes updates to the array of <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_Subnet.html">Subnet</a>
        /// IDs used by the VPC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<string> SubnetIdUpdates
        {
            get { return this._subnetIdUpdates; }
            set { this._subnetIdUpdates = value; }
        }

        // Check to see if SubnetIdUpdates property is set
        internal bool IsSetSubnetIdUpdates()
        {
            return this._subnetIdUpdates != null && (this._subnetIdUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfigurationId. 
        /// <para>
        /// Describes an update to the ID of the VPC configuration.
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