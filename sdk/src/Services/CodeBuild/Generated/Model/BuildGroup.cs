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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about a batch build build group. Build groups are used to combine
    /// builds that can run in parallel, while still being able to set dependencies on other
    /// build groups.
    /// </summary>
    public partial class BuildGroup
    {
        private BuildSummary _currentBuildSummary;
        private List<string> _dependsOn = new List<string>();
        private string _identifier;
        private bool? _ignoreFailure;
        private List<BuildSummary> _priorBuildSummaryList = new List<BuildSummary>();

        /// <summary>
        /// Gets and sets the property CurrentBuildSummary. 
        /// <para>
        /// A <code>BuildSummary</code> object that contains a summary of the current build group.
        /// </para>
        /// </summary>
        public BuildSummary CurrentBuildSummary
        {
            get { return this._currentBuildSummary; }
            set { this._currentBuildSummary = value; }
        }

        // Check to see if CurrentBuildSummary property is set
        internal bool IsSetCurrentBuildSummary()
        {
            return this._currentBuildSummary != null;
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// An array of strings that contain the identifiers of the build groups that this build
        /// group depends on.
        /// </para>
        /// </summary>
        public List<string> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Contains the identifier of the build group.
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreFailure. 
        /// <para>
        /// Specifies if failures in this build group can be ignored.
        /// </para>
        /// </summary>
        public bool IgnoreFailure
        {
            get { return this._ignoreFailure.GetValueOrDefault(); }
            set { this._ignoreFailure = value; }
        }

        // Check to see if IgnoreFailure property is set
        internal bool IsSetIgnoreFailure()
        {
            return this._ignoreFailure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PriorBuildSummaryList. 
        /// <para>
        /// An array of <code>BuildSummary</code> objects that contain summaries of previous build
        /// groups.
        /// </para>
        /// </summary>
        public List<BuildSummary> PriorBuildSummaryList
        {
            get { return this._priorBuildSummaryList; }
            set { this._priorBuildSummaryList = value; }
        }

        // Check to see if PriorBuildSummaryList property is set
        internal bool IsSetPriorBuildSummaryList()
        {
            return this._priorBuildSummaryList != null && this._priorBuildSummaryList.Count > 0; 
        }

    }
}