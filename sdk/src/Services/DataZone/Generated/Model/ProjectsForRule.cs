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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Specifies projects in which the rule is created.
    /// </summary>
    public partial class ProjectsForRule
    {
        private RuleScopeSelectionMode _selectionMode;
        private List<string> _specificProjects = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SelectionMode. 
        /// <para>
        /// The selection mode of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleScopeSelectionMode SelectionMode
        {
            get { return this._selectionMode; }
            set { this._selectionMode = value; }
        }

        // Check to see if SelectionMode property is set
        internal bool IsSetSelectionMode()
        {
            return this._selectionMode != null;
        }

        /// <summary>
        /// Gets and sets the property SpecificProjects. 
        /// <para>
        /// The specific projects in which the rule is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> SpecificProjects
        {
            get { return this._specificProjects; }
            set { this._specificProjects = value; }
        }

        // Check to see if SpecificProjects property is set
        internal bool IsSetSpecificProjects()
        {
            return this._specificProjects != null && (this._specificProjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}