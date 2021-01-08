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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteChangeSet operation.
    /// Updates a stack using the input information that was provided when the specified change
    /// set was created. After the call successfully completes, AWS CloudFormation starts
    /// updating the stack. Use the <a>DescribeStacks</a> action to view the status of the
    /// update.
    /// 
    ///  
    /// <para>
    /// When you execute a change set, AWS CloudFormation deletes all other change sets associated
    /// with the stack because they aren't valid for the updated stack.
    /// </para>
    ///  
    /// <para>
    /// If a stack policy is associated with the stack, AWS CloudFormation enforces the policy
    /// during the update. You can't specify a temporary stack policy that overrides the current
    /// policy.
    /// </para>
    ///  
    /// <para>
    /// To create a change set for the entire stack hierachy, <code>IncludeNestedStacks</code>
    /// must have been set to <code>True</code>.
    /// </para>
    /// </summary>
    public partial class ExecuteChangeSetRequest : AmazonCloudFormationRequest
    {
        private string _changeSetName;
        private string _clientRequestToken;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name or ARN of the change set that you want use to update the specified stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <code>ExecuteChangeSet</code> request. Specify this token
        /// if you plan to retry requests so that AWS CloudFormation knows that you're not attempting
        /// to execute a change set to update a stack with the same name. You might retry <code>ExecuteChangeSet</code>
        /// requests to ensure that AWS CloudFormation successfully received them.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// If you specified the name of a change set, specify the stack name or ID (ARN) that
        /// is associated with the change set you want to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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