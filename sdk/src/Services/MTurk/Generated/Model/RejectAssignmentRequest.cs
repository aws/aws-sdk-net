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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the RejectAssignment operation.
    /// The <c>RejectAssignment</c> operation rejects the results of a completed assignment.
    /// 
    /// 
    ///  
    /// <para>
    ///  You can include an optional feedback message with the rejection, which the Worker
    /// can see in the Status section of the web site. When you include a feedback message
    /// with the rejection, it helps the Worker understand why the assignment was rejected,
    /// and can improve the quality of the results the Worker submits in the future. 
    /// </para>
    ///  
    /// <para>
    ///  Only the Requester who created the HIT can reject an assignment for the HIT. 
    /// </para>
    /// </summary>
    public partial class RejectAssignmentRequest : AmazonMTurkRequest
    {
        private string _assignmentId;
        private string _requesterFeedback;

        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        ///  The ID of the assignment. The assignment must correspond to a HIT created by the
        /// Requester. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AssignmentId
        {
            get { return this._assignmentId; }
            set { this._assignmentId = value; }
        }

        // Check to see if AssignmentId property is set
        internal bool IsSetAssignmentId()
        {
            return this._assignmentId != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterFeedback. 
        /// <para>
        ///  A message for the Worker, which the Worker can see in the Status section of the web
        /// site. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequesterFeedback
        {
            get { return this._requesterFeedback; }
            set { this._requesterFeedback = value; }
        }

        // Check to see if RequesterFeedback property is set
        internal bool IsSetRequesterFeedback()
        {
            return this._requesterFeedback != null;
        }

    }
}