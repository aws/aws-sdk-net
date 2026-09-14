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
    /// Summary information about an association between a service network and a resource
    /// configuration.
    /// </summary>
    public partial class ServiceNetworkResourceAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 2048)]
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
        /// Gets and sets the property DnsEntry. 
        /// <para>
        /// The DNS entry for the service.
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
        /// The failure code.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association between the service network and resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsManagedAssociation. 
        /// <para>
        /// Specifies whether the association is managed by Amazon.
        /// </para>
        /// </summary>
        public bool? IsManagedAssociation { get; set; }

        /// <summary>
        /// Checks to see if the IsManagedAssociation property is set.
        /// </summary>
        internal bool IsSetIsManagedAssociation() => this.IsManagedAssociation.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        ///  Indicates if private DNS is enabled for the service network resource association.
        /// 
        /// </para>
        /// </summary>
        public bool? PrivateDnsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEnabled property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEnabled() => this.PrivateDnsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateDnsEntry. 
        /// <para>
        /// The private DNS entry for the service.
        /// </para>
        /// </summary>
        public DnsEntry PrivateDnsEntry { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEntry property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEntry() => this.PrivateDnsEntry != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationArn property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationArn() => this.ResourceConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The ID of the resource configuration associated with the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string ResourceConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationId property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationId() => this.ResourceConfigurationId != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationName. 
        /// <para>
        /// The name of the resource configuration associated with the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string ResourceConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationName property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationName() => this.ResourceConfigurationName != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network associated with the resource
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 2048)]
        public string ServiceNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkArn property is set.
        /// </summary>
        internal bool IsSetServiceNetworkArn() => this.ServiceNetworkArn != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkId. 
        /// <para>
        /// The ID of the service network associated with the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 2048)]
        public string ServiceNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkId property is set.
        /// </summary>
        internal bool IsSetServiceNetworkId() => this.ServiceNetworkId != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkName. 
        /// <para>
        /// The name of the service network associated with the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string ServiceNetworkName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkName property is set.
        /// </summary>
        internal bool IsSetServiceNetworkName() => this.ServiceNetworkName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service network’s association with the resource configuration. If
        /// the deletion fails, try to delete again. 
        /// </para>
        /// </summary>
        public ServiceNetworkResourceAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
