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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the CreateSpace operation.
    /// Creates a private space or a space used for real time collaboration in a domain.
    /// </summary>
    public partial class CreateSpaceRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private OwnershipSettings _ownershipSettings;
        private string _spaceDisplayName;
        private string _spaceName;
        private SpaceSettings _spaceSettings;
        private SpaceSharingSettings _spaceSharingSettings;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnershipSettings. 
        /// <para>
        /// A collection of ownership settings.
        /// </para>
        /// </summary>
        public OwnershipSettings OwnershipSettings
        {
            get { return this._ownershipSettings; }
            set { this._ownershipSettings = value; }
        }

        // Check to see if OwnershipSettings property is set
        internal bool IsSetOwnershipSettings()
        {
            return this._ownershipSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceDisplayName. 
        /// <para>
        /// The name of the space that appears in the SageMaker Studio UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string SpaceDisplayName
        {
            get { return this._spaceDisplayName; }
            set { this._spaceDisplayName = value; }
        }

        // Check to see if SpaceDisplayName property is set
        internal bool IsSetSpaceDisplayName()
        {
            return this._spaceDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceSettings. 
        /// <para>
        /// A collection of space settings.
        /// </para>
        /// </summary>
        public SpaceSettings SpaceSettings
        {
            get { return this._spaceSettings; }
            set { this._spaceSettings = value; }
        }

        // Check to see if SpaceSettings property is set
        internal bool IsSetSpaceSettings()
        {
            return this._spaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceSharingSettings. 
        /// <para>
        /// A collection of space sharing settings.
        /// </para>
        /// </summary>
        public SpaceSharingSettings SpaceSharingSettings
        {
            get { return this._spaceSharingSettings; }
            set { this._spaceSharingSettings = value; }
        }

        // Check to see if SpaceSharingSettings property is set
        internal bool IsSetSpaceSharingSettings()
        {
            return this._spaceSharingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associated with the space. Each tag consists of a key and an optional value.
        /// Tag keys must be unique for each resource. Tags are searchable using the <c>Search</c>
        /// API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}