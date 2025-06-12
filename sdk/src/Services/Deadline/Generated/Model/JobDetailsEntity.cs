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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private JobAttachmentSettings _jobAttachmentSettings;
        private string _jobId;
        private JobRunAsUser _jobRunAsUser;
        private string _logGroupName;
        private Dictionary<string, JobParameter> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, JobParameter>() : null;
        private List<PathMappingRule> _pathMappingRules = AWSConfigs.InitializeCollections ? new List<PathMappingRule>() : null;
        private string _queueRoleArn;
        private string _schemaVersion;

        /// <summary>
        /// Gets and sets the property JobAttachmentSettings. 
        /// <para>
        /// The job attachment settings.
        /// </para>
        /// </summary>
        public JobAttachmentSettings JobAttachmentSettings
        {
            get { return this._jobAttachmentSettings; }
            set { this._jobAttachmentSettings = value; }
        }

        // Check to see if JobAttachmentSettings property is set
        internal bool IsSetJobAttachmentSettings()
        {
            return this._jobAttachmentSettings != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunAsUser. 
        /// <para>
        /// The user name and group that the job uses when run.
        /// </para>
        /// </summary>
        public JobRunAsUser JobRunAsUser
        {
            get { return this._jobRunAsUser; }
            set { this._jobRunAsUser = value; }
        }

        // Check to see if JobRunAsUser property is set
        internal bool IsSetJobRunAsUser()
        {
            return this._jobRunAsUser != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The log group name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, JobParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PathMappingRules. 
        /// <para>
        /// The path mapping rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PathMappingRule> PathMappingRules
        {
            get { return this._pathMappingRules; }
            set { this._pathMappingRules = value; }
        }

        // Check to see if PathMappingRules property is set
        internal bool IsSetPathMappingRules()
        {
            return this._pathMappingRules != null && (this._pathMappingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueRoleArn. 
        /// <para>
        /// The queue role ARN.
        /// </para>
        /// </summary>
        public string QueueRoleArn
        {
            get { return this._queueRoleArn; }
            set { this._queueRoleArn = value; }
        }

        // Check to see if QueueRoleArn property is set
        internal bool IsSetQueueRoleArn()
        {
            return this._queueRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

    }
}