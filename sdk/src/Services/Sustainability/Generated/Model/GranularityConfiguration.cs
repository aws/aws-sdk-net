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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
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
namespace Amazon.Sustainability.Model
{
    /// <summary>
    /// Contains configuration for the fiscal year granularities (e.g., <c>YEARLY_FISCAL</c>,
    /// <c>QUARTERLY_FISCAL</c>.
    /// </summary>
    public partial class GranularityConfiguration
    {
        private int? _fiscalYearStartMonth;

        /// <summary>
        /// Gets and sets the property FiscalYearStartMonth. 
        /// <para>
        ///  The month (1-12) when the fiscal year begins. Used for <c>YEARLY_FISCAL</c> and <c>QUARTERLY_FISCAL</c>
        /// granularity. Defaults to 1 (January). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public int? FiscalYearStartMonth
        {
            get { return this._fiscalYearStartMonth; }
            set { this._fiscalYearStartMonth = value; }
        }

        // Check to see if FiscalYearStartMonth property is set
        internal bool IsSetFiscalYearStartMonth()
        {
            return this._fiscalYearStartMonth.HasValue; 
        }

    }
}