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
    /// Summary information about a VPC endpoint association.
    /// </summary>
    public partial class ResourceEndpointAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC endpoint association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the VPC endpoint association was created, in ISO-8601 format.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the VPC endpoint association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PayerResponsibility. 
        /// <para>
        /// Who pays for each category of charges on the VPC endpoint association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<PayerResponsibilityEntry> PayerResponsibility { get; set; } = AWSConfigs.InitializeCollections ? new List<PayerResponsibilityEntry>() : null;

        /// <summary>
        /// Checks to see if the PayerResponsibility property is set.
        /// </summary>
        internal bool IsSetPayerResponsibility() => this.PayerResponsibility != null && (this.PayerResponsibility.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration.
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
        /// The ID of the resource configuration.
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
        /// The name of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string ResourceConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationName property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationName() => this.ResourceConfigurationName != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The owner of the VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string VpcEndpointOwner { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointOwner property is set.
        /// </summary>
        internal bool IsSetVpcEndpointOwner() => this.VpcEndpointOwner != null;
    }
}
