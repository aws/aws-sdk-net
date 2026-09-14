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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the UpdateServiceNetworkVpcAssociation operation.
    /// </summary>
    public partial class UpdateServiceNetworkVpcAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The account that created the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DnsOptions. 
        /// <para>
        ///  DNS options for the service network VPC association. 
        /// </para>
        /// </summary>
        public DnsOptions DnsOptions { get; set; }

        /// <summary>
        /// Checks to see if the DnsOptions property is set.
        /// </summary>
        internal bool IsSetDnsOptions() => this.DnsOptions != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        ///  Indicates if private DNS is enabled for the VPC association. 
        /// </para>
        /// </summary>
        public bool? PrivateDnsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEnabled property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEnabled() => this.PrivateDnsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status. You can retry the operation if the status is <c>DELETE_FAILED</c>. However,
        /// if you retry it while the status is <c>DELETE_IN_PROGRESS</c>, there is no change
        /// in the status.
        /// </para>
        /// </summary>
        public ServiceNetworkVpcAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
