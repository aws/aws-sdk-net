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
    /// Contains summary information about a batch build group.
    /// </summary>
    public partial class BuildSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The batch build ARN.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The status of the build group.
        /// </para>
        ///  <dl> <dt>FAILED</dt> <dd> 
        /// <para>
        /// The build group failed.
        /// </para>
        ///  </dd> <dt>FAULT</dt> <dd> 
        /// <para>
        /// The build group faulted.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The build group is still in progress.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The build group stopped.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The build group succeeded.
        /// </para>
        ///  </dd> <dt>TIMED_OUT</dt> <dd> 
        /// <para>
        /// The build group timed out.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public StatusType BuildStatus { get; set; }

        /// <summary>
        /// Checks to see if the BuildStatus property is set.
        /// </summary>
        internal bool IsSetBuildStatus() => this.BuildStatus != null;

        /// <summary>
        /// Gets and sets the property PrimaryArtifact. 
        /// <para>
        /// A <c>ResolvedArtifact</c> object that represents the primary build artifacts for the
        /// build group.
        /// </para>
        /// </summary>
        public ResolvedArtifact PrimaryArtifact { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryArtifact property is set.
        /// </summary>
        internal bool IsSetPrimaryArtifact() => this.PrimaryArtifact != null;

        /// <summary>
        /// Gets and sets the property RequestedOn. 
        /// <para>
        /// When the build was started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? RequestedOn { get; set; }

        /// <summary>
        /// Checks to see if the RequestedOn property is set.
        /// </summary>
        internal bool IsSetRequestedOn() => this.RequestedOn.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// An array of <c>ResolvedArtifact</c> objects that represents the secondary build artifacts
        /// for the build group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolvedArtifact> SecondaryArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<ResolvedArtifact>() : null;

        /// <summary>
        /// Checks to see if the SecondaryArtifacts property is set.
        /// </summary>
        internal bool IsSetSecondaryArtifacts() => this.SecondaryArtifacts != null && (this.SecondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
