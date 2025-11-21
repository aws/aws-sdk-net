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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ContinueUpdateRollback operation.
    /// Continues rolling back a stack from <c>UPDATE_ROLLBACK_FAILED</c> to <c>UPDATE_ROLLBACK_COMPLETE</c>
    /// state. Depending on the cause of the failure, you can manually fix the error and continue
    /// the rollback. By continuing the rollback, you can return your stack to a working state
    /// (the <c>UPDATE_ROLLBACK_COMPLETE</c> state) and then try to update the stack again.
    /// 
    ///  
    /// <para>
    /// A stack enters the <c>UPDATE_ROLLBACK_FAILED</c> state when CloudFormation can't roll
    /// back all changes after a failed stack update. For example, this might occur when a
    /// stack attempts to roll back to an old database that was deleted outside of CloudFormation.
    /// Because CloudFormation doesn't know the instance was deleted, it assumes the instance
    /// still exists and attempts to roll back to it, causing the update rollback to fail.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-continueupdaterollback.html">Continue
    /// rolling back an update</a> in the <i>CloudFormation User Guide</i>. For information
    /// for troubleshooting a failed update rollback, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">Update
    /// rollback failed</a>.
    /// </para>
    /// </summary>
    public partial class ContinueUpdateRollbackRequest : AmazonCloudFormationRequest
    {
        private string _clientRequestToken;
        private List<string> _resourcesToSkip = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleARN;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <c>ContinueUpdateRollback</c> request. Specify this token
        /// if you plan to retry requests so that CloudFormation knows that you're not attempting
        /// to continue the rollback to a stack with the same name. You might retry <c>ContinueUpdateRollback</c>
        /// requests to ensure that CloudFormation successfully received them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcesToSkip. 
        /// <para>
        /// A list of the logical IDs of the resources that CloudFormation skips during the continue
        /// update rollback operation. You can specify only resources that are in the <c>UPDATE_FAILED</c>
        /// state because a rollback failed. You can't specify resources that are in the <c>UPDATE_FAILED</c>
        /// state for other reasons, for example, because an update was canceled. To check why
        /// a resource update failed, use the <a>DescribeStackResources</a> action, and view the
        /// resource status reason.
        /// </para>
        ///  <important> 
        /// <para>
        /// Specify this property to skip rolling back resources that CloudFormation can't successfully
        /// roll back. We recommend that you <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// troubleshoot</a> resources before skipping them. CloudFormation sets the status of
        /// the specified resources to <c>UPDATE_COMPLETE</c> and continues to roll back the stack.
        /// After the rollback is complete, the state of the skipped resources will be inconsistent
        /// with the state of the resources in the stack template. Before performing another stack
        /// update, you must update the stack or resources to be consistent with each other. If
        /// you don't, subsequent stack updates might fail, and the stack will become unrecoverable.
        /// </para>
        ///  </important> 
        /// <para>
        /// Specify the minimum number of resources required to successfully roll back your stack.
        /// For example, a failed resource update might cause dependent resources to fail. In
        /// this case, it might not be necessary to skip the dependent resources.
        /// </para>
        ///  
        /// <para>
        /// To skip resources that are part of nested stacks, use the following format: <c>NestedStackName.ResourceLogicalID</c>.
        /// If you want to specify the logical ID of a stack resource (<c>Type: AWS::CloudFormation::Stack</c>)
        /// in the <c>ResourcesToSkip</c> list, then its corresponding embedded stack must be
        /// in one of the following states: <c>DELETE_IN_PROGRESS</c>, <c>DELETE_COMPLETE</c>,
        /// or <c>DELETE_FAILED</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't confuse a child stack's name with its corresponding logical ID defined in the
        /// parent stack. For an example of a continue update rollback operation with nested stacks,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-continueupdaterollback.html#nested-stacks">Continue
        /// rolling back from failed nested stack updates</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourcesToSkip
        {
            get { return this._resourcesToSkip; }
            set { this._resourcesToSkip = value; }
        }

        // Check to see if ResourcesToSkip property is set
        internal bool IsSetResourcesToSkip()
        {
            return this._resourcesToSkip != null && (this._resourcesToSkip.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that CloudFormation assumes to roll
        /// back the stack. CloudFormation uses the role's credentials to make calls on your behalf.
        /// CloudFormation always uses this role for all future operations on the stack. Provided
        /// that users have permission to operate on the stack, CloudFormation uses this role
        /// even if the users don't have permission to pass it. Ensure that the role grants least
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, CloudFormation uses the role that was previously associated
        /// with the stack. If no role is available, CloudFormation uses a temporary session that's
        /// generated from your user credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the unique ID of the stack that you want to continue rolling back.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't specify the name of a nested stack (a stack that was created by using the <c>AWS::CloudFormation::Stack</c>
        /// resource). Instead, use this operation on the parent stack (the stack that contains
        /// the <c>AWS::CloudFormation::Stack</c> resource).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}