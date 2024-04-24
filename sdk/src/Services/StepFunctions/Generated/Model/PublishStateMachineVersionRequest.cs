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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the PublishStateMachineVersion operation.
    /// Creates a <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>
    /// from the current revision of a state machine. Use versions to create immutable snapshots
    /// of your state machine. You can start executions from versions either directly or with
    /// an alias. To create an alias, use <a>CreateStateMachineAlias</a>.
    /// 
    ///  
    /// <para>
    /// You can publish up to 1000 versions for each state machine. You must manually delete
    /// unused versions using the <a>DeleteStateMachineVersion</a> API action.
    /// </para>
    ///  
    /// <para>
    ///  <c>PublishStateMachineVersion</c> is an idempotent API. It doesn't create a duplicate
    /// state machine version if it already exists for the current revision. Step Functions
    /// bases <c>PublishStateMachineVersion</c>'s idempotency check on the <c>stateMachineArn</c>,
    /// <c>name</c>, and <c>revisionId</c> parameters. Requests with the same parameters return
    /// a successful idempotent response. If you don't specify a <c>revisionId</c>, Step Functions
    /// checks for a previously published version of the state machine's current revision.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteStateMachineVersion</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStateMachineVersions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PublishStateMachineVersionRequest : AmazonStepFunctionsRequest
    {
        private string _description;
        private string _revisionId;
        private string _stateMachineArn;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the state machine version.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Only publish the state machine version if the current state machine's revision ID
        /// matches the specified ID.
        /// </para>
        ///  
        /// <para>
        /// Use this option to avoid publishing a version if the state machine changed since you
        /// last updated it. If the specified revision ID doesn't match the state machine's current
        /// revision ID, the API returns <c>ConflictException</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To specify an initial revision ID for a state machine with no revision ID assigned,
        /// specify the string <c>INITIAL</c> for the <c>revisionId</c> parameter. For example,
        /// you can specify a <c>revisionID</c> of <c>INITIAL</c> when you create a state machine
        /// using the <a>CreateStateMachine</a> API action.
        /// </para>
        ///  </note>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StateMachineArn
        {
            get { return this._stateMachineArn; }
            set { this._stateMachineArn = value; }
        }

        // Check to see if StateMachineArn property is set
        internal bool IsSetStateMachineArn()
        {
            return this._stateMachineArn != null;
        }

    }
}