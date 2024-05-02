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
    /// Container for the parameters to the GetQualificationScore operation.
    /// The <c>GetQualificationScore</c> operation returns the value of a Worker's Qualification
    /// for a given Qualification type. 
    /// 
    ///  
    /// <para>
    ///  To get a Worker's Qualification, you must know the Worker's ID. The Worker's ID is
    /// included in the assignment data returned by the <c>ListAssignmentsForHIT</c> operation.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Only the owner of a Qualification type can query the value of a Worker's Qualification
    /// of that type.
    /// </para>
    /// </summary>
    public partial class GetQualificationScoreRequest : AmazonMTurkRequest
    {
        private string _qualificationTypeId;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        /// The ID of the QualificationType.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string QualificationTypeId
        {
            get { return this._qualificationTypeId; }
            set { this._qualificationTypeId = value; }
        }

        // Check to see if QualificationTypeId property is set
        internal bool IsSetQualificationTypeId()
        {
            return this._qualificationTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The ID of the Worker whose Qualification is being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

    }
}