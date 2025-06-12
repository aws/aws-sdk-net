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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that specifies a value for a property.
    /// </summary>
    public partial class DataValue
    {
        private bool? _booleanValue;
        private double? _doubleValue;
        private string _expression;
        private int? _integerValue;
        private List<DataValue> _listValue = AWSConfigs.InitializeCollections ? new List<DataValue>() : null;
        private long? _longValue;
        private Dictionary<string, DataValue> _mapValue = AWSConfigs.InitializeCollections ? new Dictionary<string, DataValue>() : null;
        private RelationshipValue _relationshipValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A Boolean value.
        /// </para>
        /// </summary>
        public bool? BooleanValue
        {
            get { return this._booleanValue; }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A double value.
        /// </para>
        /// </summary>
        public double? DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that produces the value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=316)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// An integer value.
        /// </para>
        /// </summary>
        public int? IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListValue. 
        /// <para>
        /// A list of multiple values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<DataValue> ListValue
        {
            get { return this._listValue; }
            set { this._listValue = value; }
        }

        // Check to see if ListValue property is set
        internal bool IsSetListValue()
        {
            return this._listValue != null && (this._listValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A long value.
        /// </para>
        /// </summary>
        public long? LongValue
        {
            get { return this._longValue; }
            set { this._longValue = value; }
        }

        // Check to see if LongValue property is set
        internal bool IsSetLongValue()
        {
            return this._longValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapValue. 
        /// <para>
        /// An object that maps strings to multiple <c>DataValue</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, DataValue> MapValue
        {
            get { return this._mapValue; }
            set { this._mapValue = value; }
        }

        // Check to see if MapValue property is set
        internal bool IsSetMapValue()
        {
            return this._mapValue != null && (this._mapValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelationshipValue. 
        /// <para>
        /// A value that relates a component to another component.
        /// </para>
        /// </summary>
        public RelationshipValue RelationshipValue
        {
            get { return this._relationshipValue; }
            set { this._relationshipValue = value; }
        }

        // Check to see if RelationshipValue property is set
        internal bool IsSetRelationshipValue()
        {
            return this._relationshipValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}