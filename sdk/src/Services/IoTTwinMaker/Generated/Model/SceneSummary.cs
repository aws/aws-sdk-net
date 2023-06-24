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
    /// An object that contains information about a scene.
    /// </summary>
    public partial class SceneSummary
    {
        private string _arn;
        private string _contentLocation;
        private DateTime? _creationDateTime;
        private string _description;
        private string _sceneId;
        private DateTime? _updateDateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the scene.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the scene was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The scene description.
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
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The date and time when the scene was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateDateTime
        {
            get { return this._updateDateTime.GetValueOrDefault(); }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

    }
}