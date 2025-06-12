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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Describes the resources available for a container instance.
    /// </summary>
    public partial class Resource
    {
        private double? _doubleValue;
        private int? _integerValue;
        private long? _longValue;
        private string _name;
        private List<string> _stringSetValue = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// When the <c>doubleValue</c> type is set, the value of the resource must be a double
        /// precision floating-point type.
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
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// When the <c>integerValue</c> type is set, the value of the resource must be an integer.
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
        /// Gets and sets the property LongValue. 
        /// <para>
        /// When the <c>longValue</c> type is set, the value of the resource must be an extended
        /// precision floating-point type.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource, such as <c>CPU</c>, <c>MEMORY</c>, <c>PORTS</c>, <c>PORTS_UDP</c>,
        /// or a user-defined resource.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StringSetValue. 
        /// <para>
        /// When the <c>stringSetValue</c> type is set, the value of the resource must be a string
        /// type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringSetValue
        {
            get { return this._stringSetValue; }
            set { this._stringSetValue = value; }
        }

        // Check to see if StringSetValue property is set
        internal bool IsSetStringSetValue()
        {
            return this._stringSetValue != null && (this._stringSetValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource. Valid values: <c>INTEGER</c>, <c>DOUBLE</c>, <c>LONG</c>,
        /// or <c>STRINGSET</c>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}