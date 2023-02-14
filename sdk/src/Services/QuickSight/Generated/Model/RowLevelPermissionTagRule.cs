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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A set of rules associated with a tag.
    /// </summary>
    public partial class RowLevelPermissionTagRule
    {
        private string _columnName;
        private string _matchAllValue;
        private string _tagKey;
        private string _tagMultiValueDelimiter;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The column name that a tag key is assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property MatchAllValue. 
        /// <para>
        /// A string that you want to use to filter by all the values in a column in the dataset
        /// and don’t want to list the values one by one. For example, you can use an asterisk
        /// as your match all value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string MatchAllValue
        {
            get { return this._matchAllValue; }
            set { this._matchAllValue = value; }
        }

        // Check to see if MatchAllValue property is set
        internal bool IsSetMatchAllValue()
        {
            return this._matchAllValue != null;
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The unique key for a tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagMultiValueDelimiter. 
        /// <para>
        /// A string that you want to use to delimit the values when you pass the values at run
        /// time. For example, you can delimit the values with a comma.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public string TagMultiValueDelimiter
        {
            get { return this._tagMultiValueDelimiter; }
            set { this._tagMultiValueDelimiter = value; }
        }

        // Check to see if TagMultiValueDelimiter property is set
        internal bool IsSetTagMultiValueDelimiter()
        {
            return this._tagMultiValueDelimiter != null;
        }

    }
}