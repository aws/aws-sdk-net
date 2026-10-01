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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// An object that contains two attributes, <c>SortBy</c> and <c>SortOrder</c>.
    /// </summary>
    public partial class Sort
    {
        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// For <c>ListEntities</c>, supported attributes include <c>LastModifiedDate</c> (default)
        /// and <c>EntityId</c>. In addition to <c>LastModifiedDate</c> and <c>EntityId</c>, each
        /// <c>EntityType</c> might support additional fields.
        /// </para>
        ///  
        /// <para>
        /// For <c>ListChangeSets</c>, supported attributes include <c>StartTime</c> and <c>EndTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sorting order. Can be <c>ASCENDING</c> or <c>DESCENDING</c>. The default value
        /// is <c>DESCENDING</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
