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
    /// Container for the parameters to the DeleteStack operation.
    /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
    /// Deleted stacks do not show up in the <a>DescribeStacks</a> API if the deletion has
    /// been completed successfully.
    /// </summary>
    public partial class DeleteStackRequest : AmazonCloudFormationRequest
    {
        private List<string> _retainResources = new List<string>();
        private string _roleARN;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property RetainResources. 
        /// <para>
        /// For stacks in the <code>DELETE_FAILED</code> state, a list of resource logical IDs
        /// that are associated with the resources you want to retain. During deletion, AWS CloudFormation
        /// deletes the stack but does not delete the retained resources.
        /// </para>
        ///  
        /// <para>
        /// Retaining resources is useful when you cannot delete a resource, such as a non-empty
        /// S3 bucket, but you want to delete the stack.
        /// </para>
        /// </summary>
        public List<string> RetainResources
        {
            get { return this._retainResources; }
            set { this._retainResources = value; }
        }

        // Check to see if RetainResources property is set
        internal bool IsSetRetainResources()
        {
            return this._retainResources != null && this._retainResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role
        /// that AWS CloudFormation assumes to delete the stack. AWS CloudFormation uses the role's
        /// credentials to make calls on your behalf.
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
        /// The name or the unique stack ID that is associated with the stack.
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