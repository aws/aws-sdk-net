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
    /// The definition for a <c>TopicIRGroupBy</c>.
    /// </summary>
    public partial class TopicIRGroupBy
    {
        /// <summary>
        /// Gets and sets the property DisplayFormat. 
        /// <para>
        /// The display format for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public DisplayFormat DisplayFormat { get; set; }

        /// <summary>
        /// Checks to see if the DisplayFormat property is set.
        /// </summary>
        internal bool IsSetDisplayFormat() => this.DisplayFormat != null;

        /// <summary>
        /// Gets and sets the property DisplayFormatOptions.
        /// </summary>
        public DisplayFormatOptions DisplayFormatOptions { get; set; }

        /// <summary>
        /// Checks to see if the DisplayFormatOptions property is set.
        /// </summary>
        internal bool IsSetDisplayFormatOptions() => this.DisplayFormatOptions != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The field name for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public Identifier FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property NamedEntity. 
        /// <para>
        /// The named entity for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public NamedEntityRef NamedEntity { get; set; }

        /// <summary>
        /// Checks to see if the NamedEntity property is set.
        /// </summary>
        internal bool IsSetNamedEntity() => this.NamedEntity != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public TopicSortClause Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The time granularity for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public TopicTimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;
    }
}
