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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// This is the response object from the JsonIntEnums operation.
    /// </summary>
    public partial class JsonIntEnumsResponse : AmazonWebServiceResponse
    {
        private int? _integerEnum1;
        private int? _integerEnum2;
        private int? _integerEnum3;
        private List<int> _integerEnumList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private Dictionary<string, int> _integerEnumMap = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private List<int> _integerEnumSet = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property IntegerEnum1.
        /// </summary>
        public int? IntegerEnum1
        {
            get { return this._integerEnum1; }
            set { this._integerEnum1 = value; }
        }

        // Check to see if IntegerEnum1 property is set
        internal bool IsSetIntegerEnum1()
        {
            return this._integerEnum1.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerEnum2.
        /// </summary>
        public int? IntegerEnum2
        {
            get { return this._integerEnum2; }
            set { this._integerEnum2 = value; }
        }

        // Check to see if IntegerEnum2 property is set
        internal bool IsSetIntegerEnum2()
        {
            return this._integerEnum2.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerEnum3.
        /// </summary>
        public int? IntegerEnum3
        {
            get { return this._integerEnum3; }
            set { this._integerEnum3 = value; }
        }

        // Check to see if IntegerEnum3 property is set
        internal bool IsSetIntegerEnum3()
        {
            return this._integerEnum3.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerEnumList
        {
            get { return this._integerEnumList; }
            set { this._integerEnumList = value; }
        }

        // Check to see if IntegerEnumList property is set
        internal bool IsSetIntegerEnumList()
        {
            return this._integerEnumList != null && (this._integerEnumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegerEnumMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> IntegerEnumMap
        {
            get { return this._integerEnumMap; }
            set { this._integerEnumMap = value; }
        }

        // Check to see if IntegerEnumMap property is set
        internal bool IsSetIntegerEnumMap()
        {
            return this._integerEnumMap != null && (this._integerEnumMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegerEnumSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerEnumSet
        {
            get { return this._integerEnumSet; }
            set { this._integerEnumSet = value; }
        }

        // Check to see if IntegerEnumSet property is set
        internal bool IsSetIntegerEnumSet()
        {
            return this._integerEnumSet != null && (this._integerEnumSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}