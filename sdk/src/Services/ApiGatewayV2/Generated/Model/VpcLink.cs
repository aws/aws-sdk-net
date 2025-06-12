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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents a VPC link.
    /// </summary>
    public partial class VpcLink
    {
        private DateTime? _createdDate;
        private string _name;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _vpcLinkId;
        private VpcLinkStatus _vpcLinkStatus;
        private string _vpcLinkStatusMessage;
        private VpcLinkVersion _vpcLinkVersion;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the VPC link was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the VPC link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group IDs for the VPC link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs to include in the VPC link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the VPC link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcLinkId. 
        /// <para>
        /// The ID of the VPC link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcLinkId
        {
            get { return this._vpcLinkId; }
            set { this._vpcLinkId = value; }
        }

        // Check to see if VpcLinkId property is set
        internal bool IsSetVpcLinkId()
        {
            return this._vpcLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcLinkStatus. 
        /// <para>
        /// The status of the VPC link.
        /// </para>
        /// </summary>
        public VpcLinkStatus VpcLinkStatus
        {
            get { return this._vpcLinkStatus; }
            set { this._vpcLinkStatus = value; }
        }

        // Check to see if VpcLinkStatus property is set
        internal bool IsSetVpcLinkStatus()
        {
            return this._vpcLinkStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VpcLinkStatusMessage. 
        /// <para>
        /// A message summarizing the cause of the status of the VPC link.
        /// </para>
        /// </summary>
        public string VpcLinkStatusMessage
        {
            get { return this._vpcLinkStatusMessage; }
            set { this._vpcLinkStatusMessage = value; }
        }

        // Check to see if VpcLinkStatusMessage property is set
        internal bool IsSetVpcLinkStatusMessage()
        {
            return this._vpcLinkStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property VpcLinkVersion. 
        /// <para>
        /// The version of the VPC link.
        /// </para>
        /// </summary>
        public VpcLinkVersion VpcLinkVersion
        {
            get { return this._vpcLinkVersion; }
            set { this._vpcLinkVersion = value; }
        }

        // Check to see if VpcLinkVersion property is set
        internal bool IsSetVpcLinkVersion()
        {
            return this._vpcLinkVersion != null;
        }

    }
}