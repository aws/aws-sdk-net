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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The resulting item from the suggested query.
    /// </summary>
    public partial class SuggestResultItem
    {
        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// Describes how the parts of the response element matched the input query by returning
        /// the sections of the response which matched to input query terms. 
        /// </para>
        /// </summary>
        public SuggestHighlights Highlights { get; set; }

        /// <summary>
        /// Checks to see if the Highlights property is set.
        /// </summary>
        internal bool IsSetHighlights() => this.Highlights != null;

        /// <summary>
        /// Gets and sets the property Place. 
        /// <para>
        /// The suggested place by its unique ID.
        /// </para>
        /// </summary>
        public SuggestPlaceResult Place { get; set; }

        /// <summary>
        /// Checks to see if the Place property is set.
        /// </summary>
        internal bool IsSetPlace() => this.Place != null;

        /// <summary>
        /// Gets and sets the property Query.
        /// </summary>
        public SuggestQueryResult Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property SuggestResultItemType. 
        /// <para>
        /// The result type. Place results represent the final result for a point of interest,
        /// Query results represent a follow up query which can be completed through the SearchText
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SuggestResultItemType SuggestResultItemType { get; set; }

        /// <summary>
        /// Checks to see if the SuggestResultItemType property is set.
        /// </summary>
        internal bool IsSetSuggestResultItemType() => this.SuggestResultItemType != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The display title that should be used when presenting this option to the end user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
