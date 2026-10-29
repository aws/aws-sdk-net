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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes plugin details.
    /// </summary>
    public partial class CommandPlugin
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the plugin. Must be one of the following: <c>aws:updateAgent</c>, <c>aws:domainjoin</c>,
        /// <c>aws:applications</c>, <c>aws:runPowerShellScript</c>, <c>aws:psmodule</c>, <c>aws:cloudWatch</c>,
        /// <c>aws:runShellScript</c>, or <c>aws:updateSSMAgent</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Output of the plugin execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public string Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

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
        [AWSProperty(Min = 3, Max = 63)]
        public string OutputS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3BucketName property is set.
        /// </summary>
        internal bool IsSetOutputS3BucketName() => this.OutputS3BucketName != null;

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
        [AWSProperty(Min = 0, Max = 500)]
        public string OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetOutputS3KeyPrefix() => this.OutputS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property OutputS3Region. 
        /// <para>
        /// (Deprecated) You can no longer specify this parameter. The system ignores it. Instead,
        /// Amazon Web Services Systems Manager automatically determines the S3 bucket region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20)]
        public string OutputS3Region { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Region property is set.
        /// </summary>
        internal bool IsSetOutputS3Region() => this.OutputS3Region != null;

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// A numeric response code generated after running the plugin. 
        /// </para>
        /// </summary>
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCode property is set.
        /// </summary>
        internal bool IsSetResponseCode() => this.ResponseCode.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseFinishDateTime. 
        /// <para>
        /// The time the plugin stopped running. Could stop prematurely if, for example, a cancel
        /// command was sent. 
        /// </para>
        /// </summary>
        public DateTime? ResponseFinishDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ResponseFinishDateTime property is set.
        /// </summary>
        internal bool IsSetResponseFinishDateTime() => this.ResponseFinishDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseStartDateTime. 
        /// <para>
        /// The time the plugin started running. 
        /// </para>
        /// </summary>
        public DateTime? ResponseStartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ResponseStartDateTime property is set.
        /// </summary>
        internal bool IsSetResponseStartDateTime() => this.ResponseStartDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StandardErrorUrl. 
        /// <para>
        /// The URL for the complete text written by the plugin to stderr. If execution isn't
        /// yet complete, then this string is empty.
        /// </para>
        /// </summary>
        public string StandardErrorUrl { get; set; }

        /// <summary>
        /// Checks to see if the StandardErrorUrl property is set.
        /// </summary>
        internal bool IsSetStandardErrorUrl() => this.StandardErrorUrl != null;

        /// <summary>
        /// Gets and sets the property StandardOutputUrl. 
        /// <para>
        /// The URL for the complete text written by the plugin to stdout in Amazon S3. If the
        /// S3 bucket for the command wasn't specified, then this string is empty.
        /// </para>
        /// </summary>
        public string StandardOutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the StandardOutputUrl property is set.
        /// </summary>
        internal bool IsSetStandardOutputUrl() => this.StandardOutputUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this plugin. You can run a document with multiple plugins.
        /// </para>
        /// </summary>
        public CommandPluginStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        [AWSProperty(Min = 0, Max = 100)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;
    }
}
