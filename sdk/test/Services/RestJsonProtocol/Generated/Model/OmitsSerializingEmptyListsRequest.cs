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
    /// Container for the parameters to the OmitsSerializingEmptyLists operation.
    /// Omits serializing empty lists. Because empty strings are serilized as <c>Foo=</c>,
    /// empty lists cannot also be serialized as <c>Foo=</c> and instead must be omitted.
    /// </summary>
    public partial class OmitsSerializingEmptyListsRequest : AmazonRestJsonProtocolRequest
    {
        private List<bool> _queryBooleanList = AWSConfigs.InitializeCollections ? new List<bool>() : null;
        private List<double> _queryDoubleList = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<string> _queryEnumList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<int> _queryIntegerEnumList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _queryIntegerList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<string> _queryStringList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DateTime> _queryTimestampList = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Gets and sets the property QueryBooleanList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool> QueryBooleanList
        {
            get { return this._queryBooleanList; }
            set { this._queryBooleanList = value; }
        }

        // Check to see if QueryBooleanList property is set
        internal bool IsSetQueryBooleanList()
        {
            return this._queryBooleanList != null && (this._queryBooleanList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryDoubleList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> QueryDoubleList
        {
            get { return this._queryDoubleList; }
            set { this._queryDoubleList = value; }
        }

        // Check to see if QueryDoubleList property is set
        internal bool IsSetQueryDoubleList()
        {
            return this._queryDoubleList != null && (this._queryDoubleList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryEnumList
        {
            get { return this._queryEnumList; }
            set { this._queryEnumList = value; }
        }

        // Check to see if QueryEnumList property is set
        internal bool IsSetQueryEnumList()
        {
            return this._queryEnumList != null && (this._queryEnumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryIntegerEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIntegerEnumList
        {
            get { return this._queryIntegerEnumList; }
            set { this._queryIntegerEnumList = value; }
        }

        // Check to see if QueryIntegerEnumList property is set
        internal bool IsSetQueryIntegerEnumList()
        {
            return this._queryIntegerEnumList != null && (this._queryIntegerEnumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIntegerList
        {
            get { return this._queryIntegerList; }
            set { this._queryIntegerList = value; }
        }

        // Check to see if QueryIntegerList property is set
        internal bool IsSetQueryIntegerList()
        {
            return this._queryIntegerList != null && (this._queryIntegerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryStringList
        {
            get { return this._queryStringList; }
            set { this._queryStringList = value; }
        }

        // Check to see if QueryStringList property is set
        internal bool IsSetQueryStringList()
        {
            return this._queryStringList != null && (this._queryStringList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryTimestampList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> QueryTimestampList
        {
            get { return this._queryTimestampList; }
            set { this._queryTimestampList = value; }
        }

        // Check to see if QueryTimestampList property is set
        internal bool IsSetQueryTimestampList()
        {
            return this._queryTimestampList != null && (this._queryTimestampList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}