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
    /// Contains configuration information about a batch build project.
    /// </summary>
    public partial class ProjectBuildBatchConfig
    {
        /// <summary>
        /// Gets and sets the property BatchReportMode. 
        /// <para>
        /// Specifies how build status reports are sent to the source provider for the batch build.
        /// This property is only used when the source provider for your project is Bitbucket,
        /// GitHub, or GitHub Enterprise, and your project is configured to report build statuses
        /// to the source provider.
        /// </para>
        ///  <dl> <dt>REPORT_AGGREGATED_BATCH</dt> <dd> 
        /// <para>
        /// (Default) Aggregate all of the build statuses into a single status report.
        /// </para>
        ///  </dd> <dt>REPORT_INDIVIDUAL_BUILDS</dt> <dd> 
        /// <para>
        /// Send a separate status report for each individual build.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public BatchReportModeType BatchReportMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchReportMode property is set.
        /// </summary>
        internal bool IsSetBatchReportMode() => this.BatchReportMode != null;

        /// <summary>
        /// Gets and sets the property CombineArtifacts. 
        /// <para>
        /// Specifies if the build artifacts for the batch build should be combined into a single
        /// artifact location.
        /// </para>
        /// </summary>
        public bool? CombineArtifacts { get; set; }

        /// <summary>
        /// Checks to see if the CombineArtifacts property is set.
        /// </summary>
        internal bool IsSetCombineArtifacts() => this.CombineArtifacts.HasValue;

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        /// A <c>BatchRestrictions</c> object that specifies the restrictions for the batch build.
        /// </para>
        /// </summary>
        public BatchRestrictions Restrictions { get; set; }

        /// <summary>
        /// Checks to see if the Restrictions property is set.
        /// </summary>
        internal bool IsSetRestrictions() => this.Restrictions != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// Specifies the service role ARN for the batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMins. 
        /// <para>
        /// Specifies the maximum amount of time, in minutes, that the batch build must be completed
        /// in.
        /// </para>
        /// </summary>
        public int? TimeoutInMins { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMins property is set.
        /// </summary>
        internal bool IsSetTimeoutInMins() => this.TimeoutInMins.HasValue;
    }
}
