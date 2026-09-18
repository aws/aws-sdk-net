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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about a table for the query engine to consider.
    /// </summary>
    public partial class QueryGenerationTable
    {
        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// An array of objects, each of which defines information about a column in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryGenerationColumn> Columns { get; set; } = AWSConfigs.InitializeCollections ? new List<QueryGenerationColumn>() : null;

        /// <summary>
        /// Checks to see if the Columns property is set.
        /// </summary>
        internal bool IsSetColumns() => this.Columns != null && (this.Columns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the table that helps the query engine understand the contents of
        /// the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Inclusion. 
        /// <para>
        /// Specifies whether to include or exclude the table during query generation. If you
        /// specify <c>EXCLUDE</c>, the table will be ignored. If you specify <c>INCLUDE</c>,
        /// all other tables will be ignored.
        /// </para>
        /// </summary>
        public IncludeExclude Inclusion { get; set; }

        /// <summary>
        /// Checks to see if the Inclusion property is set.
        /// </summary>
        internal bool IsSetInclusion() => this.Inclusion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table for which the other fields in this object apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
