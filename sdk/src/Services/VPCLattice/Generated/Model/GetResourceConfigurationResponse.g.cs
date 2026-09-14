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
    /// This is the response object from the GetResourceConfiguration operation.
    /// </summary>
    public partial class GetResourceConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowAssociationToShareableServiceNetwork. 
        /// <para>
        /// Specifies whether the resource configuration is associated with a sharable service
        /// network.
        /// </para>
        /// </summary>
        public bool? AllowAssociationToShareableServiceNetwork { get; set; }

        /// <summary>
        /// Checks to see if the AllowAssociationToShareableServiceNetwork property is set.
        /// </summary>
        internal bool IsSetAllowAssociationToShareableServiceNetwork() => this.AllowAssociationToShareableServiceNetwork.HasValue;

        /// <summary>
        /// Gets and sets the property AmazonManaged. 
        /// <para>
        /// Indicates whether the resource configuration was created and is managed by Amazon.
        /// </para>
        /// </summary>
        public bool? AmazonManaged { get; set; }

        /// <summary>
        /// Checks to see if the AmazonManaged property is set.
        /// </summary>
        internal bool IsSetAmazonManaged() => this.AmazonManaged.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration.
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
        /// The date and time that the resource configuration was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property DomainVerificationArn. 
        /// <para>
        ///  The ARN of the domain verification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DomainVerificationArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainVerificationArn property is set.
        /// </summary>
        internal bool IsSetDomainVerificationArn() => this.DomainVerificationArn != null;

        /// <summary>
        /// Gets and sets the property DomainVerificationId. 
        /// <para>
        ///  The domain verification ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string DomainVerificationId { get; set; }

        /// <summary>
        /// Checks to see if the DomainVerificationId property is set.
        /// </summary>
        internal bool IsSetDomainVerificationId() => this.DomainVerificationId != null;

        /// <summary>
        /// Gets and sets the property DomainVerificationStatus. 
        /// <para>
        ///  The domain verification status. 
        /// </para>
        /// </summary>
        public VerificationStatus DomainVerificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainVerificationStatus property is set.
        /// </summary>
        internal bool IsSetDomainVerificationStatus() => this.DomainVerificationStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the create-resource-configuration request failed.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property GroupDomain. 
        /// <para>
        ///  (GROUP) The group domain for a group resource configuration. Any domains that you
        /// create for the child resource are subdomains of the group domain. Child resources
        /// inherit the verification status of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string GroupDomain { get; set; }

        /// <summary>
        /// Checks to see if the GroupDomain property is set.
        /// </summary>
        internal bool IsSetGroupDomain() => this.GroupDomain != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource configuration.
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
        /// The most recent date and time that the resource configuration was updated, in ISO-8601
        /// format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The TCP port ranges that a consumer can use to access a resource configuration. You
        /// can separate port ranges with a comma. Example: 1-65535 or 1,2,22-30
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PortRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PortRanges property is set.
        /// </summary>
        internal bool IsSetPortRanges() => this.PortRanges != null && (this.PortRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The TCP protocol accepted by the specified resource configuration.
        /// </para>
        /// </summary>
        public ProtocolType Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationDefinition. 
        /// <para>
        /// The resource configuration.
        /// </para>
        /// </summary>
        public ResourceConfigurationDefinition ResourceConfigurationDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationDefinition property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationDefinition() => this.ResourceConfigurationDefinition != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationGroupId. 
        /// <para>
        /// The ID of the group resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string ResourceConfigurationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationGroupId property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationGroupId() => this.ResourceConfigurationGroupId != null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayId. 
        /// <para>
        /// The ID of the resource gateway used to connect to the resource configuration in a
        /// given VPC. You can specify the resource gateway identifier only for resource configurations
        /// with type SINGLE, GROUP, or ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string ResourceGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayId property is set.
        /// </summary>
        internal bool IsSetResourceGatewayId() => this.ResourceGatewayId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resource configuration.
        /// </para>
        /// </summary>
        public ResourceConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE</c> - A single resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GROUP</c> - A group of resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHILD</c> - A single resource that is part of a group resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARN</c> - An Amazon Web Services resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceConfigurationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
