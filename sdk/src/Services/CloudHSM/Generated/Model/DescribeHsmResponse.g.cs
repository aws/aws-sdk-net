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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the DescribeHsm operation.
    /// </summary>
    public partial class DescribeHsmResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone that the HSM is in.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The identifier of the elastic network interface (ENI) attached to the HSM.
        /// </para>
        /// </summary>
        public string EniId { get; set; }

        /// <summary>
        /// Checks to see if the EniId property is set.
        /// </summary>
        internal bool IsSetEniId() => this.EniId != null;

        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The IP address assigned to the HSM's ENI.
        /// </para>
        /// </summary>
        public string EniIp { get; set; }

        /// <summary>
        /// Checks to see if the EniIp property is set.
        /// </summary>
        internal bool IsSetEniIp() => this.EniIp != null;

        /// <summary>
        /// Gets and sets the property HsmArn. 
        /// <para>
        /// The ARN of the HSM.
        /// </para>
        /// </summary>
        public string HsmArn { get; set; }

        /// <summary>
        /// Checks to see if the HsmArn property is set.
        /// </summary>
        internal bool IsSetHsmArn() => this.HsmArn != null;

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The HSM model type.
        /// </para>
        /// </summary>
        public string HsmType { get; set; }

        /// <summary>
        /// Checks to see if the HsmType property is set.
        /// </summary>
        internal bool IsSetHsmType() => this.HsmType != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role assigned to the HSM.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property Partitions. 
        /// <para>
        /// The list of partitions on the HSM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Partitions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Partitions property is set.
        /// </summary>
        internal bool IsSetPartitions() => this.Partitions != null && (this.Partitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the HSM.
        /// </para>
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property ServerCertLastUpdated. 
        /// <para>
        /// The date and time that the server certificate was last updated.
        /// </para>
        /// </summary>
        public string ServerCertLastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertLastUpdated property is set.
        /// </summary>
        internal bool IsSetServerCertLastUpdated() => this.ServerCertLastUpdated != null;

        /// <summary>
        /// Gets and sets the property ServerCertUri. 
        /// <para>
        /// The URI of the certificate server.
        /// </para>
        /// </summary>
        public string ServerCertUri { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertUri property is set.
        /// </summary>
        internal bool IsSetServerCertUri() => this.ServerCertUri != null;

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The HSM software version.
        /// </para>
        /// </summary>
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareVersion property is set.
        /// </summary>
        internal bool IsSetSoftwareVersion() => this.SoftwareVersion != null;

        /// <summary>
        /// Gets and sets the property SshKeyLastUpdated. 
        /// <para>
        /// The date and time that the SSH key was last updated.
        /// </para>
        /// </summary>
        public string SshKeyLastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the SshKeyLastUpdated property is set.
        /// </summary>
        internal bool IsSetSshKeyLastUpdated() => this.SshKeyLastUpdated != null;

        /// <summary>
        /// Gets and sets the property SshPublicKey. 
        /// <para>
        /// The public SSH key.
        /// </para>
        /// </summary>
        public string SshPublicKey { get; set; }

        /// <summary>
        /// Checks to see if the SshPublicKey property is set.
        /// </summary>
        internal bool IsSetSshPublicKey() => this.SshPublicKey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the HSM.
        /// </para>
        /// </summary>
        public HsmStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Contains additional information about the status of the HSM.
        /// </para>
        /// </summary>
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet that the HSM is in.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionEndDate. 
        /// <para>
        /// The subscription end date.
        /// </para>
        /// </summary>
        public string SubscriptionEndDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionEndDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionEndDate() => this.SubscriptionEndDate != null;

        /// <summary>
        /// Gets and sets the property SubscriptionStartDate. 
        /// <para>
        /// The subscription start date.
        /// </para>
        /// </summary>
        public string SubscriptionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionStartDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionStartDate() => this.SubscriptionStartDate != null;

        /// <summary>
        /// Gets and sets the property SubscriptionType.
        /// </summary>
        public SubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionType property is set.
        /// </summary>
        internal bool IsSetSubscriptionType() => this.SubscriptionType != null;

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the HSM vendor.
        /// </para>
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// Checks to see if the VendorName property is set.
        /// </summary>
        internal bool IsSetVendorName() => this.VendorName != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the HSM is in.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
