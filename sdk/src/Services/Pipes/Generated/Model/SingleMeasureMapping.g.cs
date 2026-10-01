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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Maps a single source data field to a single record in the specified Timestream for
    /// LiveAnalytics table.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/concepts.html">Amazon
    /// Timestream for LiveAnalytics concepts</a> 
    /// </para>
    /// </summary>
    public partial class SingleMeasureMapping
    {
        /// <summary>
        /// Gets and sets the property MeasureName. 
        /// <para>
        /// Target measure name for the measurement attribute in the Timestream table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string MeasureName { get; set; }

        /// <summary>
        /// Checks to see if the MeasureName property is set.
        /// </summary>
        internal bool IsSetMeasureName() => this.MeasureName != null;

        /// <summary>
        /// Gets and sets the property MeasureValue. 
        /// <para>
        /// Dynamic path of the source field to map to the measure in the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string MeasureValue { get; set; }

        /// <summary>
        /// Checks to see if the MeasureValue property is set.
        /// </summary>
        internal bool IsSetMeasureValue() => this.MeasureValue != null;

        /// <summary>
        /// Gets and sets the property MeasureValueType. 
        /// <para>
        /// Data type of the source field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MeasureValueType MeasureValueType { get; set; }

        /// <summary>
        /// Checks to see if the MeasureValueType property is set.
        /// </summary>
        internal bool IsSetMeasureValueType() => this.MeasureValueType != null;
    }
}
