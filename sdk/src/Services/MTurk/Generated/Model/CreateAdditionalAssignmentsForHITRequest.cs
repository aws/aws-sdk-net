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
    /// Container for the parameters to the CreateAdditionalAssignmentsForHIT operation.
    /// The <c>CreateAdditionalAssignmentsForHIT</c> operation increases the maximum number
    /// of assignments of an existing HIT. 
    /// 
    ///  
    /// <para>
    ///  To extend the maximum number of assignments, specify the number of additional assignments.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// HITs created with fewer than 10 assignments cannot be extended to have 10 or more
    /// assignments. Attempting to add assignments in a way that brings the total number of
    /// assignments for a HIT from fewer than 10 assignments to 10 or more assignments will
    /// result in an <c>AWS.MechanicalTurk.InvalidMaximumAssignmentsIncrease</c> exception.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HITs that were created before July 22, 2015 cannot be extended. Attempting to extend
    /// HITs that were created before July 22, 2015 will result in an <c>AWS.MechanicalTurk.HITTooOldForExtension</c>
    /// exception. 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateAdditionalAssignmentsForHITRequest : AmazonMTurkRequest
    {
        private string _hitId;
        private int? _numberOfAdditionalAssignments;
        private string _uniqueRequestToken;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The ID of the HIT to extend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfAdditionalAssignments. 
        /// <para>
        /// The number of additional assignments to request for this HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? NumberOfAdditionalAssignments
        {
            get { return this._numberOfAdditionalAssignments; }
            set { this._numberOfAdditionalAssignments = value; }
        }

        // Check to see if NumberOfAdditionalAssignments property is set
        internal bool IsSetNumberOfAdditionalAssignments()
        {
            return this._numberOfAdditionalAssignments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UniqueRequestToken. 
        /// <para>
        ///  A unique identifier for this request, which allows you to retry the call on error
        /// without extending the HIT multiple times. This is useful in cases such as network
        /// timeouts where it is unclear whether or not the call succeeded on the server. If the
        /// extend HIT already exists in the system from a previous call using the same <c>UniqueRequestToken</c>,
        /// subsequent calls will return an error with a message containing the request ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string UniqueRequestToken
        {
            get { return this._uniqueRequestToken; }
            set { this._uniqueRequestToken = value; }
        }

        // Check to see if UniqueRequestToken property is set
        internal bool IsSetUniqueRequestToken()
        {
            return this._uniqueRequestToken != null;
        }

    }
}