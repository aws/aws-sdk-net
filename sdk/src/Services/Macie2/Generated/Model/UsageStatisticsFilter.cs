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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a condition for filtering the results of a query for quota and usage data
    /// for one or more Amazon Macie accounts.
    /// </summary>
    public partial class UsageStatisticsFilter
    {
        private UsageStatisticsFilterComparator _comparator;
        private UsageStatisticsFilterKey _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The operator to use in the condition. If the value for the key property is accountId,
        /// this value must be CONTAINS. If the value for the key property is any other supported
        /// field, this value can be EQ, GT, GTE, LT, LTE, or NE.
        /// </para>
        /// </summary>
        public UsageStatisticsFilterComparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The field to use in the condition.
        /// </para>
        /// </summary>
        public UsageStatisticsFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array that lists values to use in the condition, based on the value for the field
        /// specified by the key property. If the value for the key property is accountId, this
        /// array can specify multiple values. Otherwise, this array can specify only one value.
        /// </para>
        ///  
        /// <para>
        /// Valid values for each supported field are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// accountId - The unique identifier for an Amazon Web Services account.
        /// </para>
        /// </li> <li>
        /// <para>
        /// freeTrialStartDate - The date and time, in UTC and extended ISO 8601 format, when
        /// the Amazon Macie free trial started for an account.
        /// </para>
        /// </li> <li>
        /// <para>
        /// serviceLimit - A Boolean (true or false) value that indicates whether an account has
        /// reached its monthly quota.
        /// </para>
        /// </li> <li>
        /// <para>
        /// total - A string that represents the current estimated cost for an account.
        /// </para>
        /// </li></ul>
        /// </summary>
        public List<string> Values
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