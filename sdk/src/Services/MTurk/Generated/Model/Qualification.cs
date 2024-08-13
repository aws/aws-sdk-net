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
    /// The Qualification data structure represents a Qualification assigned to a user, including
    /// the Qualification type and the value (score).
    /// </summary>
    public partial class Qualification
    {
        private DateTime? _grantTime;
        private int? _integerValue;
        private Locale _localeValue;
        private string _qualificationTypeId;
        private QualificationStatus _status;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property GrantTime. 
        /// <para>
        ///  The date and time the Qualification was granted to the Worker. If the Worker's Qualification
        /// was revoked, and then re-granted based on a new Qualification request, GrantTime is
        /// the date and time of the last call to the AcceptQualificationRequest operation.
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
        /// Gets and sets the property IntegerValue. 
        /// <para>
        ///  The value (score) of the Qualification, if the Qualification has an integer value.
        /// </para>
        /// </summary>
        public int? IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocaleValue.
        /// </summary>
        public Locale LocaleValue
        {
            get { return this._localeValue; }
            set { this._localeValue = value; }
        }

        // Check to see if LocaleValue property is set
        internal bool IsSetLocaleValue()
        {
            return this._localeValue != null;
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        ///  The ID of the Qualification type for the Qualification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the Qualification. Valid values are Granted | Revoked.
        /// </para>
        /// </summary>
        public QualificationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker who possesses the Qualification. 
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