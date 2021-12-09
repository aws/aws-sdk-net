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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Contains validation parameters.
    /// </summary>
    public partial class SSMValidationParameters
    {
        private string _command;
        private int? _executionTimeoutSeconds;
        private string _instanceId;
        private string _outputs3BucketName;
        private ScriptType _scriptType;
        private Source _source;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to run the validation script.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64000)]
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutSeconds. 
        /// <para>
        /// The timeout interval, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=28800)]
        public int ExecutionTimeoutSeconds
        {
            get { return this._executionTimeoutSeconds.GetValueOrDefault(); }
            set { this._executionTimeoutSeconds = value; }
        }

        // Check to see if ExecutionTimeoutSeconds property is set
        internal bool IsSetExecutionTimeoutSeconds()
        {
            return this._executionTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance. The instance must have the following tag: UserForSMSApplicationValidation=true.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The name of the S3 bucket for output.
        /// </para>
        /// </summary>
        public string OutputS3BucketName
        {
            get { return this._outputs3BucketName; }
            set { this._outputs3BucketName = value; }
        }

        // Check to see if OutputS3BucketName property is set
        internal bool IsSetOutputS3BucketName()
        {
            return this._outputs3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptType. 
        /// <para>
        /// The type of validation script.
        /// </para>
        /// </summary>
        public ScriptType ScriptType
        {
            get { return this._scriptType; }
            set { this._scriptType = value; }
        }

        // Check to see if ScriptType property is set
        internal bool IsSetScriptType()
        {
            return this._scriptType != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The location of the validation script.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}