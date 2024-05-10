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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Attribute mapping for MULTI value measures.
    /// </summary>
    public partial class MultiMeasureAttributeMapping
    {
        private ScalarMeasureValueType _measureValueType;
        private string _sourceColumn;
        private string _targetMultiMeasureAttributeName;

        /// <summary>
        /// Gets and sets the property MeasureValueType. 
        /// <para>
        /// Type of the attribute to be read from the source column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalarMeasureValueType MeasureValueType
        {
            get { return this._measureValueType; }
            set { this._measureValueType = value; }
        }

        // Check to see if MeasureValueType property is set
        internal bool IsSetMeasureValueType()
        {
            return this._measureValueType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceColumn. 
        /// <para>
        /// Source column from where the attribute value is to be read.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceColumn
        {
            get { return this._sourceColumn; }
            set { this._sourceColumn = value; }
        }

        // Check to see if SourceColumn property is set
        internal bool IsSetSourceColumn()
        {
            return this._sourceColumn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetMultiMeasureAttributeName. 
        /// <para>
        /// Custom name to be used for attribute name in derived table. If not provided, source
        /// column name would be used.
        /// </para>
        /// </summary>
        public string TargetMultiMeasureAttributeName
        {
            get { return this._targetMultiMeasureAttributeName; }
            set { this._targetMultiMeasureAttributeName = value; }
        }

        // Check to see if TargetMultiMeasureAttributeName property is set
        internal bool IsSetTargetMultiMeasureAttributeName()
        {
            return this._targetMultiMeasureAttributeName != null;
        }

    }
}