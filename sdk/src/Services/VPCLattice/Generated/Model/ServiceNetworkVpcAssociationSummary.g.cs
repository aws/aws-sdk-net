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
    /// Summary information about an association between a service network and a VPC.
    /// </summary>
    public partial class ServiceNetworkVpcAssociationSummary
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the association was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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
        ///  The DNS options for the service network VPC association. 
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time that the association was last updated, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        ///  Indicates if private DNS is enabled for the service network VPC association. 
        /// </para>
        /// </summary>
        public bool? PrivateDnsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEnabled property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEnabled() => this.PrivateDnsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 2048)]
        public string ServiceNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkArn property is set.
        /// </summary>
        internal bool IsSetServiceNetworkArn() => this.ServiceNetworkArn != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkId. 
        /// <para>
        /// The ID of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string ServiceNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkId property is set.
        /// </summary>
        internal bool IsSetServiceNetworkId() => this.ServiceNetworkId != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkName. 
        /// <para>
        /// The name of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string ServiceNetworkName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkName property is set.
        /// </summary>
        internal bool IsSetServiceNetworkName() => this.ServiceNetworkName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public ServiceNetworkVpcAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 50)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
