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
    /// An object providing detailed information for a particular project associated with
    /// an AWS account and region.
    /// </summary>
    public partial class ProjectDescription
    {
        private DateTime? _createdDate;
        private string _description;
        private PlacementTemplate _placementTemplate;
        private string _projectName;
        private DateTime? _updatedDate;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the project was originally created, in UNIX epoch time format.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the project.
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
        /// An object describing the project's placement specifications.
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
        /// The name of the project for which to obtain information from.
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

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The date when the project was last updated, in UNIX epoch time format. If the project
        /// was not updated, then <code>createdDate</code> and <code>updatedDate</code> are the
        /// same.
        /// </para>
        /// </summary>
        public DateTime UpdatedDate
        {
            get { return this._updatedDate.GetValueOrDefault(); }
            set { this._updatedDate = value; }
        }

        // Check to see if UpdatedDate property is set
        internal bool IsSetUpdatedDate()
        {
            return this._updatedDate.HasValue; 
        }

    }
}