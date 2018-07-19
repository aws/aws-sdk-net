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
        private string _outputS3Region;
        private int? _responseCode;
        private DateTime? _responseFinishDateTime;
        private DateTime? _responseStartDateTime;
        private string _standardErrorUrl;
        private string _standardOutputUrl;
        private CommandPluginStatus _status;
        private string _statusDetails;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the plugin. Must be one of the following: aws:updateAgent, aws:domainjoin,
        /// aws:applications, aws:runPowerShellScript, aws:psmodule, aws:cloudWatch, aws:runShellScript,
        /// or aws:updateSSMAgent. 
        /// </para>
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
        /// Gets and sets the property Output. 
        /// <para>
        /// Output of the plugin execution.
        /// </para>
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
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The S3 bucket where the responses to the command executions should be stored. This
        /// was requested when issuing the command. For example, in the following response:
        /// </para>
        ///  
        /// <para>
        ///  test_folder/ab19cb99-a030-46dd-9dfc-8eSAMPLEPre-Fix/i-1234567876543/awsrunShellScript
        /// 
        /// </para>
        ///  
        /// <para>
        /// test_folder is the name of the Amazon S3 bucket;
        /// </para>
        ///  
        /// <para>
        ///  ab19cb99-a030-46dd-9dfc-8eSAMPLEPre-Fix is the name of the S3 prefix;
        /// </para>
        ///  
        /// <para>
        /// i-1234567876543 is the instance ID;
        /// </para>
        ///  
        /// <para>
        /// awsrunShellScript is the name of the plugin.
        /// </para>
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
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The S3 directory path inside the bucket where the responses to the command executions
        /// should be stored. This was requested when issuing the command. For example, in the
        /// following response:
        /// </para>
        ///  
        /// <para>
        ///  test_folder/ab19cb99-a030-46dd-9dfc-8eSAMPLEPre-Fix/i-1234567876543/awsrunShellScript
        /// 
        /// </para>
        ///  
        /// <para>
        /// test_folder is the name of the Amazon S3 bucket;
        /// </para>
        ///  
        /// <para>
        ///  ab19cb99-a030-46dd-9dfc-8eSAMPLEPre-Fix is the name of the S3 prefix;
        /// </para>
        ///  
        /// <para>
        /// i-1234567876543 is the instance ID;
        /// </para>
        ///  
        /// <para>
        /// awsrunShellScript is the name of the plugin.
        /// </para>
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
        /// Gets and sets the property OutputS3Region. 
        /// <para>
        /// (Deprecated) You can no longer specify this parameter. The system ignores it. Instead,
        /// Systems Manager automatically determines the Amazon S3 bucket region.
        /// </para>
        /// </summary>
        public string OutputS3Region
        {
            get { return this._outputS3Region; }
            set { this._outputS3Region = value; }
        }

        // Check to see if OutputS3Region property is set
        internal bool IsSetOutputS3Region()
        {
            return this._outputS3Region != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// A numeric response code generated after executing the plugin. 
        /// </para>
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
        /// Gets and sets the property ResponseFinishDateTime. 
        /// <para>
        /// The time the plugin stopped executing. Could stop prematurely if, for example, a cancel
        /// command was sent. 
        /// </para>
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
        /// Gets and sets the property ResponseStartDateTime. 
        /// <para>
        /// The time the plugin started executing. 
        /// </para>
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
        /// Gets and sets the property StandardErrorUrl. 
        /// <para>
        /// The URL for the complete text written by the plugin to stderr. If execution is not
        /// yet complete, then this string is empty.
        /// </para>
        /// </summary>
        public string StandardErrorUrl
        {
            get { return this._standardErrorUrl; }
            set { this._standardErrorUrl = value; }
        }

        // Check to see if StandardErrorUrl property is set
        internal bool IsSetStandardErrorUrl()
        {
            return this._standardErrorUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutputUrl. 
        /// <para>
        /// The URL for the complete text written by the plugin to stdout in Amazon S3. If the
        /// Amazon S3 bucket for the command was not specified, then this string is empty.
        /// </para>
        /// </summary>
        public string StandardOutputUrl
        {
            get { return this._standardOutputUrl; }
            set { this._standardOutputUrl = value; }
        }

        // Check to see if StandardOutputUrl property is set
        internal bool IsSetStandardOutputUrl()
        {
            return this._standardOutputUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this plugin. You can execute a document with multiple plugins.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A detailed status of the plugin execution. StatusDetails includes more information
        /// than Status because it includes states resulting from error and concurrency control
        /// parameters. StatusDetails can show different results than Status. For more information
        /// about these statuses, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html">Understanding
        /// Command Statuses</a> in the <i>AWS Systems Manager User Guide</i>. StatusDetails can
        /// be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The command has not been sent to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The command has been sent to the instance but has not reached a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The execution of the command or plugin was successfully completed. This is
        /// a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery Timed Out: The command was not delivered to the instance before the delivery
        /// timeout expired. Delivery timeouts do not count against the parent command's MaxErrors
        /// limit, but they do contribute to whether the parent command status is Success or Incomplete.
        /// This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Execution Timed Out: Command execution started on the instance, but the execution
        /// was not complete before the execution timeout expired. Execution timeouts count against
        /// the MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The command was not successful on the instance. For a plugin, this indicates
        /// that the result code was not zero. For a command invocation, this indicates that the
        /// result code for one or more plugins was not zero. Invocation failures count against
        /// the MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Canceled: The command was terminated before it was completed. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Undeliverable: The command can't be delivered to the instance. The instance might
        /// not exist, or it might not be responding. Undeliverable invocations don't count against
        /// the parent command's MaxErrors limit, and they don't contribute to whether the parent
        /// command status is Success or Incomplete. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Terminated: The parent command exceeded its MaxErrors limit and subsequent command
        /// invocations were canceled by the system. This is a terminal state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

    }
}