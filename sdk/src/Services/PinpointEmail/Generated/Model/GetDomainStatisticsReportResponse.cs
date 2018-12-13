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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that includes statistics that are related to the domain that you specified.
    /// </summary>
    public partial class GetDomainStatisticsReportResponse : AmazonWebServiceResponse
    {
        private List<DailyVolume> _dailyVolumes = new List<DailyVolume>();
        private OverallVolume _overallVolume;

        /// <summary>
        /// Gets and sets the property DailyVolumes. 
        /// <para>
        /// An object that contains deliverability metrics for the domain that you specified.
        /// This object contains data for each day, starting on the <code>StartDate</code> and
        /// ending on the <code>EndDate</code>.
        /// </para>
        /// </summary>
        public List<DailyVolume> DailyVolumes
        {
            get { return this._dailyVolumes; }
            set { this._dailyVolumes = value; }
        }

        // Check to see if DailyVolumes property is set
        internal bool IsSetDailyVolumes()
        {
            return this._dailyVolumes != null && this._dailyVolumes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OverallVolume. 
        /// <para>
        /// An object that contains deliverability metrics for the domain that you specified.
        /// The data in this object is a summary of all of the data that was collected from the
        /// <code>StartDate</code> to the <code>EndDate</code>.
        /// </para>
        /// </summary>
        public OverallVolume OverallVolume
        {
            get { return this._overallVolume; }
            set { this._overallVolume = value; }
        }

        // Check to see if OverallVolume property is set
        internal bool IsSetOverallVolume()
        {
            return this._overallVolume != null;
        }

    }
}