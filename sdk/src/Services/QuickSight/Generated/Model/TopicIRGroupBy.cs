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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition for a <c>TopicIRGroupBy</c>.
    /// </summary>
    public partial class TopicIRGroupBy
    {
        private DisplayFormat _displayFormat;
        private DisplayFormatOptions _displayFormatOptions;
        private Identifier _fieldName;
        private NamedEntityRef _namedEntity;
        private TopicSortClause _sort;
        private TopicTimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property DisplayFormat. 
        /// <para>
        /// The display format for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public DisplayFormat DisplayFormat
        {
            get { return this._displayFormat; }
            set { this._displayFormat = value; }
        }

        // Check to see if DisplayFormat property is set
        internal bool IsSetDisplayFormat()
        {
            return this._displayFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFormatOptions.
        /// </summary>
        public DisplayFormatOptions DisplayFormatOptions
        {
            get { return this._displayFormatOptions; }
            set { this._displayFormatOptions = value; }
        }

        // Check to see if DisplayFormatOptions property is set
        internal bool IsSetDisplayFormatOptions()
        {
            return this._displayFormatOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The field name for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public Identifier FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property NamedEntity. 
        /// <para>
        /// The named entity for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public NamedEntityRef NamedEntity
        {
            get { return this._namedEntity; }
            set { this._namedEntity = value; }
        }

        // Check to see if NamedEntity property is set
        internal bool IsSetNamedEntity()
        {
            return this._namedEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public TopicSortClause Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The time granularity for the <c>TopicIRGroupBy</c>.
        /// </para>
        /// </summary>
        public TopicTimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

    }
}