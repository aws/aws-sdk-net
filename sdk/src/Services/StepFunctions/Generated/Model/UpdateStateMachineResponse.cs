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
    /// This is the response object from the UpdateStateMachine operation.
    /// </summary>
    public partial class UpdateStateMachineResponse : AmazonWebServiceResponse
    {
        private string _revisionId;
        private string _stateMachineVersionArn;
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision identifier for the updated state machine.
        /// </para>
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
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the published state machine version.
        /// </para>
        ///  
        /// <para>
        /// If the <c>publish</c> parameter isn't set to <c>true</c>, this field returns null.
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

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The date and time the state machine was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateDate
        {
            get { return this._updateDate; }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}