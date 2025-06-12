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
    /// The definition for a <c>TopicConstantValue</c>.
    /// </summary>
    public partial class TopicConstantValue
    {
        private ConstantType _constantType;
        private string _maximum;
        private string _minimum;
        private string _value;
        private List<CollectiveConstantEntry> _valueList = AWSConfigs.InitializeCollections ? new List<CollectiveConstantEntry>() : null;

        /// <summary>
        /// Gets and sets the property ConstantType. 
        /// <para>
        /// The constant type of a <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        public ConstantType ConstantType
        {
            get { return this._constantType; }
            set { this._constantType = value; }
        }

        // Check to see if ConstantType property is set
        internal bool IsSetConstantType()
        {
            return this._constantType != null;
        }

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum for the <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Maximum
        {
            get { return this._maximum; }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum != null;
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum for the <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Minimum
        {
            get { return this._minimum; }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property ValueList. 
        /// <para>
        /// The value list of the <c>TopicConstantValue</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<CollectiveConstantEntry> ValueList
        {
            get { return this._valueList; }
            set { this._valueList = value; }
        }

        // Check to see if ValueList property is set
        internal bool IsSetValueList()
        {
            return this._valueList != null && (this._valueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}