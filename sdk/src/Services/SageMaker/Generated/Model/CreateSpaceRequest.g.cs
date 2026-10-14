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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpace operation. Creates a private space
    /// or a space used for real time collaboration in a domain.
    /// </summary>
    public partial class CreateSpaceRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property OwnershipSettings. 
        /// <para>
        /// A collection of ownership settings.
        /// </para>
        /// </summary>
        public OwnershipSettings OwnershipSettings { get; set; }

        /// <summary>
        /// Checks to see if the OwnershipSettings property is set.
        /// </summary>
        internal bool IsSetOwnershipSettings() => this.OwnershipSettings != null;

        /// <summary>
        /// Gets and sets the property SpaceDisplayName. 
        /// <para>
        /// The name of the space that appears in the SageMaker Studio UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SpaceDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceDisplayName property is set.
        /// </summary>
        internal bool IsSetSpaceDisplayName() => this.SpaceDisplayName != null;

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;

        /// <summary>
        /// Gets and sets the property SpaceSettings. 
        /// <para>
        /// A collection of space settings.
        /// </para>
        /// </summary>
        public SpaceSettings SpaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceSettings property is set.
        /// </summary>
        internal bool IsSetSpaceSettings() => this.SpaceSettings != null;

        /// <summary>
        /// Gets and sets the property SpaceSharingSettings. 
        /// <para>
        /// A collection of space sharing settings.
        /// </para>
        /// </summary>
        public SpaceSharingSettings SpaceSharingSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceSharingSettings property is set.
        /// </summary>
        internal bool IsSetSpaceSharingSettings() => this.SpaceSharingSettings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associated with the space. Each tag consists of a key and an optional value.
        /// Tag keys must be unique for each resource. Tags are searchable using the <c>Search</c>
        /// API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
