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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The job details for a specific job.
    /// </summary>
    public partial class JobDetailsEntity
    {
        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// The Open Job Description extensions that the job template uses. This value is used
        /// by the worker agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public List<string> Extensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null && (this.Extensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobAttachmentSettings. 
        /// <para>
        /// The job attachment settings.
        /// </para>
        /// </summary>
        public JobDetailsJobAttachmentSettings JobAttachmentSettings { get; set; }

        /// <summary>
        /// Checks to see if the JobAttachmentSettings property is set.
        /// </summary>
        internal bool IsSetJobAttachmentSettings() => this.JobAttachmentSettings != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobRunAsUser. 
        /// <para>
        /// The user name and group that the job uses when run.
        /// </para>
        /// </summary>
        public JobRunAsUser JobRunAsUser { get; set; }

        /// <summary>
        /// Checks to see if the JobRunAsUser property is set.
        /// </summary>
        internal bool IsSetJobRunAsUser() => this.JobRunAsUser != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The log group name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public Dictionary<string, JobParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, JobParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PathMappingRules. 
        /// <para>
        /// The path mapping rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PathMappingRule> PathMappingRules { get; set; } = AWSConfigs.InitializeCollections ? new List<PathMappingRule>() : null;

        /// <summary>
        /// Checks to see if the PathMappingRules property is set.
        /// </summary>
        internal bool IsSetPathMappingRules() => this.PathMappingRules != null && (this.PathMappingRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueueRoleArn. 
        /// <para>
        /// The queue role ARN.
        /// </para>
        /// </summary>
        public string QueueRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the QueueRoleArn property is set.
        /// </summary>
        internal bool IsSetQueueRoleArn() => this.QueueRoleArn != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;
    }
}
