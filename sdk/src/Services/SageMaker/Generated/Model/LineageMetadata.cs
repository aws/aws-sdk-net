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
    /// The metadata that tracks relationships between ML artifacts, actions, and contexts.
    /// </summary>
    public partial class LineageMetadata
    {
        private Dictionary<string, string> _actionArns = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _artifactArns = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<AssociationInfo> _associations = AWSConfigs.InitializeCollections ? new List<AssociationInfo>() : null;
        private Dictionary<string, string> _contextArns = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActionArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the lineage metadata action. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> ActionArns
        {
            get { return this._actionArns; }
            set { this._actionArns = value; }
        }

        // Check to see if ActionArns property is set
        internal bool IsSetActionArns()
        {
            return this._actionArns != null && (this._actionArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ArtifactArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the lineage metadata artifact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> ArtifactArns
        {
            get { return this._artifactArns; }
            set { this._artifactArns = value; }
        }

        // Check to see if ArtifactArns property is set
        internal bool IsSetArtifactArns()
        {
            return this._artifactArns != null && (this._artifactArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        ///  The lineage metadata associations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<AssociationInfo> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && (this._associations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContextArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the lineage metadata context. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> ContextArns
        {
            get { return this._contextArns; }
            set { this._contextArns = value; }
        }

        // Check to see if ContextArns property is set
        internal bool IsSetContextArns()
        {
            return this._contextArns != null && (this._contextArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}