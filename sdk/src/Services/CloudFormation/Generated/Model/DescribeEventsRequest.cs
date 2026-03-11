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
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns CloudFormation events based on flexible query criteria. Groups events by operation
    /// ID, enabling you to focus on individual stack operations during deployment.
    /// 
    ///  
    /// <para>
    /// An operation is any action performed on a stack, including stack lifecycle actions
    /// (Create, Update, Delete, Rollback), change set creation, nested stack creation, and
    /// automatic rollbacks triggered by failures. Each operation has a unique identifier
    /// (Operation ID) and represents a discrete change attempt on the stack.
    /// </para>
    ///  
    /// <para>
    /// Returns different types of events including:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Progress events</b> - Status updates during stack operation execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Validation errors</b> - Failures from CloudFormation Early Validations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Provisioning errors</b> - Resource creation and update failures.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Hook invocation errors</b> - Failures from CloudFormation Hook during stack operations.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// One of <c>ChangeSetName</c>, <c>OperationId</c> or <c>StackName</c> must be specified
    /// as input.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonCloudFormationRequest
    {
        private string _changeSetName;
        private EventFilter _filters;
        private string _nextToken;
        private string _operationId;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the change set for which you want to retrieve
        /// events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to apply when retrieving events.
        /// </para>
        /// </summary>
        public EventFilter Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique identifier of the operation for which you want to retrieve events.
        /// </para>
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or unique stack ID for which you want to retrieve events.
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