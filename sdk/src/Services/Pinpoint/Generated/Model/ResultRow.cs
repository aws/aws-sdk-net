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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides the results of a query that retrieved the data for a standard metric that
    /// applies to an application, campaign, or journey.
    /// </summary>
    public partial class ResultRow
    {
        private List<ResultRowValue> _groupedBys = new List<ResultRowValue>();
        private List<ResultRowValue> _values = new List<ResultRowValue>();

        /// <summary>
        /// Gets and sets the property GroupedBys. 
        /// <para>
        /// An array of objects that defines the field and field values that were used to group
        /// data in a result set that contains multiple results. This value is null if the data
        /// in a result set isn’t grouped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResultRowValue> GroupedBys
        {
            get { return this._groupedBys; }
            set { this._groupedBys = value; }
        }

        // Check to see if GroupedBys property is set
        internal bool IsSetGroupedBys()
        {
            return this._groupedBys != null && this._groupedBys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array of objects that provides pre-aggregated values for a standard metric that
        /// applies to an application, campaign, or journey.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResultRowValue> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}