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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
    /// Maps source data to a dimension in the target Timestream for LiveAnalytics table.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/concepts.html">Amazon
    /// Timestream for LiveAnalytics concepts</a> 
    /// </para>
    /// </summary>
    public partial class DimensionMapping
    {
        private string _dimensionName;
        private string _dimensionValue;
        private DimensionValueType _dimensionValueType;

        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        /// The metadata attributes of the time series. For example, the name and Availability
        /// Zone of an Amazon EC2 instance or the name of the manufacturer of a wind turbine are
        /// dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }

        // Check to see if DimensionName property is set
        internal bool IsSetDimensionName()
        {
            return this._dimensionName != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValue. 
        /// <para>
        /// Dynamic path to the dimension value in the source event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DimensionValue
        {
            get { return this._dimensionValue; }
            set { this._dimensionValue = value; }
        }

        // Check to see if DimensionValue property is set
        internal bool IsSetDimensionValue()
        {
            return this._dimensionValue != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValueType. 
        /// <para>
        /// The data type of the dimension for the time-series data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionValueType DimensionValueType
        {
            get { return this._dimensionValueType; }
            set { this._dimensionValueType = value; }
        }

        // Check to see if DimensionValueType property is set
        internal bool IsSetDimensionValueType()
        {
            return this._dimensionValueType != null;
        }

    }
}