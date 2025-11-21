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
    /// Container for the parameters to the StopStackSetOperation operation.
    /// Stops an in-progress operation on a StackSet and its associated stack instances. StackSets
    /// will cancel all the unstarted stack instance deployments and wait for those are in-progress
    /// to complete.
    /// </summary>
    public partial class StopStackSetOperationRequest : AmazonCloudFormationRequest
    {
        private CallAs _callAs;
        private string _operationId;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// Specifies whether you are acting as an account administrator in the organization's
        /// management account or as a delegated administrator in a member account. Valid only
        /// if the StackSet uses service-managed permissions.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The ID of the stack operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the StackSet that you want to stop the operation for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

    }
}