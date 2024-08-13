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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetDomainStatisticsReport operation.
    /// Retrieve inbox placement and engagement rates for the domains that you use to send
    /// email.
    /// </summary>
    public partial class GetDomainStatisticsReportRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _domain;
        private DateTime? _endDate;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain that you want to obtain deliverability metrics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The last day (in Unix time) that you want to obtain domain deliverability metrics
        /// for. The <c>EndDate</c> that you specify has to be less than or equal to 30 days after
        /// the <c>StartDate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The first day (in Unix time) that you want to obtain domain deliverability metrics
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}