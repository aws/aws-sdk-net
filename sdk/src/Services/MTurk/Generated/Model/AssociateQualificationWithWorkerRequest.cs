/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateQualificationWithWorker operation.
    /// The <code>AssociateQualificationWithWorker</code> operation gives a Worker a Qualification.
    /// <code>AssociateQualificationWithWorker</code> does not require that the Worker submit
    /// a Qualification request. It gives the Qualification directly to the Worker. 
    /// 
    ///  
    /// <para>
    ///  You can only assign a Qualification of a Qualification type that you created (using
    /// the <code>CreateQualificationType</code> operation). 
    /// </para>
    ///  <note> 
    /// <para>
    ///  Note: <code>AssociateQualificationWithWorker</code> does not affect any pending Qualification
    /// requests for the Qualification by the Worker. If you assign a Qualification to a Worker,
    /// then later grant a Qualification request made by the Worker, the granting of the request
    /// may modify the Qualification score. To resolve a pending Qualification request without
    /// affecting the Qualification the Worker already has, reject the request with the <code>RejectQualificationRequest</code>
    /// operation. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateQualificationWithWorkerRequest : AmazonMTurkRequest
    {
        private int? _integerValue;
        private string _qualificationTypeId;
        private bool? _sendNotification;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// The value of the Qualification to assign.
        /// </para>
        /// </summary>
        public int IntegerValue
        {
            get { return this._integerValue.GetValueOrDefault(); }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        /// The ID of the Qualification type to use for the assigned Qualification.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SendNotification. 
        /// <para>
        ///  Specifies whether to send a notification email message to the Worker saying that
        /// the qualification was assigned to the Worker. Note: this is true by default. 
        /// </para>
        /// </summary>
        public bool SendNotification
        {
            get { return this._sendNotification.GetValueOrDefault(); }
            set { this._sendNotification = value; }
        }

        // Check to see if SendNotification property is set
        internal bool IsSetSendNotification()
        {
            return this._sendNotification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker to whom the Qualification is being assigned. Worker IDs are
        /// included with submitted HIT assignments and Qualification requests. 
        /// </para>
        /// </summary>
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