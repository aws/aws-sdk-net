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
    /// This is the response object from the CreateStateMachine operation.
    /// </summary>
    public partial class CreateStateMachineResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private string _stateMachineArn;
        private string _stateMachineVersionArn;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the state machine is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the created state machine.
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

        /// <summary>
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the created state machine version.
        /// If you do not set the <c>publish</c> parameter to <c>true</c>, this field returns
        /// null value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateMachineVersionArn
        {
            get { return this._stateMachineVersionArn; }
            set { this._stateMachineVersionArn = value; }
        }

        // Check to see if StateMachineVersionArn property is set
        internal bool IsSetStateMachineVersionArn()
        {
            return this._stateMachineVersionArn != null;
        }

    }
}