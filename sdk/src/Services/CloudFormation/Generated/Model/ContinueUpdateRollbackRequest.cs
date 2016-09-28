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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ContinueUpdateRollback operation.
    /// For a specified stack that is in the <code>UPDATE_ROLLBACK_FAILED</code> state, continues
    /// rolling it back to the <code>UPDATE_ROLLBACK_COMPLETE</code> state. Depending on the
    /// cause of the failure, you can manually <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
    /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
    /// your stack to a working state (the <code>UPDATE_ROLLBACK_COMPLETE</code> state), and
    /// then try to update the stack again.
    /// 
    ///  
    /// <para>
    /// A stack goes into the <code>UPDATE_ROLLBACK_FAILED</code> state when AWS CloudFormation
    /// cannot roll back all changes after a failed stack update. For example, you might have
    /// a stack that is rolling back to an old database instance that was deleted outside
    /// of AWS CloudFormation. Because AWS CloudFormation doesn't know the database was deleted,
    /// it assumes that the database instance still exists and attempts to roll back to it,
    /// causing the update rollback to fail.
    /// </para>
    /// </summary>
    public partial class ContinueUpdateRollbackRequest : AmazonCloudFormationRequest
    {
        private string _roleARN;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role
        /// that AWS CloudFormation assumes to roll back the stack. AWS CloudFormation uses the
        /// role's credentials to make calls on your behalf. AWS CloudFormation always uses this
        /// role for all future operations on the stack. As long as users have permission to operate
        /// on the stack, AWS CloudFormation uses this role even if the users don't have permission
        /// to pass it. Ensure that the role grants least privilege.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, AWS CloudFormation uses the role that was previously
        /// associated with the stack. If no role is available, AWS CloudFormation uses a temporary
        /// session that is generated from your user credentials.
        /// </para>
        /// </summary>
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
        /// </summary>
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