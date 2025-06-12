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
    /// Container for the parameters to the CreateArtifact operation.
    /// Creates an <i>artifact</i>. An artifact is a lineage tracking entity that represents
    /// a URI addressable object or data. Some examples are the S3 URI of a dataset and the
    /// ECR registry path of an image. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
    /// SageMaker ML Lineage Tracking</a>.
    /// </summary>
    public partial class CreateArtifactRequest : AmazonSageMakerRequest
    {
        private string _artifactName;
        private string _artifactType;
        private MetadataProperties _metadataProperties;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ArtifactSource _source;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ArtifactName. 
        /// <para>
        /// The name of the artifact. Must be unique to your account in an Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string ArtifactName
        {
            get { return this._artifactName; }
            set { this._artifactName = value; }
        }

        // Check to see if ArtifactName property is set
        internal bool IsSetArtifactName()
        {
            return this._artifactName != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// The artifact type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ArtifactType
        {
            get { return this._artifactType; }
            set { this._artifactType = value; }
        }

        // Check to see if ArtifactType property is set
        internal bool IsSetArtifactType()
        {
            return this._artifactType != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties
        {
            get { return this._metadataProperties; }
            set { this._metadataProperties = value; }
        }

        // Check to see if MetadataProperties property is set
        internal bool IsSetMetadataProperties()
        {
            return this._metadataProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A list of properties to add to the artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The ID, ID type, and URI of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the artifact.
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