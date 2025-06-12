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
    /// This is the response object from the DescribeArtifact operation.
    /// </summary>
    public partial class DescribeArtifactResponse : AmazonWebServiceResponse
    {
        private string _artifactArn;
        private string _artifactName;
        private string _artifactType;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _lineageGroupArn;
        private MetadataProperties _metadataProperties;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ArtifactSource _source;

        /// <summary>
        /// Gets and sets the property ArtifactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ArtifactArn
        {
            get { return this._artifactArn; }
            set { this._artifactArn = value; }
        }

        // Check to see if ArtifactArn property is set
        internal bool IsSetArtifactArn()
        {
            return this._artifactArn != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactName. 
        /// <para>
        /// The name of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The type of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the artifact was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the artifact was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lineage group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string LineageGroupArn
        {
            get { return this._lineageGroupArn; }
            set { this._lineageGroupArn = value; }
        }

        // Check to see if LineageGroupArn property is set
        internal bool IsSetLineageGroupArn()
        {
            return this._lineageGroupArn != null;
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
        /// A list of the artifact's properties.
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
        /// The source of the artifact.
        /// </para>
        /// </summary>
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

    }
}