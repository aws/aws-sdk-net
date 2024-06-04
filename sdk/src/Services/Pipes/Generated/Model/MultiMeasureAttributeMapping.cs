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
    /// A mapping of a source event data field to a measure in a Timestream for LiveAnalytics
    /// record.
    /// </summary>
    public partial class MultiMeasureAttributeMapping
    {
        private string _measureValue;
        private MeasureValueType _measureValueType;
        private string _multiMeasureAttributeName;

        /// <summary>
        /// Gets and sets the property MeasureValue. 
        /// <para>
        /// Dynamic path to the measurement attribute in the source event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string MeasureValue
        {
            get { return this._measureValue; }
            set { this._measureValue = value; }
        }

        // Check to see if MeasureValue property is set
        internal bool IsSetMeasureValue()
        {
            return this._measureValue != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureValueType. 
        /// <para>
        /// Data type of the measurement attribute in the source event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MeasureValueType MeasureValueType
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
        /// Gets and sets the property MultiMeasureAttributeName. 
        /// <para>
        /// Target measure name to be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MultiMeasureAttributeName
        {
            get { return this._multiMeasureAttributeName; }
            set { this._multiMeasureAttributeName = value; }
        }

        // Check to see if MultiMeasureAttributeName property is set
        internal bool IsSetMultiMeasureAttributeName()
        {
            return this._multiMeasureAttributeName != null;
        }

    }
}