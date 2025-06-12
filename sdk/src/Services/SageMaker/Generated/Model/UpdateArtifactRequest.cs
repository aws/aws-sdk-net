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
    /// Container for the parameters to the UpdateArtifact operation.
    /// Updates an artifact.
    /// </summary>
    public partial class UpdateArtifactRequest : AmazonSageMakerRequest
    {
        private string _artifactArn;
        private string _artifactName;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _propertiesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ArtifactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the artifact to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// The new name for the artifact.
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// The new list of properties. Overwrites the current property list.
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
        /// Gets and sets the property PropertiesToRemove. 
        /// <para>
        /// A list of properties to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PropertiesToRemove
        {
            get { return this._propertiesToRemove; }
            set { this._propertiesToRemove = value; }
        }

        // Check to see if PropertiesToRemove property is set
        internal bool IsSetPropertiesToRemove()
        {
            return this._propertiesToRemove != null && (this._propertiesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}