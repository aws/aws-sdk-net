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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpace operation.
    /// Creates a space used for real time collaboration in a Domain.
    /// </summary>
    public partial class CreateSpaceRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private string _spaceName;
        private SpaceSettings _spaceSettings;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associated with the space. Each tag consists of a key and an optional value.
        /// Tag keys must be unique for each resource. Tags are searchable using the <code>Search</code>
        /// API.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}