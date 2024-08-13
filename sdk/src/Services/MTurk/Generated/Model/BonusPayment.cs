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
    /// An object representing a Bonus payment paid to a Worker.
    /// </summary>
    public partial class BonusPayment
    {
        private string _assignmentId;
        private string _bonusAmount;
        private DateTime? _grantTime;
        private string _reason;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        /// The ID of the assignment associated with this bonus payment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property BonusAmount.
        /// </summary>
        public string BonusAmount
        {
            get { return this._bonusAmount; }
            set { this._bonusAmount = value; }
        }

        // Check to see if BonusAmount property is set
        internal bool IsSetBonusAmount()
        {
            return this._bonusAmount != null;
        }

        /// <summary>
        /// Gets and sets the property GrantTime. 
        /// <para>
        /// The date and time of when the bonus was granted.
        /// </para>
        /// </summary>
        public DateTime? GrantTime
        {
            get { return this._grantTime; }
            set { this._grantTime = value; }
        }

        // Check to see if GrantTime property is set
        internal bool IsSetGrantTime()
        {
            return this._grantTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The Reason text given when the bonus was granted, if any.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The ID of the Worker to whom the bonus was paid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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