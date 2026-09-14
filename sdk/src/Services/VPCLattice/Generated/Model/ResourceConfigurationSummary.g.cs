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
    /// Summary information about a resource configuration.
    /// </summary>
    public partial class ResourceConfigurationSummary
    {
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
        ///  The custom domain name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

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
        /// The ID of the resource gateway.
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
        ///  <c>GROUP</c> - A group of resources. You must create a group resource configuration
        /// before you create a child resource configuration.
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
