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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the AllQueryStringTypes operation.
    /// This example uses all query string types.
    /// </summary>
    public partial class AllQueryStringTypesRequest : AmazonRestXmlProtocolRequest
    {
        private bool? _queryBoolean;
        private List<bool> _queryBooleanList = AWSConfigs.InitializeCollections ? new List<bool>() : null;
        private int? _queryByte;
        private double? _queryDouble;
        private List<double> _queryDoubleList = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private FooEnum _queryEnum;
        private List<string> _queryEnumList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _queryFloat;
        private int? _queryInteger;
        private int? _queryIntegerEnum;
        private List<int> _queryIntegerEnumList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _queryIntegerList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _queryIntegerSet = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private long? _queryLong;
        private Dictionary<string, string> _queryParamsMapOfStrings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _queryShort;
        private string _queryString;
        private List<string> _queryStringList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _queryStringSet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _queryTimestamp;
        private List<DateTime> _queryTimestampList = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Gets and sets the property QueryBoolean.
        /// </summary>
        public bool? QueryBoolean
        {
            get { return this._queryBoolean; }
            set { this._queryBoolean = value; }
        }

        // Check to see if QueryBoolean property is set
        internal bool IsSetQueryBoolean()
        {
            return this._queryBoolean.HasValue; 
        }

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
        /// Gets and sets the property QueryByte.
        /// </summary>
        public int? QueryByte
        {
            get { return this._queryByte; }
            set { this._queryByte = value; }
        }

        // Check to see if QueryByte property is set
        internal bool IsSetQueryByte()
        {
            return this._queryByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryDouble.
        /// </summary>
        public double? QueryDouble
        {
            get { return this._queryDouble; }
            set { this._queryDouble = value; }
        }

        // Check to see if QueryDouble property is set
        internal bool IsSetQueryDouble()
        {
            return this._queryDouble.HasValue; 
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
        /// Gets and sets the property QueryEnum.
        /// </summary>
        public FooEnum QueryEnum
        {
            get { return this._queryEnum; }
            set { this._queryEnum = value; }
        }

        // Check to see if QueryEnum property is set
        internal bool IsSetQueryEnum()
        {
            return this._queryEnum != null;
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
        /// Gets and sets the property QueryFloat.
        /// </summary>
        public float? QueryFloat
        {
            get { return this._queryFloat; }
            set { this._queryFloat = value; }
        }

        // Check to see if QueryFloat property is set
        internal bool IsSetQueryFloat()
        {
            return this._queryFloat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryInteger.
        /// </summary>
        public int? QueryInteger
        {
            get { return this._queryInteger; }
            set { this._queryInteger = value; }
        }

        // Check to see if QueryInteger property is set
        internal bool IsSetQueryInteger()
        {
            return this._queryInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryIntegerEnum.
        /// </summary>
        public int? QueryIntegerEnum
        {
            get { return this._queryIntegerEnum; }
            set { this._queryIntegerEnum = value; }
        }

        // Check to see if QueryIntegerEnum property is set
        internal bool IsSetQueryIntegerEnum()
        {
            return this._queryIntegerEnum.HasValue; 
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
        /// Gets and sets the property QueryIntegerSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIntegerSet
        {
            get { return this._queryIntegerSet; }
            set { this._queryIntegerSet = value; }
        }

        // Check to see if QueryIntegerSet property is set
        internal bool IsSetQueryIntegerSet()
        {
            return this._queryIntegerSet != null && (this._queryIntegerSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryLong.
        /// </summary>
        public long? QueryLong
        {
            get { return this._queryLong; }
            set { this._queryLong = value; }
        }

        // Check to see if QueryLong property is set
        internal bool IsSetQueryLong()
        {
            return this._queryLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryParamsMapOfStrings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> QueryParamsMapOfStrings
        {
            get { return this._queryParamsMapOfStrings; }
            set { this._queryParamsMapOfStrings = value; }
        }

        // Check to see if QueryParamsMapOfStrings property is set
        internal bool IsSetQueryParamsMapOfStrings()
        {
            return this._queryParamsMapOfStrings != null && (this._queryParamsMapOfStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryShort.
        /// </summary>
        public int? QueryShort
        {
            get { return this._queryShort; }
            set { this._queryShort = value; }
        }

        // Check to see if QueryShort property is set
        internal bool IsSetQueryShort()
        {
            return this._queryShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryString.
        /// </summary>
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
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
        /// Gets and sets the property QueryStringSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryStringSet
        {
            get { return this._queryStringSet; }
            set { this._queryStringSet = value; }
        }

        // Check to see if QueryStringSet property is set
        internal bool IsSetQueryStringSet()
        {
            return this._queryStringSet != null && (this._queryStringSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryTimestamp.
        /// </summary>
        public DateTime? QueryTimestamp
        {
            get { return this._queryTimestamp; }
            set { this._queryTimestamp = value; }
        }

        // Check to see if QueryTimestamp property is set
        internal bool IsSetQueryTimestamp()
        {
            return this._queryTimestamp.HasValue; 
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