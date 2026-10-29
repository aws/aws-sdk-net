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
    /// A type of trigger configuration for Git-based source actions.
    /// 
    ///  <note> 
    /// <para>
    /// You can specify the Git configuration trigger type for all third-party Git-based source
    /// actions that are supported by the <c>CodeStarSourceConnection</c> action type.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GitConfiguration
    {
        /// <summary>
        /// Gets and sets the property PullRequest. 
        /// <para>
        /// The field where the repository event that will start the pipeline is specified as
        /// pull requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<GitPullRequestFilter> PullRequest { get; set; } = AWSConfigs.InitializeCollections ? new List<GitPullRequestFilter>() : null;

        /// <summary>
        /// Checks to see if the PullRequest property is set.
        /// </summary>
        internal bool IsSetPullRequest() => this.PullRequest != null && (this.PullRequest.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Push. 
        /// <para>
        /// The field where the repository event that will start the pipeline, such as pushing
        /// Git tags, is specified with details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<GitPushFilter> Push { get; set; } = AWSConfigs.InitializeCollections ? new List<GitPushFilter>() : null;

        /// <summary>
        /// Checks to see if the Push property is set.
        /// </summary>
        internal bool IsSetPush() => this.Push != null && (this.Push.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceActionName. 
        /// <para>
        /// The name of the pipeline source action where the trigger configuration, such as Git
        /// tags, is specified. The trigger configuration will start the pipeline upon the specified
        /// change only.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only specify one trigger configuration per source action.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SourceActionName { get; set; }

        /// <summary>
        /// Checks to see if the SourceActionName property is set.
        /// </summary>
        internal bool IsSetSourceActionName() => this.SourceActionName != null;
    }
}
