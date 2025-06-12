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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Contains the output of the <a>DescribeHsm</a> operation.
    /// </summary>
    public partial class DescribeHsmResponse : AmazonWebServiceResponse
    {
        private string _availabilityZone;
        private string _eniId;
        private string _eniIp;
        private string _hsmArn;
        private string _hsmType;
        private string _iamRoleArn;
        private List<string> _partitions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serialNumber;
        private string _serverCertLastUpdated;
        private string _serverCertUri;
        private string _softwareVersion;
        private string _sshKeyLastUpdated;
        private string _sshPublicKey;
        private HsmStatus _status;
        private string _statusDetails;
        private string _subnetId;
        private string _subscriptionEndDate;
        private string _subscriptionStartDate;
        private SubscriptionType _subscriptionType;
        private string _vendorName;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone that the HSM is in.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The identifier of the elastic network interface (ENI) attached to the HSM.
        /// </para>
        /// </summary>
        public string EniId
        {
            get { return this._eniId; }
            set { this._eniId = value; }
        }

        // Check to see if EniId property is set
        internal bool IsSetEniId()
        {
            return this._eniId != null;
        }

        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The IP address assigned to the HSM's ENI.
        /// </para>
        /// </summary>
        public string EniIp
        {
            get { return this._eniIp; }
            set { this._eniIp = value; }
        }

        // Check to see if EniIp property is set
        internal bool IsSetEniIp()
        {
            return this._eniIp != null;
        }

        /// <summary>
        /// Gets and sets the property HsmArn. 
        /// <para>
        /// The ARN of the HSM.
        /// </para>
        /// </summary>
        public string HsmArn
        {
            get { return this._hsmArn; }
            set { this._hsmArn = value; }
        }

        // Check to see if HsmArn property is set
        internal bool IsSetHsmArn()
        {
            return this._hsmArn != null;
        }

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The HSM model type.
        /// </para>
        /// </summary>
        public string HsmType
        {
            get { return this._hsmType; }
            set { this._hsmType = value; }
        }

        // Check to see if HsmType property is set
        internal bool IsSetHsmType()
        {
            return this._hsmType != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role assigned to the HSM.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Partitions. 
        /// <para>
        /// The list of partitions on the HSM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Partitions
        {
            get { return this._partitions; }
            set { this._partitions = value; }
        }

        // Check to see if Partitions property is set
        internal bool IsSetPartitions()
        {
            return this._partitions != null && (this._partitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the HSM.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertLastUpdated. 
        /// <para>
        /// The date and time that the server certificate was last updated.
        /// </para>
        /// </summary>
        public string ServerCertLastUpdated
        {
            get { return this._serverCertLastUpdated; }
            set { this._serverCertLastUpdated = value; }
        }

        // Check to see if ServerCertLastUpdated property is set
        internal bool IsSetServerCertLastUpdated()
        {
            return this._serverCertLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertUri. 
        /// <para>
        /// The URI of the certificate server.
        /// </para>
        /// </summary>
        public string ServerCertUri
        {
            get { return this._serverCertUri; }
            set { this._serverCertUri = value; }
        }

        // Check to see if ServerCertUri property is set
        internal bool IsSetServerCertUri()
        {
            return this._serverCertUri != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The HSM software version.
        /// </para>
        /// </summary>
        public string SoftwareVersion
        {
            get { return this._softwareVersion; }
            set { this._softwareVersion = value; }
        }

        // Check to see if SoftwareVersion property is set
        internal bool IsSetSoftwareVersion()
        {
            return this._softwareVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SshKeyLastUpdated. 
        /// <para>
        /// The date and time that the SSH key was last updated.
        /// </para>
        /// </summary>
        public string SshKeyLastUpdated
        {
            get { return this._sshKeyLastUpdated; }
            set { this._sshKeyLastUpdated = value; }
        }

        // Check to see if SshKeyLastUpdated property is set
        internal bool IsSetSshKeyLastUpdated()
        {
            return this._sshKeyLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKey. 
        /// <para>
        /// The public SSH key.
        /// </para>
        /// </summary>
        public string SshPublicKey
        {
            get { return this._sshPublicKey; }
            set { this._sshPublicKey = value; }
        }

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this._sshPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the HSM.
        /// </para>
        /// </summary>
        public HsmStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Contains additional information about the status of the HSM.
        /// </para>
        /// </summary>
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet that the HSM is in.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionEndDate. 
        /// <para>
        /// The subscription end date.
        /// </para>
        /// </summary>
        public string SubscriptionEndDate
        {
            get { return this._subscriptionEndDate; }
            set { this._subscriptionEndDate = value; }
        }

        // Check to see if SubscriptionEndDate property is set
        internal bool IsSetSubscriptionEndDate()
        {
            return this._subscriptionEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionStartDate. 
        /// <para>
        /// The subscription start date.
        /// </para>
        /// </summary>
        public string SubscriptionStartDate
        {
            get { return this._subscriptionStartDate; }
            set { this._subscriptionStartDate = value; }
        }

        // Check to see if SubscriptionStartDate property is set
        internal bool IsSetSubscriptionStartDate()
        {
            return this._subscriptionStartDate != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionType.
        /// </summary>
        public SubscriptionType SubscriptionType
        {
            get { return this._subscriptionType; }
            set { this._subscriptionType = value; }
        }

        // Check to see if SubscriptionType property is set
        internal bool IsSetSubscriptionType()
        {
            return this._subscriptionType != null;
        }

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the HSM vendor.
        /// </para>
        /// </summary>
        public string VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the HSM is in.
        /// </para>
        /// </summary>
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