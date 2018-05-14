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
    /// Container for the parameters to the DescribePlacement operation.
    /// Describes a placement in a project.
    /// </summary>
    public partial class DescribePlacementRequest : AmazonIoT1ClickProjectsRequest
    {
        private string _placementName;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property PlacementName. 
        /// <para>
        /// The name of the placement within a project.
        /// </para>
        /// </summary>
        public string PlacementName
        {
            get { return this._placementName; }
            set { this._placementName = value; }
        }

        // Check to see if PlacementName property is set
        internal bool IsSetPlacementName()
        {
            return this._placementName != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The project containing the placement to be described.
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