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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeRoot operation.
    /// Returns a set of short term credentials you can use to perform privileged tasks on
    /// a member account in your organization.
    /// 
    ///  
    /// <para>
    /// Before you can launch a privileged session, you must have centralized root access
    /// in your organization. For steps to enable this feature, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-enable-root-access.html">Centralize
    /// root access for member accounts</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The STS global endpoint is not supported for AssumeRoot. You must send this request
    /// to a Regional STS endpoint. For more information, see <a href="https://docs.aws.amazon.com/STS/latest/APIReference/welcome.html#sts-endpoints">Endpoints</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can track AssumeRoot in CloudTrail logs to determine what actions were performed
    /// in a session. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-track-privileged-tasks.html">Track
    /// privileged tasks in CloudTrail</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssumeRootRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _targetPrincipal;
        private PolicyDescriptorType _taskPolicyArn;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, of the privileged session. The value can range from 0 seconds
        /// up to the maximum session duration of 900 seconds (15 minutes). If you specify a value
        /// higher than this setting, the operation fails.
        /// </para>
        ///  
        /// <para>
        /// By default, the value is set to <c>900</c> seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=900)]
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetPrincipal. 
        /// <para>
        /// The member account principal ARN or account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=2048)]
        public string TargetPrincipal
        {
            get { return this._targetPrincipal; }
            set { this._targetPrincipal = value; }
        }

        // Check to see if TargetPrincipal property is set
        internal bool IsSetTargetPrincipal()
        {
            return this._targetPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property TaskPolicyArn. 
        /// <para>
        /// The identity based policy that scopes the session to the privileged tasks that can
        /// be performed. You can use one of following Amazon Web Services managed policies to
        /// scope root session actions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/security-iam-awsmanpol.html#security-iam-awsmanpol-IAMAuditRootUserCredentials">IAMAuditRootUserCredentials</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/security-iam-awsmanpol.html#security-iam-awsmanpol-IAMCreateRootUserPassword">IAMCreateRootUserPassword</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/security-iam-awsmanpol.html#security-iam-awsmanpol-IAMDeleteRootUserCredentials">IAMDeleteRootUserCredentials</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/security-iam-awsmanpol.html#security-iam-awsmanpol-S3UnlockBucketPolicy">S3UnlockBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/security-iam-awsmanpol.html#security-iam-awsmanpol-SQSUnlockQueuePolicy">SQSUnlockQueuePolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyDescriptorType TaskPolicyArn
        {
            get { return this._taskPolicyArn; }
            set { this._taskPolicyArn = value; }
        }

        // Check to see if TaskPolicyArn property is set
        internal bool IsSetTaskPolicyArn()
        {
            return this._taskPolicyArn != null;
        }

    }
}