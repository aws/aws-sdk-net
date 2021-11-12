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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganizationOverview operation.
    /// Returns an overview of your organization's history based on the specified time range.
    /// The overview includes the total reactive and proactive insights.
    /// </summary>
    public partial class DescribeOrganizationOverviewRequest : AmazonDevOpsGuruRequest
    {
        private List<string> _accountIds = new List<string>();
        private DateTime? _fromTime;
        private List<string> _organizationalUnitIds = new List<string>();
        private DateTime? _toTime;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The ID of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FromTime. 
        /// <para>
        ///  The start of the time range passed in. The start time granularity is at the day level.
        /// The floor of the start time is used. Returned information occurred after this day.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime FromTime
        {
            get { return this._fromTime.GetValueOrDefault(); }
            set { this._fromTime = value; }
        }

        // Check to see if FromTime property is set
        internal bool IsSetFromTime()
        {
            return this._fromTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// The ID of the organizational unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> OrganizationalUnitIds
        {
            get { return this._organizationalUnitIds; }
            set { this._organizationalUnitIds = value; }
        }

        // Check to see if OrganizationalUnitIds property is set
        internal bool IsSetOrganizationalUnitIds()
        {
            return this._organizationalUnitIds != null && this._organizationalUnitIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ToTime. 
        /// <para>
        ///  The end of the time range passed in. The start time granularity is at the day level.
        /// The floor of the start time is used. Returned information occurred before this day.
        /// If this is not specified, then the current day is used. 
        /// </para>
        /// </summary>
        public DateTime ToTime
        {
            get { return this._toTime.GetValueOrDefault(); }
            set { this._toTime = value; }
        }

        // Check to see if ToTime property is set
        internal bool IsSetToTime()
        {
            return this._toTime.HasValue; 
        }

    }
}