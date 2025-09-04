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
    /// Container for the parameters to the ListHookResults operation.
    /// Returns summaries of invoked Hooks. For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/hooks-view-invocations.html">View
    /// CloudFormation Hooks invocations</a> in the <i>CloudFormation Hooks User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation supports the following parameter combinations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// No parameters: Returns all Hook invocation summaries.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TypeArn</c> only: Returns summaries for a specific Hook.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TypeArn</c> and <c>Status</c>: Returns summaries for a specific Hook filtered
    /// by status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TargetId</c> and <c>TargetType</c>: Returns summaries for a specific Hook invocation
    /// target.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListHookResultsRequest : AmazonCloudFormationRequest
    {
        private string _nextToken;
        private HookStatus _status;
        private string _targetId;
        private ListHookResultsTargetType _targetType;
        private string _typeArn;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string that identifies the next page of events that you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters results by the status of Hook invocations. Can only be used in combination
        /// with <c>TypeArn</c>. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOOK_IN_PROGRESS</c>: The Hook is currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_SUCCEEDED</c>: The Hook completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_FAILED</c>: The Hook completed but failed validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_FAILED</c>: The Hook encountered an error during execution.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HookStatus Status
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
        /// Gets and sets the property TargetId. 
        /// <para>
        /// Filters results by the unique identifier of the target the Hook was invoked against.
        /// </para>
        ///  
        /// <para>
        /// For change sets, this is the change set ARN. When the target is a Cloud Control API
        /// operation, this value must be the <c>HookRequestToken</c> returned by the Cloud Control
        /// API request. For more information on the <c>HookRequestToken</c>, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_ProgressEvent.html">ProgressEvent</a>.
        /// </para>
        ///  
        /// <para>
        /// Required when <c>TargetType</c> is specified and cannot be used otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// Filters results by target type. Currently, only <c>CHANGE_SET</c> and <c>CLOUD_CONTROL</c>
        /// are supported filter options.
        /// </para>
        ///  
        /// <para>
        /// Required when <c>TargetId</c> is specified and cannot be used otherwise.
        /// </para>
        /// </summary>
        public ListHookResultsTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// Filters results by the ARN of the Hook. Can be used alone or in combination with <c>Status</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeArn
        {
            get { return this._typeArn; }
            set { this._typeArn = value; }
        }

        // Check to see if TypeArn property is set
        internal bool IsSetTypeArn()
        {
            return this._typeArn != null;
        }

    }
}