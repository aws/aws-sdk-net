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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A filter for listing configuration bundle versions.
    /// </summary>
    public partial class VersionFilter
    {
        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// Filter by branch name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property CreatedByName. 
        /// <para>
        /// Filter by creation source name.
        /// </para>
        /// </summary>
        public string CreatedByName { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByName property is set.
        /// </summary>
        internal bool IsSetCreatedByName() => this.CreatedByName != null;

        /// <summary>
        /// Gets and sets the property LatestPerBranch. 
        /// <para>
        /// When true, returns only the latest version for each branch. When false or not specified,
        /// returns all versions. Can be combined with <c>branchName</c> to get the latest version
        /// for a specific branch.
        /// </para>
        /// </summary>
        public bool? LatestPerBranch { get; set; }

        /// <summary>
        /// Checks to see if the LatestPerBranch property is set.
        /// </summary>
        internal bool IsSetLatestPerBranch() => this.LatestPerBranch.HasValue;
    }
}
