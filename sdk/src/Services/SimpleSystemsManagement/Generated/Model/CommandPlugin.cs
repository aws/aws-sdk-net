/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes plugin details.
    /// </summary>
    public partial class CommandPlugin
    {
        private string _name;
        private string _output;
        private string _outputS3BucketName;
        private string _outputS3KeyPrefix;
        private int? _responseCode;
        private DateTime? _responseFinishDateTime;
        private DateTime? _responseStartDateTime;
        private CommandPluginStatus _status;

        /// <summary>
        /// Gets and sets the property Name. The name of the plugin. Must be one of the following:
        /// aws:updateAgent, aws:domainjoin, aws:applications, aws:runPowerShellScript, aws:psmodule,
        /// aws:cloudWatch, aws:runShellScript, or aws:updateSSMAgent.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Output. Output of the plugin execution.
        /// </summary>
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3BucketName. The S3 bucket where the responses to
        /// the command executions should be stored. This was requested when issuing the command.
        /// </summary>
        public string OutputS3BucketName
        {
            get { return this._outputS3BucketName; }
            set { this._outputS3BucketName = value; }
        }

        // Check to see if OutputS3BucketName property is set
        internal bool IsSetOutputS3BucketName()
        {
            return this._outputS3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. The S3 directory path inside the bucket
        /// where the responses to the command executions should be stored. This was requested
        /// when issuing the command.
        /// </summary>
        public string OutputS3KeyPrefix
        {
            get { return this._outputS3KeyPrefix; }
            set { this._outputS3KeyPrefix = value; }
        }

        // Check to see if OutputS3KeyPrefix property is set
        internal bool IsSetOutputS3KeyPrefix()
        {
            return this._outputS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. A numeric response code generated after executing
        /// the plugin.
        /// </summary>
        public int ResponseCode
        {
            get { return this._responseCode.GetValueOrDefault(); }
            set { this._responseCode = value; }
        }

        // Check to see if ResponseCode property is set
        internal bool IsSetResponseCode()
        {
            return this._responseCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseFinishDateTime. The time the plugin stopped executing.
        /// Could stop prematurely if, for example, a cancel command was sent.
        /// </summary>
        public DateTime ResponseFinishDateTime
        {
            get { return this._responseFinishDateTime.GetValueOrDefault(); }
            set { this._responseFinishDateTime = value; }
        }

        // Check to see if ResponseFinishDateTime property is set
        internal bool IsSetResponseFinishDateTime()
        {
            return this._responseFinishDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseStartDateTime. The time the plugin started executing.
        /// </summary>
        public DateTime ResponseStartDateTime
        {
            get { return this._responseStartDateTime.GetValueOrDefault(); }
            set { this._responseStartDateTime = value; }
        }

        // Check to see if ResponseStartDateTime property is set
        internal bool IsSetResponseStartDateTime()
        {
            return this._responseStartDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. The status of this plugin. You can execute a document
        /// with multiple plugins.
        /// </summary>
        public CommandPluginStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}