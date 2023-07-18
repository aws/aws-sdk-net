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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStateMachine operation.
    /// Provides information about a state machine's definition, its IAM role Amazon Resource
    /// Name (ARN), and configuration.
    /// 
    ///  
    /// <para>
    /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
    /// within a state machine, a version ARN, or an alias ARN.
    /// </para>
    ///  
    /// <para>
    /// The following are some examples of qualified and unqualified state machine ARNs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
    /// with a label <code>mapStateLabel</code> in a state machine named <code>myStateMachine</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</code>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
    /// the request fails with <code>ValidationException</code>.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The following qualified state machine ARN refers to an alias named <code>PROD</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</code>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
    /// ARN, the request starts execution for that version or alias.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The following unqualified state machine ARN refers to a state machine named <code>myStateMachine</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</code>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This API action returns the details for a state machine version if the <code>stateMachineArn</code>
    /// you specify is a state machine version ARN.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is eventually consistent. The results are best effort and may not reflect
    /// very recent updates and changes.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeStateMachineRequest : AmazonStepFunctionsRequest
    {
        private string _stateMachineArn;

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine for which you want the information.
        /// </para>
        ///  
        /// <para>
        /// If you specify a state machine version ARN, this API returns details about that version.
        /// The version ARN is a combination of state machine ARN and the version number separated
        /// by a colon (:). For example, <code>stateMachineARN:1</code>.
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