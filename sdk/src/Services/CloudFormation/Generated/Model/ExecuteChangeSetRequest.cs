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
    /// Container for the parameters to the ExecuteChangeSet operation.
    /// Updates a stack using the input information that was provided when the specified change
    /// set was created. After the call successfully completes, CloudFormation starts updating
    /// the stack. Use the <a>DescribeStacks</a> action to view the status of the update.
    /// 
    ///  
    /// <para>
    /// When you execute a change set, CloudFormation deletes all other change sets associated
    /// with the stack because they aren't valid for the updated stack.
    /// </para>
    ///  
    /// <para>
    /// If a stack policy is associated with the stack, CloudFormation enforces the policy
    /// during the update. You can't specify a temporary stack policy that overrides the current
    /// policy.
    /// </para>
    ///  
    /// <para>
    /// To create a change set for the entire stack hierarchy, <c>IncludeNestedStacks</c>
    /// must have been set to <c>True</c>.
    /// </para>
    /// </summary>
    public partial class ExecuteChangeSetRequest : AmazonCloudFormationRequest
    {
        private string _changeSetName;
        private string _clientRequestToken;
        private bool? _disableRollback;
        private bool? _retainExceptOnCreate;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the change set that you want use to update
        /// the specified stack.
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
        /// A unique identifier for this <c>ExecuteChangeSet</c> request. Specify this token if
        /// you plan to retry requests so that CloudFormation knows that you're not attempting
        /// to execute a change set to update a stack with the same name. You might retry <c>ExecuteChangeSet</c>
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
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Preserves the state of previously provisioned resources when an operation fails. This
        /// parameter can't be specified when the <c>OnStackFailure</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateChangeSet.html">CreateChangeSet</a>
        /// API operation was specified.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>True</c> - if the stack creation fails, do nothing. This is equivalent to specifying
        /// <c>DO_NOTHING</c> for the <c>OnStackFailure</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateChangeSet.html">CreateChangeSet</a>
        /// API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>False</c> - if the stack creation fails, roll back the stack. This is equivalent
        /// to specifying <c>ROLLBACK</c> for the <c>OnStackFailure</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateChangeSet.html">CreateChangeSet</a>
        /// API operation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>True</c> 
        /// </para>
        /// </summary>
        public bool? DisableRollback
        {
            get { return this._disableRollback; }
            set { this._disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this._disableRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetainExceptOnCreate. 
        /// <para>
        /// When set to <c>true</c>, newly created resources are deleted when the operation rolls
        /// back. This includes newly created resources marked with a deletion policy of <c>Retain</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? RetainExceptOnCreate
        {
            get { return this._retainExceptOnCreate; }
            set { this._retainExceptOnCreate = value; }
        }

        // Check to see if RetainExceptOnCreate property is set
        internal bool IsSetRetainExceptOnCreate()
        {
            return this._retainExceptOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// If you specified the name of a change set, specify the stack name or Amazon Resource
        /// Name (ARN) that's associated with the change set you want to execute.
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