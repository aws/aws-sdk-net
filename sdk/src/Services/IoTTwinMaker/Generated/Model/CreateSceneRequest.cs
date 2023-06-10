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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScene operation.
    /// Creates a scene.
    /// </summary>
    public partial class CreateSceneRequest : AmazonIoTTwinMakerRequest
    {
        private List<string> _capabilities = new List<string>();
        private string _contentLocation;
        private string _description;
        private string _sceneId;
        private Dictionary<string, string> _sceneMetadata = new Dictionary<string, string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// A list of capabilities that the scene uses to render itself.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContentLocation. 
        /// <para>
        /// The relative path that specifies the location of the content definition file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ContentLocation
        {
            get { return this._contentLocation; }
            set { this._contentLocation = value; }
        }

        // Check to see if ContentLocation property is set
        internal bool IsSetContentLocation()
        {
            return this._contentLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for this scene.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SceneId. 
        /// <para>
        /// The ID of the scene.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string SceneId
        {
            get { return this._sceneId; }
            set { this._sceneId = value; }
        }

        // Check to see if SceneId property is set
        internal bool IsSetSceneId()
        {
            return this._sceneId != null;
        }

        /// <summary>
        /// Gets and sets the property SceneMetadata. 
        /// <para>
        /// The request metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> SceneMetadata
        {
            get { return this._sceneMetadata; }
            set { this._sceneMetadata = value; }
        }

        // Check to see if SceneMetadata property is set
        internal bool IsSetSceneMetadata()
        {
            return this._sceneMetadata != null && this._sceneMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that you can use to manage the scene.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that contains the scene.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}