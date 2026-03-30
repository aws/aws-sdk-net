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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Output containing the updated Private Connection summary.
    /// </summary>
    public partial class UpdatePrivateConnectionCertificateResponse : AmazonWebServiceResponse
    {
        private DateTime? _certificateExpiryTime;
        private string _hostAddress;
        private string _name;
        private string _resourceConfigurationId;
        private string _resourceGatewayId;
        private PrivateConnectionStatus _status;
        private PrivateConnectionType _type;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CertificateExpiryTime. 
        /// <para>
        /// The expiry time of the certificate associated with the Private Connection. Only present
        /// when a certificate is associated.
        /// </para>
        /// </summary>
        public DateTime? CertificateExpiryTime
        {
            get { return this._certificateExpiryTime; }
            set { this._certificateExpiryTime = value; }
        }

        // Check to see if CertificateExpiryTime property is set
        internal bool IsSetCertificateExpiryTime()
        {
            return this._certificateExpiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostAddress. 
        /// <para>
        /// IP address or DNS name of the target resource. Only present for service-managed Private
        /// Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string HostAddress
        {
            get { return this._hostAddress; }
            set { this._hostAddress = value; }
        }

        // Check to see if HostAddress property is set
        internal bool IsSetHostAddress()
        {
            return this._hostAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=30)]
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
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The Resource Configuration ARN. Only present for self-managed Private Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceConfigurationId
        {
            get { return this._resourceConfigurationId; }
            set { this._resourceConfigurationId = value; }
        }

        // Check to see if ResourceConfigurationId property is set
        internal bool IsSetResourceConfigurationId()
        {
            return this._resourceConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayId. 
        /// <para>
        /// The service-managed Resource Gateway ARN. Only present for service-managed Private
        /// Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceGatewayId
        {
            get { return this._resourceGatewayId; }
            set { this._resourceGatewayId = value; }
        }

        // Check to see if ResourceGatewayId property is set
        internal bool IsSetResourceGatewayId()
        {
            return this._resourceGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivateConnectionStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivateConnectionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// VPC identifier of the service-managed Resource Gateway. Only present for service-managed
        /// Private Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}