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
    /// Container for the parameters to the JsonLists operation.
    /// This test case serializes JSON lists for the following cases for both input and output:
    /// 
    ///  <ol> <li>Normal JSON lists.</li> <li>Normal JSON sets.</li> <li>JSON lists of lists.</li>
    /// <li>Lists of structures.</li> </ol>
    /// </summary>
    public partial class JsonListsRequest : AmazonRestJsonProtocolRequest
    {
        private List<bool> _booleanList = AWSConfigs.InitializeCollections ? new List<bool>() : null;
        private List<string> _enumList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<int> _integerList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _intEnumList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<List<string>> _nestedStringList = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private List<string> _stringList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _stringSet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<StructureListMember> _structureList = AWSConfigs.InitializeCollections ? new List<StructureListMember>() : null;
        private List<DateTime> _timestampList = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Gets and sets the property BooleanList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool> BooleanList
        {
            get { return this._booleanList; }
            set { this._booleanList = value; }
        }

        // Check to see if BooleanList property is set
        internal bool IsSetBooleanList()
        {
            return this._booleanList != null && (this._booleanList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnumList
        {
            get { return this._enumList; }
            set { this._enumList = value; }
        }

        // Check to see if EnumList property is set
        internal bool IsSetEnumList()
        {
            return this._enumList != null && (this._enumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerList
        {
            get { return this._integerList; }
            set { this._integerList = value; }
        }

        // Check to see if IntegerList property is set
        internal bool IsSetIntegerList()
        {
            return this._integerList != null && (this._integerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntEnumList
        {
            get { return this._intEnumList; }
            set { this._intEnumList = value; }
        }

        // Check to see if IntEnumList property is set
        internal bool IsSetIntEnumList()
        {
            return this._intEnumList != null && (this._intEnumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NestedStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> NestedStringList
        {
            get { return this._nestedStringList; }
            set { this._nestedStringList = value; }
        }

        // Check to see if NestedStringList property is set
        internal bool IsSetNestedStringList()
        {
            return this._nestedStringList != null && (this._nestedStringList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringList
        {
            get { return this._stringList; }
            set { this._stringList = value; }
        }

        // Check to see if StringList property is set
        internal bool IsSetStringList()
        {
            return this._stringList != null && (this._stringList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringSet
        {
            get { return this._stringSet; }
            set { this._stringSet = value; }
        }

        // Check to see if StringSet property is set
        internal bool IsSetStringSet()
        {
            return this._stringSet != null && (this._stringSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StructureList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StructureListMember> StructureList
        {
            get { return this._structureList; }
            set { this._structureList = value; }
        }

        // Check to see if StructureList property is set
        internal bool IsSetStructureList()
        {
            return this._structureList != null && (this._structureList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimestampList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> TimestampList
        {
            get { return this._timestampList; }
            set { this._timestampList = value; }
        }

        // Check to see if TimestampList property is set
        internal bool IsSetTimestampList()
        {
            return this._timestampList != null && (this._timestampList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}