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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// This is the response object from the UpdateKxEnvironment operation.
    /// </summary>
    public partial class UpdateKxEnvironmentResponse : AmazonWebServiceResponse
    {
        private List<string> _availabilityZoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsAccountId;
        private DateTime? _creationTimestamp;
        private List<CustomDNSServer> _customdnsConfiguration = AWSConfigs.InitializeCollections ? new List<CustomDNSServer>() : null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZoneIds
        {
            get { return this._availabilityZoneIds; }
            set { this._availabilityZoneIds = value; }
        }

        // Check to see if AvailabilityZoneIds property is set
        internal bool IsSetAvailabilityZoneIds()
        {
            return this._availabilityZoneIds != null && (this._availabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The unique identifier of the AWS account that is used to create the kdb environment.
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
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The timestamp at which the kdb environment was created in FinSpace. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomDNSServer> CustomDNSConfiguration
        {
            get { return this._customdnsConfiguration; }
            set { this._customdnsConfiguration = value; }
        }

        // Check to see if CustomDNSConfiguration property is set
        internal bool IsSetCustomDNSConfiguration()
        {
            return this._customdnsConfiguration != null && (this._customdnsConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The description of the environment.
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
        /// The ARN identifier of the environment.
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
        /// The KMS key ID to encrypt your data in the FinSpace environment.
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
        /// The status of the kdb environment.
        /// </para>
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
        /// The timestamp at which the kdb environment was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdateTimestamp
        {
            get { return this._updateTimestamp; }
            set { this._updateTimestamp = value; }
        }

        // Check to see if UpdateTimestamp property is set
        internal bool IsSetUpdateTimestamp()
        {
            return this._updateTimestamp.HasValue; 
        }

    }
}