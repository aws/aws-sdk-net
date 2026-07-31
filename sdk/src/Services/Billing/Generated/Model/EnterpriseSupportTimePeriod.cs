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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// A time period for Enterprise Support billing.
    /// </summary>
    public partial class EnterpriseSupportTimePeriod
    {
        private DateTime? _beginDate;
        private DateTime? _endDate;

        /// <summary>
        /// Gets and sets the property BeginDate. 
        /// <para>
        /// The begin date of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? BeginDate
        {
            get { return this._beginDate; }
            set { this._beginDate = value; }
        }

        // Check to see if BeginDate property is set
        internal bool IsSetBeginDate()
        {
            return this._beginDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the time period.
        /// </para>
        /// </summary>
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

    }
}