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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the StartSession operation. Creates a session for
    /// running calculations within a workgroup. The session is ready when it reaches an <c>IDLE</c>
    /// state.
    /// </summary>
    public partial class StartSessionRequest : AmazonAthenaRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique case-sensitive string used to ensure the request to create the session is
        /// idempotent (executes only once). If another <c>StartSessionRequest</c> is received,
        /// the same response is returned and another session is not created. If a parameter has
        /// changed, an error is returned.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token is listed as not required because Amazon Web Services SDKs (for example
        /// the Amazon Web Services SDK for Java) auto-generate the token for users. If you are
        /// not using the Amazon Web Services SDK or the Amazon Web Services CLI, you must provide
        /// this token or the action will fail.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 32, Max = 128)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CopyWorkGroupTags. 
        /// <para>
        /// Copies the tags from the Workgroup to the Session when.
        /// </para>
        /// </summary>
        public bool? CopyWorkGroupTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyWorkGroupTags property is set.
        /// </summary>
        internal bool IsSetCopyWorkGroupTags() => this.CopyWorkGroupTags.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The session description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngineConfiguration. 
        /// <para>
        /// Contains engine data processing unit (DPU) configuration settings and parameter mappings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EngineConfiguration EngineConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EngineConfiguration property is set.
        /// </summary>
        internal bool IsSetEngineConfiguration() => this.EngineConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the execution role used to access user resources for Spark sessions and
        /// Identity Center enabled workgroups. This property applies only to Spark enabled workgroups
        /// and Identity Center enabled workgroups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// Contains the configuration settings for managed log persistence, delivering logs to
        /// Amazon S3 buckets, Amazon CloudWatch log groups etc.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetMonitoringConfiguration() => this.MonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property NotebookVersion. 
        /// <para>
        /// The notebook version. This value is supplied automatically for notebook sessions in
        /// the Athena console and is not required for programmatic session access. The only valid
        /// notebook version is <c>Athena notebook version 1</c>. If you specify a value for <c>NotebookVersion</c>,
        /// you must also specify a value for <c>NotebookId</c>. See <a>EngineConfiguration$AdditionalConfigs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NotebookVersion { get; set; }

        /// <summary>
        /// Checks to see if the NotebookVersion property is set.
        /// </summary>
        internal bool IsSetNotebookVersion() => this.NotebookVersion != null;

        /// <summary>
        /// Gets and sets the property SessionIdleTimeoutInMinutes. 
        /// <para>
        /// The idle timeout in minutes for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 480)]
        public int? SessionIdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the SessionIdleTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetSessionIdleTimeoutInMinutes() => this.SessionIdleTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of comma separated tags to add to the session that is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The workgroup to which the session belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
