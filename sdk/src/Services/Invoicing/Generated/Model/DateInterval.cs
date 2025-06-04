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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The time period that you want invoice-related documents for.
    /// </summary>
    public partial class DateInterval
    {
        private DateTime? _endDate;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        ///  The end of the time period that you want invoice-related documents for. The end date
        /// is exclusive. For example, if <c>end</c> is <c>2019-01-10</c>, Amazon Web Services
        /// retrieves invoice-related documents from the start date up to, but not including,
        /// <c>2018-01-10</c>. 
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
        ///  The beginning of the time period that you want invoice-related documents for. The
        /// start date is inclusive. For example, if <c>start</c> is <c>2019-01-01</c>, AWS retrieves
        /// invoices starting at <c>2019-01-01</c> up to the end date. 
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