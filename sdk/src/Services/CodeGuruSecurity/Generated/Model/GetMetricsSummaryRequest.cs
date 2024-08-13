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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricsSummary operation.
    /// Returns a summary of metrics for an account from a specified date, including number
    /// of open findings, the categories with most findings, the scans with most open findings,
    /// and scans with most open critical findings.
    /// </summary>
    public partial class GetMetricsSummaryRequest : AmazonCodeGuruSecurityRequest
    {
        private DateTime? _date;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date you want to retrieve summary metrics from, rounded to the nearest day. The
        /// date must be within the past two years.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

    }
}