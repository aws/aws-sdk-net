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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes an association with a license configuration.
    /// </summary>
    public partial class LicenseConfigurationAssociation
    {
        /// <summary>
        /// Gets and sets the property AmiAssociationScope. 
        /// <para>
        /// Scope of AMI associations. The possible value is <c>cross-account</c>.
        /// </para>
        /// </summary>
        public string AmiAssociationScope { get; set; }

        /// <summary>
        /// Checks to see if the AmiAssociationScope property is set.
        /// </summary>
        internal bool IsSetAmiAssociationScope() => this.AmiAssociationScope != null;

        /// <summary>
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// Time when the license configuration was associated with the resource.
        /// </para>
        /// </summary>
        public DateTime? AssociationTime { get; set; }

        /// <summary>
        /// Checks to see if the AssociationTime property is set.
        /// </summary>
        internal bool IsSetAssociationTime() => this.AssociationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// ID of the Amazon Web Services account that owns the resource consuming licenses.
        /// </para>
        /// </summary>
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerId() => this.ResourceOwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of server resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
