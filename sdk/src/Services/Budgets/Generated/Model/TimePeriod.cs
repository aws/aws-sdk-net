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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The period of time covered by a budget. Has a start date and an end date. The start
    /// date must come before the end date. There are no restrictions on the end date.
    /// </summary>
    public partial class TimePeriod
    {
        private DateTime? _end;
        private DateTime? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end date for a budget. If you didn't specify an end date, AWS set your end date
        /// to <code>06/15/87 00:00 UTC</code>. The defaults are the same for the AWS Billing
        /// and Cost Management console and the API.
        /// </para>
        ///  
        /// <para>
        /// After the end date, AWS deletes the budget and all associated notifications and subscribers.
        /// You can change your end date with the <code>UpdateBudget</code> operation.
        /// </para>
        /// </summary>
        public DateTime End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start date for a budget. If you created your budget and didn't specify a start
        /// date, AWS defaults to the start of your chosen time period (i.e. DAILY, MONTHLY, QUARTERLY,
        /// ANNUALLY). For example, if you created your budget on January 24th 2018, chose <code>DAILY</code>,
        /// and didn't set a start date, AWS set your start date to <code>01/24/18 00:00 UTC</code>.
        /// If you chose <code>MONTHLY</code>, AWS set your start date to <code>01/01/18 00:00
        /// UTC</code>. The defaults are the same for the AWS Billing and Cost Management console
        /// and the API.
        /// </para>
        ///  
        /// <para>
        /// You can change your start date with the <code>UpdateBudget</code> operation.
        /// </para>
        /// </summary>
        public DateTime Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}