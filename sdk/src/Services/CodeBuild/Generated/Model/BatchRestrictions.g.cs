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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Specifies restrictions for the batch build.
    /// </summary>
    public partial class BatchRestrictions
    {
        /// <summary>
        /// Gets and sets the property ComputeTypesAllowed. 
        /// <para>
        /// An array of strings that specify the compute types that are allowed for the batch
        /// build. See <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild User Guide</i> for these values.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ComputeTypesAllowed { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ComputeTypesAllowed property is set.
        /// </summary>
        internal bool IsSetComputeTypesAllowed() => this.ComputeTypesAllowed != null && (this.ComputeTypesAllowed.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FleetsAllowed. 
        /// <para>
        /// An array of strings that specify the fleets that are allowed for the batch build.
        /// See <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/fleets.html">Run
        /// builds on reserved capacity fleets</a> in the <i>CodeBuild User Guide</i> for more
        /// information. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FleetsAllowed { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FleetsAllowed property is set.
        /// </summary>
        internal bool IsSetFleetsAllowed() => this.FleetsAllowed != null && (this.FleetsAllowed.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaximumBuildsAllowed. 
        /// <para>
        /// Specifies the maximum number of builds allowed.
        /// </para>
        /// </summary>
        public int? MaximumBuildsAllowed { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBuildsAllowed property is set.
        /// </summary>
        internal bool IsSetMaximumBuildsAllowed() => this.MaximumBuildsAllowed.HasValue;
    }
}
