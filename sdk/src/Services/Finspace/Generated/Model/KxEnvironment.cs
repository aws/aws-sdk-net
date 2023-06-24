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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The details of a kdb environment.
    /// </summary>
    public partial class KxEnvironment
    {
        private List<string> _availabilityZoneIds = new List<string>();
        private string _awsAccountId;
        private string _certificateAuthorityArn;
        private DateTime? _creationTimestamp;
        private List<CustomDNSServer> _customdnsConfiguration = new List<CustomDNSServer>();
        private string _dedicatedServiceAccountId;
        private string _description;
        private DnsStatus _dnsStatus;
        private string _environmentArn;
        private string _environmentId;
        private string _errorMessage;
        private string _kmsKeyId;
        private string _name;
        private EnvironmentStatus _status;
        private TgwStatus _tgwStatus;
        private TransitGatewayConfiguration _transitGatewayConfiguration;
        private DateTime? _updateTimestamp;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// The identifier of the availability zones where subnets for the environment are created.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZoneIds
        {
            get { return this._availabilityZoneIds; }
            set { this._availabilityZoneIds = value; }
        }

        // Check to see if AvailabilityZoneIds property is set
        internal bool IsSetAvailabilityZoneIds()
        {
            return this._availabilityZoneIds != null && this._availabilityZoneIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The unique identifier of the AWS account in which you create the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate authority:
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The timestamp at which the kdb environment was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDNSConfiguration. 
        /// <para>
        /// A list of DNS server name and server IP. This is used to set up Route-53 outbound
        /// resolvers.
        /// </para>
        /// </summary>
        public List<CustomDNSServer> CustomDNSConfiguration
        {
            get { return this._customdnsConfiguration; }
            set { this._customdnsConfiguration = value; }
        }

        // Check to see if CustomDNSConfiguration property is set
        internal bool IsSetCustomDNSConfiguration()
        {
            return this._customdnsConfiguration != null && this._customdnsConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedServiceAccountId. 
        /// <para>
        /// A unique identifier for the AWS environment infrastructure account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DedicatedServiceAccountId
        {
            get { return this._dedicatedServiceAccountId; }
            set { this._dedicatedServiceAccountId = value; }
        }

        // Check to see if DedicatedServiceAccountId property is set
        internal bool IsSetDedicatedServiceAccountId()
        {
            return this._dedicatedServiceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsStatus. 
        /// <para>
        /// The status of DNS configuration.
        /// </para>
        /// </summary>
        public DnsStatus DnsStatus
        {
            get { return this._dnsStatus; }
            set { this._dnsStatus = value; }
        }

        // Check to see if DnsStatus property is set
        internal bool IsSetDnsStatus()
        {
            return this._dnsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EnvironmentArn
        {
            get { return this._environmentArn; }
            set { this._environmentArn = value; }
        }

        // Check to see if EnvironmentArn property is set
        internal bool IsSetEnvironmentArn()
        {
            return this._environmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Specifies the error message that appears if a flow fails. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The unique identifier of the KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the environment creation. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE_REQUESTED – Environment creation has been requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATING – Environment is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED_CREATION – Environment creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATED – Environment is successfully created and is currently active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE REQUESTED – Environment deletion has been requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – Environment is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETRY_DELETION – Initial environment deletion failed, system is reattempting delete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED – Environment has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED_DELETION – Environment deletion has failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EnvironmentStatus Status
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
        /// Gets and sets the property TgwStatus. 
        /// <para>
        /// The status of the network configuration.
        /// </para>
        /// </summary>
        public TgwStatus TgwStatus
        {
            get { return this._tgwStatus; }
            set { this._tgwStatus = value; }
        }

        // Check to see if TgwStatus property is set
        internal bool IsSetTgwStatus()
        {
            return this._tgwStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayConfiguration. 
        /// <para>
        /// Specifies the transit gateway and network configuration to connect the kdb environment
        /// to an internal network.
        /// </para>
        /// </summary>
        public TransitGatewayConfiguration TransitGatewayConfiguration
        {
            get { return this._transitGatewayConfiguration; }
            set { this._transitGatewayConfiguration = value; }
        }

        // Check to see if TransitGatewayConfiguration property is set
        internal bool IsSetTransitGatewayConfiguration()
        {
            return this._transitGatewayConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTimestamp. 
        /// <para>
        /// The timestamp at which the kdb environment was modified in FinSpace. The value is
        /// determined as epoch time in milliseconds. For example, the value for Monday, November
        /// 1, 2021 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime UpdateTimestamp
        {
            get { return this._updateTimestamp.GetValueOrDefault(); }
            set { this._updateTimestamp = value; }
        }

        // Check to see if UpdateTimestamp property is set
        internal bool IsSetUpdateTimestamp()
        {
            return this._updateTimestamp.HasValue; 
        }

    }
}