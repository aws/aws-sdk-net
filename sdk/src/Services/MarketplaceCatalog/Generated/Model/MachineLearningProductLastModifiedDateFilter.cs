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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The filter for machine learning product last modified date.
    /// </summary>
    public partial class MachineLearningProductLastModifiedDateFilter
    {
        private MachineLearningProductLastModifiedDateFilterDateRange _dateRange;

        /// <summary>
        /// Gets and sets the property DateRange. 
        /// <para>
        /// A date range to filter by. The operation returns machine learning products with last
        /// modified dates that fall within this range.
        /// </para>
        /// </summary>
        public MachineLearningProductLastModifiedDateFilterDateRange DateRange
        {
            get { return this._dateRange; }
            set { this._dateRange = value; }
        }

        // Check to see if DateRange property is set
        internal bool IsSetDateRange()
        {
            return this._dateRange != null;
        }

    }
}