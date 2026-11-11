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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Attribute mapping for MULTI value measures.
    /// </summary>
    public partial class MultiMeasureAttributeMapping
    {
        /// <summary>
        /// Gets and sets the property MeasureValueType. 
        /// <para>
        /// Type of the attribute to be read from the source column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalarMeasureValueType MeasureValueType { get; set; }

        /// <summary>
        /// Checks to see if the MeasureValueType property is set.
        /// </summary>
        internal bool IsSetMeasureValueType() => this.MeasureValueType != null;

        /// <summary>
        /// Gets and sets the property SourceColumn. 
        /// <para>
        /// Source column from where the attribute value is to be read.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceColumn { get; set; }

        /// <summary>
        /// Checks to see if the SourceColumn property is set.
        /// </summary>
        internal bool IsSetSourceColumn() => this.SourceColumn != null;

        /// <summary>
        /// Gets and sets the property TargetMultiMeasureAttributeName. 
        /// <para>
        /// Custom name to be used for attribute name in derived table. If not provided, source
        /// column name would be used.
        /// </para>
        /// </summary>
        public string TargetMultiMeasureAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the TargetMultiMeasureAttributeName property is set.
        /// </summary>
        internal bool IsSetTargetMultiMeasureAttributeName() => this.TargetMultiMeasureAttributeName != null;
    }
}
