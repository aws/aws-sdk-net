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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
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
namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the QueryMaps operation.
    /// This test serializes simple and complex maps.
    /// </summary>
    public partial class QueryMapsRequest : AmazonQueryProtocolRequest
    {
        private Dictionary<string, GreetingStruct> _complexMapArg = AWSConfigs.InitializeCollections ? new Dictionary<string, GreetingStruct>() : null;
        private Dictionary<string, string> _flattenedMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _flattenedMapWithXmlName = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _mapArg = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, List<string>> _mapOfLists = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, string> _mapWithXmlMemberName = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NestedStructWithMap _nestedStructWithMap;
        private Dictionary<string, string> _renamedMapArg = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ComplexMapArg.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GreetingStruct> ComplexMapArg
        {
            get { return this._complexMapArg; }
            set { this._complexMapArg = value; }
        }

        // Check to see if ComplexMapArg property is set
        internal bool IsSetComplexMapArg()
        {
            return this._complexMapArg != null && (this._complexMapArg.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlattenedMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FlattenedMap
        {
            get { return this._flattenedMap; }
            set { this._flattenedMap = value; }
        }

        // Check to see if FlattenedMap property is set
        internal bool IsSetFlattenedMap()
        {
            return this._flattenedMap != null && (this._flattenedMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlattenedMapWithXmlName.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FlattenedMapWithXmlName
        {
            get { return this._flattenedMapWithXmlName; }
            set { this._flattenedMapWithXmlName = value; }
        }

        // Check to see if FlattenedMapWithXmlName property is set
        internal bool IsSetFlattenedMapWithXmlName()
        {
            return this._flattenedMapWithXmlName != null && (this._flattenedMapWithXmlName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapArg.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapArg
        {
            get { return this._mapArg; }
            set { this._mapArg = value; }
        }

        // Check to see if MapArg property is set
        internal bool IsSetMapArg()
        {
            return this._mapArg != null && (this._mapArg.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapOfLists.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MapOfLists
        {
            get { return this._mapOfLists; }
            set { this._mapOfLists = value; }
        }

        // Check to see if MapOfLists property is set
        internal bool IsSetMapOfLists()
        {
            return this._mapOfLists != null && (this._mapOfLists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapWithXmlMemberName.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapWithXmlMemberName
        {
            get { return this._mapWithXmlMemberName; }
            set { this._mapWithXmlMemberName = value; }
        }

        // Check to see if MapWithXmlMemberName property is set
        internal bool IsSetMapWithXmlMemberName()
        {
            return this._mapWithXmlMemberName != null && (this._mapWithXmlMemberName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NestedStructWithMap.
        /// </summary>
        public NestedStructWithMap NestedStructWithMap
        {
            get { return this._nestedStructWithMap; }
            set { this._nestedStructWithMap = value; }
        }

        // Check to see if NestedStructWithMap property is set
        internal bool IsSetNestedStructWithMap()
        {
            return this._nestedStructWithMap != null;
        }

        /// <summary>
        /// Gets and sets the property RenamedMapArg.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RenamedMapArg
        {
            get { return this._renamedMapArg; }
            set { this._renamedMapArg = value; }
        }

        // Check to see if RenamedMapArg property is set
        internal bool IsSetRenamedMapArg()
        {
            return this._renamedMapArg != null && (this._renamedMapArg.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}