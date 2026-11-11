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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the VPC resources, VPC endpoint services, Lattice services, or service networks
    /// associated with the VPC endpoint.
    /// </summary>
    public partial class VpcEndpointAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociatedResourceAccessibility. 
        /// <para>
        /// The connectivity status of the resources associated to a VPC endpoint. The resource
        /// is accessible if the associated resource configuration is <c>AVAILABLE</c>, otherwise
        /// the resource is inaccessible.
        /// </para>
        /// </summary>
        public string AssociatedResourceAccessibility { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceAccessibility property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceAccessibility() => this.AssociatedResourceAccessibility != null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated resource.
        /// </para>
        /// </summary>
        public string AssociatedResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceArn property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceArn() => this.AssociatedResourceArn != null;

        /// <summary>
        /// Gets and sets the property DnsEntry. 
        /// <para>
        /// The DNS entry of the VPC endpoint association.
        /// </para>
        /// </summary>
        public DnsEntry DnsEntry { get; set; }

        /// <summary>
        /// Checks to see if the DnsEntry property is set.
        /// </summary>
        internal bool IsSetDnsEntry() => this.DnsEntry != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// An error code related to why an VPC endpoint association failed.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A message related to why an VPC endpoint association failed.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the VPC endpoint association.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsEntry. 
        /// <para>
        /// The private DNS entry of the VPC endpoint association.
        /// </para>
        /// </summary>
        public DnsEntry PrivateDnsEntry { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEntry property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEntry() => this.PrivateDnsEntry != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration group.
        /// </para>
        /// </summary>
        public string ResourceConfigurationGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationGroupArn property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationGroupArn() => this.ResourceConfigurationGroupArn != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        public string ServiceNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkArn property is set.
        /// </summary>
        internal bool IsSetServiceNetworkArn() => this.ServiceNetworkArn != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkName. 
        /// <para>
        /// The name of the service network.
        /// </para>
        /// </summary>
        public string ServiceNetworkName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkName property is set.
        /// </summary>
        internal bool IsSetServiceNetworkName() => this.ServiceNetworkName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the VPC endpoint association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
