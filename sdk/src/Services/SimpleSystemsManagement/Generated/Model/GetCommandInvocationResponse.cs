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
    /// This is the response object from the GetCommandInvocation operation.
    /// </summary>
    public partial class GetCommandInvocationResponse : AmazonWebServiceResponse
    {
        private string _commandId;
        private string _comment;
        private string _documentName;
        private string _documentVersion;
        private string _executionElapsedTime;
        private string _executionEndDateTime;
        private string _executionStartDateTime;
        private string _instanceId;
        private string _pluginName;
        private int? _responseCode;
        private string _standardErrorContent;
        private string _standardErrorUrl;
        private string _standardOutputContent;
        private string _standardOutputUrl;
        private CommandInvocationStatus _status;
        private string _statusDetails;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The parent command ID of the invocation plugin.
        /// </para>
        /// </summary>
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment text for the command.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the document that was executed. For example, AWS-RunShellScript.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The SSM document version used in the request.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionElapsedTime. 
        /// <para>
        /// Duration since ExecutionStartDateTime.
        /// </para>
        /// </summary>
        public string ExecutionElapsedTime
        {
            get { return this._executionElapsedTime; }
            set { this._executionElapsedTime = value; }
        }

        // Check to see if ExecutionElapsedTime property is set
        internal bool IsSetExecutionElapsedTime()
        {
            return this._executionElapsedTime != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEndDateTime. 
        /// <para>
        /// The date and time the plugin was finished executing. Date and time are written in
        /// ISO 8601 format. For example, June 7, 2017 is represented as 2017-06-7. The following
        /// sample AWS CLI command uses the <code>InvokedAfter</code> filter.
        /// </para>
        ///  
        /// <para>
        ///  <code>aws ssm list-commands --filters key=InvokedAfter,value=2017-06-07T00:00:00Z</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the plugin has not started to execute, the string is empty.
        /// </para>
        /// </summary>
        public string ExecutionEndDateTime
        {
            get { return this._executionEndDateTime; }
            set { this._executionEndDateTime = value; }
        }

        // Check to see if ExecutionEndDateTime property is set
        internal bool IsSetExecutionEndDateTime()
        {
            return this._executionEndDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartDateTime. 
        /// <para>
        /// The date and time the plugin started executing. Date and time are written in ISO 8601
        /// format. For example, June 7, 2017 is represented as 2017-06-7. The following sample
        /// AWS CLI command uses the <code>InvokedBefore</code> filter.
        /// </para>
        ///  
        /// <para>
        ///  <code>aws ssm list-commands --filters key=InvokedBefore,value=2017-06-07T00:00:00Z</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the plugin has not started to execute, the string is empty.
        /// </para>
        /// </summary>
        public string ExecutionStartDateTime
        {
            get { return this._executionStartDateTime; }
            set { this._executionStartDateTime = value; }
        }

        // Check to see if ExecutionStartDateTime property is set
        internal bool IsSetExecutionStartDateTime()
        {
            return this._executionStartDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed instance targeted by the command. A managed instance can be
        /// an Amazon EC2 instance or an instance in your hybrid environment that is configured
        /// for Systems Manager.
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
        /// Gets and sets the property PluginName. 
        /// <para>
        /// The name of the plugin for which you want detailed results. For example, aws:RunShellScript
        /// is a plugin.
        /// </para>
        /// </summary>
        public string PluginName
        {
            get { return this._pluginName; }
            set { this._pluginName = value; }
        }

        // Check to see if PluginName property is set
        internal bool IsSetPluginName()
        {
            return this._pluginName != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The error level response code for the plugin script. If the response code is -1, then
        /// the command has not started executing on the instance, or it was not received by the
        /// instance.
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
        /// Gets and sets the property StandardErrorContent. 
        /// <para>
        /// The first 8,000 characters written by the plugin to stderr. If the command has not
        /// finished executing, then this string is empty.
        /// </para>
        /// </summary>
        public string StandardErrorContent
        {
            get { return this._standardErrorContent; }
            set { this._standardErrorContent = value; }
        }

        // Check to see if StandardErrorContent property is set
        internal bool IsSetStandardErrorContent()
        {
            return this._standardErrorContent != null;
        }

        /// <summary>
        /// Gets and sets the property StandardErrorUrl. 
        /// <para>
        /// The URL for the complete text written by the plugin to stderr. If the command has
        /// not finished executing, then this string is empty.
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
        /// Gets and sets the property StandardOutputContent. 
        /// <para>
        /// The first 24,000 characters written by the plugin to stdout. If the command has not
        /// finished executing, if ExecutionStatus is neither Succeeded nor Failed, then this
        /// string is empty.
        /// </para>
        /// </summary>
        public string StandardOutputContent
        {
            get { return this._standardOutputContent; }
            set { this._standardOutputContent = value; }
        }

        // Check to see if StandardOutputContent property is set
        internal bool IsSetStandardOutputContent()
        {
            return this._standardOutputContent != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutputUrl. 
        /// <para>
        /// The URL for the complete text written by the plugin to stdout in Amazon S3. If an
        /// Amazon S3 bucket was not specified, then this string is empty.
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
        /// The status of this invocation plugin. This status can be different than StatusDetails.
        /// </para>
        /// </summary>
        public CommandInvocationStatus Status
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
        /// A detailed status of the command execution for an invocation. StatusDetails includes
        /// more information than Status because it includes states resulting from error and concurrency
        /// control parameters. StatusDetails can show different results than Status. For more
        /// information about these statuses, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-about-status.html">Run
        /// Command Status</a>. StatusDetails can be one of the following values:
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
        /// Delayed: The system attempted to send the command to the target, but the target was
        /// not available. The instance might not be available because of network issues, the
        /// instance was stopped, etc. The system will try to deliver the command again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The command or plugin was executed successfully. This is a terminal state.
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
        /// Execution Timed Out: The command started to execute on the instance, but the execution
        /// was not complete before the timeout expired. Execution timeouts count against the
        /// MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The command wasn't executed successfully on the instance. For a plugin, this
        /// indicates that the result code was not zero. For a command invocation, this indicates
        /// that the result code for one or more plugins was not zero. Invocation failures count
        /// against the MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Canceled: The command was terminated before it was completed. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Undeliverable: The command can't be delivered to the instance. The instance might
        /// not exist or might not be responding. Undeliverable invocations don't count against
        /// the parent command's MaxErrors limit and don't contribute to whether the parent command
        /// status is Success or Incomplete. This is a terminal state.
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