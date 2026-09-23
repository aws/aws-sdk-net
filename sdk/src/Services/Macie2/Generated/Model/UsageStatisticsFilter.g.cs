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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a condition for filtering the results of a query for quota and usage data
    /// for one or more Amazon Macie accounts.
    /// </summary>
    public partial class UsageStatisticsFilter
    {
        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The operator to use in the condition. If the value for the key property is accountId,
        /// this value must be CONTAINS. If the value for the key property is any other supported
        /// field, this value can be EQ, GT, GTE, LT, LTE, or NE.
        /// </para>
        /// </summary>
        public UsageStatisticsFilterComparator Comparator { get; set; }

        /// <summary>
        /// Checks to see if the Comparator property is set.
        /// </summary>
        internal bool IsSetComparator() => this.Comparator != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The field to use in the condition.
        /// </para>
        /// </summary>
        public UsageStatisticsFilterKey Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
