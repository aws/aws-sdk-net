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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceConnectEndpoint operation.
    /// Modifies the specified EC2 Instance Connect Endpoint.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/modify-ec2-instance-connect-endpoint.html">Modify
    /// an EC2 Instance Connect Endpoint</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyInstanceConnectEndpointRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _instanceConnectEndpointId;
        private IpAddressType _ipAddressType;
        private bool? _preserveClientIp;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceConnectEndpointId. 
        /// <para>
        /// The ID of the EC2 Instance Connect Endpoint to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceConnectEndpointId
        {
            get { return this._instanceConnectEndpointId; }
            set { this._instanceConnectEndpointId = value; }
        }

        // Check to see if InstanceConnectEndpointId property is set
        internal bool IsSetInstanceConnectEndpointId()
        {
            return this._instanceConnectEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The new IP address type for the EC2 Instance Connect Endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>PreserveClientIp</c> is only supported on IPv4 EC2 Instance Connect Endpoints.
        /// To use <c>PreserveClientIp</c>, the value for <c>IpAddressType</c> must be <c>ipv4</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveClientIp. 
        /// <para>
        /// Indicates whether the client IP address is preserved as the source. The following
        /// are the possible values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> - Use the client IP address as the source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> - Use the network interface IP address as the source.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>PreserveClientIp=true</c> is only supported on IPv4 EC2 Instance Connect Endpoints.
        /// If modifying <c>PreserveClientIp</c> to <c>true</c>, either the endpoint's existing
        /// <c>IpAddressType</c> must be <c>ipv4</c>, or if modifying <c>IpAddressType</c> in
        /// the same request, the new value must be <c>ipv4</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? PreserveClientIp
        {
            get { return this._preserveClientIp; }
            set { this._preserveClientIp = value; }
        }

        // Check to see if PreserveClientIp property is set
        internal bool IsSetPreserveClientIp()
        {
            return this._preserveClientIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Changes the security groups for the EC2 Instance Connect Endpoint. The new set of
        /// groups you specify replaces the current set. You must specify at least one group,
        /// even if it's just the default security group in the VPC. You must specify the ID of
        /// the security group, not the name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
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

    }
}