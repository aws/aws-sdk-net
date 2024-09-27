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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        /// The name of the plugin. Must be one of the following: <c>aws:updateAgent</c>, <c>aws:domainjoin</c>,
        /// <c>aws:applications</c>, <c>aws:runPowerShellScript</c>, <c>aws:psmodule</c>, <c>aws:cloudWatch</c>,
        /// <c>aws:runShellScript</c>, or <c>aws:updateSSMAgent</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4)]
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
        [AWSProperty(Max=2500)]
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
        ///  <c>amzn-s3-demo-bucket/my-prefix/i-02573cafcfEXAMPLE/awsrunShellScript</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>amzn-s3-demo-bucket</c> is the name of the S3 bucket;
        /// </para>
        ///  
        /// <para>
        ///  <c>my-prefix</c> is the name of the S3 prefix;
        /// </para>
        ///  
        /// <para>
        ///  <c>i-02573cafcfEXAMPLE</c> is the managed node ID;
        /// </para>
        ///  
        /// <para>
        ///  <c>awsrunShellScript</c> is the name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        ///  <c>amzn-s3-demo-bucket/my-prefix/i-02573cafcfEXAMPLE/awsrunShellScript</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>amzn-s3-demo-bucket</c> is the name of the S3 bucket;
        /// </para>
        ///  
        /// <para>
        ///  <c>my-prefix</c> is the name of the S3 prefix;
        /// </para>
        ///  
        /// <para>
        ///  <c>i-02573cafcfEXAMPLE</c> is the managed node ID;
        /// </para>
        ///  
        /// <para>
        ///  <c>awsrunShellScript</c> is the name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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
        /// Amazon Web Services Systems Manager automatically determines the S3 bucket region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20)]
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
        /// A numeric response code generated after running the plugin. 
        /// </para>
        /// </summary>
        public int? ResponseCode
        {
            get { return this._responseCode; }
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
        /// The time the plugin stopped running. Could stop prematurely if, for example, a cancel
        /// command was sent. 
        /// </para>
        /// </summary>
        public DateTime? ResponseFinishDateTime
        {
            get { return this._responseFinishDateTime; }
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
        /// The time the plugin started running. 
        /// </para>
        /// </summary>
        public DateTime? ResponseStartDateTime
        {
            get { return this._responseStartDateTime; }
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
        /// The URL for the complete text written by the plugin to stderr. If execution isn't
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
        /// S3 bucket for the command wasn't specified, then this string is empty.
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
        /// The status of this plugin. You can run a document with multiple plugins.
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
        /// A detailed status of the plugin execution. <c>StatusDetails</c> includes more information
        /// than Status because it includes states resulting from error and concurrency control
        /// parameters. StatusDetails can show different results than Status. For more information
        /// about these statuses, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html">Understanding
        /// command statuses</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// StatusDetails can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The command hasn't been sent to the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The command has been sent to the managed node but hasn't reached a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The execution of the command or plugin was successfully completed. This is
        /// a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery Timed Out: The command wasn't delivered to the managed node before the delivery
        /// timeout expired. Delivery timeouts don't count against the parent command's <c>MaxErrors</c>
        /// limit, but they do contribute to whether the parent command status is Success or Incomplete.
        /// This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Execution Timed Out: Command execution started on the managed node, but the execution
        /// wasn't complete before the execution timeout expired. Execution timeouts count against
        /// the <c>MaxErrors</c> limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The command wasn't successful on the managed node. For a plugin, this indicates
        /// that the result code wasn't zero. For a command invocation, this indicates that the
        /// result code for one or more plugins wasn't zero. Invocation failures count against
        /// the MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cancelled: The command was terminated before it was completed. This is a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Undeliverable: The command can't be delivered to the managed node. The managed node
        /// might not exist, or it might not be responding. Undeliverable invocations don't count
        /// against the parent command's MaxErrors limit, and they don't contribute to whether
        /// the parent command status is Success or Incomplete. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Terminated: The parent command exceeded its MaxErrors limit and subsequent command
        /// invocations were canceled by the system. This is a terminal state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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