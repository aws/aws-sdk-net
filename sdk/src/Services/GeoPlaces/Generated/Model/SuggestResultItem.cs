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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The resulting item from the suggested query.
    /// </summary>
    public partial class SuggestResultItem
    {
        private SuggestHighlights _highlights;
        private SuggestPlaceResult _place;
        private SuggestQueryResult _query;
        private SuggestResultItemType _suggestResultItemType;
        private string _title;

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// Describes how the parts of the response element matched the input query by returning
        /// the sections of the response which matched to input query terms. 
        /// </para>
        /// </summary>
        public SuggestHighlights Highlights
        {
            get { return this._highlights; }
            set { this._highlights = value; }
        }

        // Check to see if Highlights property is set
        internal bool IsSetHighlights()
        {
            return this._highlights != null;
        }

        /// <summary>
        /// Gets and sets the property Place. 
        /// <para>
        /// The suggested place by its unique ID.
        /// </para>
        /// </summary>
        public SuggestPlaceResult Place
        {
            get { return this._place; }
            set { this._place = value; }
        }

        // Check to see if Place property is set
        internal bool IsSetPlace()
        {
            return this._place != null;
        }

        /// <summary>
        /// Gets and sets the property Query.
        /// </summary>
        public SuggestQueryResult Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestResultItemType. 
        /// <para>
        /// The result type. Place results represent the final result for a point of interest,
        /// Query results represent a follow up query which can be completed through the SearchText
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SuggestResultItemType SuggestResultItemType
        {
            get { return this._suggestResultItemType; }
            set { this._suggestResultItemType = value; }
        }

        // Check to see if SuggestResultItemType property is set
        internal bool IsSetSuggestResultItemType()
        {
            return this._suggestResultItemType != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The display title that should be used when presenting this option to the end user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}