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
    /// Container for the parameters to the RollbackStack operation.
    /// When specifying <c>RollbackStack</c>, you preserve the state of previously provisioned
    /// resources when an operation fails. You can check the status of the stack through the
    /// <a>DescribeStacks</a> operation.
    /// 
    ///  
    /// <para>
    /// Rolls back the specified stack to the last known stable state from <c>CREATE_FAILED</c>
    /// or <c>UPDATE_FAILED</c> stack statuses.
    /// </para>
    ///  
    /// <para>
    /// This operation will delete a stack if it doesn't contain a last known stable state.
    /// A last known stable state includes any status in a <c>*_COMPLETE</c>. This includes
    /// the following stack statuses.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CREATE_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UPDATE_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UPDATE_ROLLBACK_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>IMPORT_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>IMPORT_ROLLBACK_COMPLETE</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RollbackStackRequest : AmazonCloudFormationRequest
    {
        private string _clientRequestToken;
        private bool? _retainExceptOnCreate;
        private string _roleARN;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <c>RollbackStack</c> request.
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
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that CloudFormation assumes to rollback
        /// the stack.
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
        /// The name that's associated with the stack.
        /// </para>
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