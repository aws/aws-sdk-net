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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The event criteria for the pull request trigger configuration, such as the lists of
    /// branches or file paths to include and exclude.
    /// 
    ///  
    /// <para>
    /// The following are valid values for the events for this filter:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CLOSED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// OPEN
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// UPDATED
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GitPullRequestFilter
    {
        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The field that specifies to filter on branches for the pull request trigger configuration.
        /// </para>
        /// </summary>
        public GitBranchFilterCriteria Branches { get; set; }

        /// <summary>
        /// Checks to see if the Branches property is set.
        /// </summary>
        internal bool IsSetBranches() => this.Branches != null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The field that specifies which pull request events to filter on (OPEN, UPDATED, CLOSED)
        /// for the trigger configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilePaths. 
        /// <para>
        /// The field that specifies to filter on file paths for the pull request trigger configuration.
        /// </para>
        /// </summary>
        public GitFilePathFilterCriteria FilePaths { get; set; }

        /// <summary>
        /// Checks to see if the FilePaths property is set.
        /// </summary>
        internal bool IsSetFilePaths() => this.FilePaths != null;
    }
}
