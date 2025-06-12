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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// The structure of a VPC connection.
    /// </summary>
    public partial class VPCConnection
    {
        private string _arn;
        private VPCConnectionAvailabilityStatus _availabilityStatus;
        private DateTime? _createdTime;
        private List<string> _dnsResolvers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private string _roleArn;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VPCConnectionResourceStatus _status;
        private string _vpcConnectionId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC connection.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityStatus. 
        /// <para>
        /// The availability status of the VPC connection.
        /// </para>
        /// </summary>
        public VPCConnectionAvailabilityStatus AvailabilityStatus
        {
            get { return this._availabilityStatus; }
            set { this._availabilityStatus = value; }
        }

        // Check to see if AvailabilityStatus property is set
        internal bool IsSetAvailabilityStatus()
        {
            return this._availabilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the VPC connection was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsResolvers. 
        /// <para>
        /// A list of IP addresses of DNS resolver endpoints for the VPC connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsResolvers
        {
            get { return this._dnsResolvers; }
            set { this._dnsResolvers = value; }
        }

        // Check to see if DnsResolvers property is set
        internal bool IsSetDnsResolvers()
        {
            return this._dnsResolvers != null && (this._dnsResolvers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that the VPC connection was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the VPC connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// A list of network interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role associated with the VPC connection.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The Amazon EC2 security group IDs associated with the VPC connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPC connection.
        /// </para>
        /// </summary>
        public VPCConnectionResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VPCConnectionId. 
        /// <para>
        /// The ID of the VPC connection that you're creating. This ID is a unique identifier
        /// for each Amazon Web Services Region in an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string VPCConnectionId
        {
            get { return this._vpcConnectionId; }
            set { this._vpcConnectionId = value; }
        }

        // Check to see if VPCConnectionId property is set
        internal bool IsSetVPCConnectionId()
        {
            return this._vpcConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The Amazon EC2 VPC ID associated with the VPC connection.
        /// </para>
        /// </summary>
        public string VPCId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VPCId property is set
        internal bool IsSetVPCId()
        {
            return this._vpcId != null;
        }

    }
}