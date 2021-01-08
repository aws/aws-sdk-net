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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the ListBusinessReportSchedules operation.
    /// </summary>
    public partial class ListBusinessReportSchedulesResponse : AmazonWebServiceResponse
    {
        private List<BusinessReportSchedule> _businessReportSchedules = new List<BusinessReportSchedule>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BusinessReportSchedules. 
        /// <para>
        /// The schedule of the reports.
        /// </para>
        /// </summary>
        public List<BusinessReportSchedule> BusinessReportSchedules
        {
            get { return this._businessReportSchedules; }
            set { this._businessReportSchedules = value; }
        }

        // Check to see if BusinessReportSchedules property is set
        internal bool IsSetBusinessReportSchedules()
        {
            return this._businessReportSchedules != null && this._businessReportSchedules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to list the remaining schedules from the previous API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1100)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}