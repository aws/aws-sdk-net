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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the CreateVpcLink operation.
    /// </summary>
    public partial class CreateVpcLinkResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdDate;
        private string _name;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnetIds = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
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
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
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
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs to include in the VPC link.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the VPC link.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcLinkId. 
        /// <para>
        /// The ID of the VPC link.
        /// </para>
        /// </summary>
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