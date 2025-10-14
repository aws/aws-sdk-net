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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Time range that you <b>additionally</b> want to filter on.
    /// 
    ///  <note> 
    /// <para>
    /// This is different from the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_SearchContactsTimeRange.html">SearchContactsTimeRange</a>
    /// data type.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchContactsAdditionalTimeRange
    {
        private List<SearchContactsAdditionalTimeRangeCriteria> _criteria = AWSConfigs.InitializeCollections ? new List<SearchContactsAdditionalTimeRangeCriteria>() : null;
        private SearchContactsMatchType _matchType;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// List of criteria of the time range to additionally filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SearchContactsAdditionalTimeRangeCriteria> Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null && (this._criteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// The match type combining multiple time range filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchContactsMatchType MatchType
        {
            get { return this._matchType; }
            set { this._matchType = value; }
        }

        // Check to see if MatchType property is set
        internal bool IsSetMatchType()
        {
            return this._matchType != null;
        }

    }
}