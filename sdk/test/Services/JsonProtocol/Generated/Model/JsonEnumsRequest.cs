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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
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
namespace Amazon.JsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the JsonEnums operation.
    /// This example serializes enums as top level properties, in lists, sets, and maps.
    /// </summary>
    public partial class JsonEnumsRequest : AmazonJsonProtocolRequest
    {
        private FooEnum _fooEnum1;
        private FooEnum _fooEnum2;
        private FooEnum _fooEnum3;
        private List<string> _fooEnumList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _fooEnumMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _fooEnumSet = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FooEnum1.
        /// </summary>
        public FooEnum FooEnum1
        {
            get { return this._fooEnum1; }
            set { this._fooEnum1 = value; }
        }

        // Check to see if FooEnum1 property is set
        internal bool IsSetFooEnum1()
        {
            return this._fooEnum1 != null;
        }

        /// <summary>
        /// Gets and sets the property FooEnum2.
        /// </summary>
        public FooEnum FooEnum2
        {
            get { return this._fooEnum2; }
            set { this._fooEnum2 = value; }
        }

        // Check to see if FooEnum2 property is set
        internal bool IsSetFooEnum2()
        {
            return this._fooEnum2 != null;
        }

        /// <summary>
        /// Gets and sets the property FooEnum3.
        /// </summary>
        public FooEnum FooEnum3
        {
            get { return this._fooEnum3; }
            set { this._fooEnum3 = value; }
        }

        // Check to see if FooEnum3 property is set
        internal bool IsSetFooEnum3()
        {
            return this._fooEnum3 != null;
        }

        /// <summary>
        /// Gets and sets the property FooEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FooEnumList
        {
            get { return this._fooEnumList; }
            set { this._fooEnumList = value; }
        }

        // Check to see if FooEnumList property is set
        internal bool IsSetFooEnumList()
        {
            return this._fooEnumList != null && (this._fooEnumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FooEnumMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FooEnumMap
        {
            get { return this._fooEnumMap; }
            set { this._fooEnumMap = value; }
        }

        // Check to see if FooEnumMap property is set
        internal bool IsSetFooEnumMap()
        {
            return this._fooEnumMap != null && (this._fooEnumMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FooEnumSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FooEnumSet
        {
            get { return this._fooEnumSet; }
            set { this._fooEnumSet = value; }
        }

        // Check to see if FooEnumSet property is set
        internal bool IsSetFooEnumSet()
        {
            return this._fooEnumSet != null && (this._fooEnumSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}