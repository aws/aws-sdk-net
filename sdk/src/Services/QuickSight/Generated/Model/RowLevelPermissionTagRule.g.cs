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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A set of rules associated with a tag.
    /// </summary>
    public partial class RowLevelPermissionTagRule
    {
        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The column name that a tag key is assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property MatchAllValue. 
        /// <para>
        /// A string that you want to use to filter by all the values in a column in the dataset
        /// and don’t want to list the values one by one. For example, you can use an asterisk
        /// as your match all value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string MatchAllValue { get; set; }

        /// <summary>
        /// Checks to see if the MatchAllValue property is set.
        /// </summary>
        internal bool IsSetMatchAllValue() => this.MatchAllValue != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The unique key for a tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagMultiValueDelimiter. 
        /// <para>
        /// A string that you want to use to delimit the values when you pass the values at run
        /// time. For example, you can delimit the values with a comma.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public string TagMultiValueDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the TagMultiValueDelimiter property is set.
        /// </summary>
        internal bool IsSetTagMultiValueDelimiter() => this.TagMultiValueDelimiter != null;
    }
}
