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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Details specific to start service period handshakes.
    /// </summary>
    public partial class StartServicePeriodHandshakeDetail
    {
        private DateTime? _endDate;
        private string _minimumNoticeDays;
        private string _note;
        private ServicePeriodType _servicePeriodType;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the service period.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumNoticeDays. 
        /// <para>
        /// The minimum number of days notice required for changes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string MinimumNoticeDays
        {
            get { return this._minimumNoticeDays; }
            set { this._minimumNoticeDays = value; }
        }

        // Check to see if MinimumNoticeDays property is set
        internal bool IsSetMinimumNoticeDays()
        {
            return this._minimumNoticeDays != null;
        }

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A note providing additional information about the service period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePeriodType. 
        /// <para>
        /// The type of service period being started.
        /// </para>
        /// </summary>
        public ServicePeriodType ServicePeriodType
        {
            get { return this._servicePeriodType; }
            set { this._servicePeriodType = value; }
        }

        // Check to see if ServicePeriodType property is set
        internal bool IsSetServicePeriodType()
        {
            return this._servicePeriodType != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the service period.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}