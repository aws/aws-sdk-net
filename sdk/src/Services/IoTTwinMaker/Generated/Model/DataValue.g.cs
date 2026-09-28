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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that specifies a value for a property.
    /// </summary>
    public partial class DataValue
    {
        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A Boolean value.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A double value.
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that produces the value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 316)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// An integer value.
        /// </para>
        /// </summary>
        public int? IntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the IntegerValue property is set.
        /// </summary>
        internal bool IsSetIntegerValue() => this.IntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property ListValue. 
        /// <para>
        /// A list of multiple values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<DataValue> ListValue { get; set; } = AWSConfigs.InitializeCollections ? new List<DataValue>() : null;

        /// <summary>
        /// Checks to see if the ListValue property is set.
        /// </summary>
        internal bool IsSetListValue() => this.ListValue != null && (this.ListValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A long value.
        /// </para>
        /// </summary>
        public long? LongValue { get; set; }

        /// <summary>
        /// Checks to see if the LongValue property is set.
        /// </summary>
        internal bool IsSetLongValue() => this.LongValue.HasValue;

        /// <summary>
        /// Gets and sets the property MapValue. 
        /// <para>
        /// An object that maps strings to multiple <c>DataValue</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, DataValue> MapValue { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DataValue>() : null;

        /// <summary>
        /// Checks to see if the MapValue property is set.
        /// </summary>
        internal bool IsSetMapValue() => this.MapValue != null && (this.MapValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelationshipValue. 
        /// <para>
        /// A value that relates a component to another component.
        /// </para>
        /// </summary>
        public RelationshipValue RelationshipValue { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipValue property is set.
        /// </summary>
        internal bool IsSetRelationshipValue() => this.RelationshipValue != null;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
