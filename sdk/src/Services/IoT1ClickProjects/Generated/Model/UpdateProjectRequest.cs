/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickProjects.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProject operation.
    /// Updates a project associated with your AWS account and region. With the exception
    /// of device template names, you can pass just the values that need to be updated because
    /// the update request will change only the values that are provided. To clear a value,
    /// pass the empty string (i.e., <code>""</code>).
    /// </summary>
    public partial class UpdateProjectRequest : AmazonIoT1ClickProjectsRequest
    {
        private string _description;
        private PlacementTemplate _placementTemplate;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional user-defined description for the project.
        /// </para>
        /// </summary>
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
        /// An object defining the project update. Once a project has been created, you cannot
        /// add device template names to the project. However, for a given <code>placementTemplate</code>,
        /// you can update the associated <code>callbackOverrides</code> for the device definition
        /// using this API.
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
        /// The name of the project to be updated.
        /// </para>
        /// </summary>
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

    }
}