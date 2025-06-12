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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information for tuning the relevance of a field in a search. When a query
    /// includes terms that match the field, the results are given a boost in the response
    /// based on these tuning parameters.
    /// </summary>
    public partial class Relevance
    {
        private string _duration;
        private bool? _freshness;
        private int? _importance;
        private Order _rankOrder;
        private Dictionary<string, int> _valueImportanceMap = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Specifies the time period that the boost applies to. For example, to make the boost
        /// apply to documents with the field value within the last month, you would use "2628000s".
        /// Once the field value is beyond the specified range, the effect of the boost drops
        /// off. The higher the importance, the faster the effect drops off. If you don't specify
        /// a value, the default is 3 months. The value of the field is a numeric string followed
        /// by the character "s", for example "86400s" for one day, or "604800s" for one week.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Only applies to <c>DATE</c> fields.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Freshness. 
        /// <para>
        /// Indicates that this field determines how "fresh" a document is. For example, if document
        /// 1 was created on November 5, and document 2 was created on October 31, document 1
        /// is "fresher" than document 2. Only applies to <c>DATE</c> fields.
        /// </para>
        /// </summary>
        public bool? Freshness
        {
            get { return this._freshness; }
            set { this._freshness = value; }
        }

        // Check to see if Freshness property is set
        internal bool IsSetFreshness()
        {
            return this._freshness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Importance. 
        /// <para>
        /// The relative importance of the field in the search. Larger numbers provide more of
        /// a boost than smaller numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? Importance
        {
            get { return this._importance; }
            set { this._importance = value; }
        }

        // Check to see if Importance property is set
        internal bool IsSetImportance()
        {
            return this._importance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RankOrder. 
        /// <para>
        /// Determines how values should be interpreted.
        /// </para>
        ///  
        /// <para>
        /// When the <c>RankOrder</c> field is <c>ASCENDING</c>, higher numbers are better. For
        /// example, a document with a rating score of 10 is higher ranking than a document with
        /// a rating score of 1.
        /// </para>
        ///  
        /// <para>
        /// When the <c>RankOrder</c> field is <c>DESCENDING</c>, lower numbers are better. For
        /// example, in a task tracking application, a priority 1 task is more important than
        /// a priority 5 task.
        /// </para>
        ///  
        /// <para>
        /// Only applies to <c>LONG</c> fields.
        /// </para>
        /// </summary>
        public Order RankOrder
        {
            get { return this._rankOrder; }
            set { this._rankOrder = value; }
        }

        // Check to see if RankOrder property is set
        internal bool IsSetRankOrder()
        {
            return this._rankOrder != null;
        }

        /// <summary>
        /// Gets and sets the property ValueImportanceMap. 
        /// <para>
        /// A list of values that should be given a different boost when they appear in the result
        /// list. For example, if you are boosting a field called "department", query terms that
        /// match the department field are boosted in the result. However, you can add entries
        /// from the department field to boost documents with those values higher. 
        /// </para>
        ///  
        /// <para>
        /// For example, you can add entries to the map with names of departments. If you add
        /// "HR",5 and "Legal",3 those departments are given special attention when they appear
        /// in the metadata of a document. When those terms appear they are given the specified
        /// importance instead of the regular importance for the boost.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ValueImportanceMap
        {
            get { return this._valueImportanceMap; }
            set { this._valueImportanceMap = value; }
        }

        // Check to see if ValueImportanceMap property is set
        internal bool IsSetValueImportanceMap()
        {
            return this._valueImportanceMap != null && (this._valueImportanceMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}