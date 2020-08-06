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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickProjects.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates an empty project with a placement template. A project contains zero or more
    /// placements that adhere to the placement template defined in the project.
    /// </summary>
    public partial class CreateProjectRequest : AmazonIoT1ClickProjectsRequest
    {
        private string _description;
        private PlacementTemplate _placementTemplate;
        private string _projectName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property PlacementTemplate. 
        /// <para>
        /// The schema defining the placement to be created. A placement template defines placement
        /// default attributes and device templates. You cannot add or remove device templates
        /// after the project has been created. However, you can update <code>callbackOverrides</code>
        /// for the device templates using the <code>UpdateProject</code> API.
        /// </para>
        /// </summary>
        public PlacementTemplate PlacementTemplate
        {
            get { return this._placementTemplate; }
            set { this._placementTemplate = value; }
        }

        // Check to see if PlacementTemplate property is set
        internal bool IsSetPlacementTemplate()
        {
            return this._placementTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional tags (metadata key/value pairs) to be associated with the project. For example,
        /// <code>{ {"key1": "value1", "key2": "value2"} }</code>. For more information, see <a
        /// href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
        /// Tagging Strategies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

    }
}