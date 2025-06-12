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
    /// This is the response object from the InputAndOutputWithHeaders operation.
    /// </summary>
    public partial class InputAndOutputWithHeadersResponse : AmazonWebServiceResponse
    {
        private List<bool> _headerBooleanList = AWSConfigs.InitializeCollections ? new List<bool>() : null;
        private int? _headerByte;
        private double? _headerDouble;
        private FooEnum _headerEnum;
        private List<string> _headerEnumList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _headerFalseBool;
        private float? _headerFloat;
        private int? _headerInteger;
        private int? _headerIntegerEnum;
        private List<int> _headerIntegerEnumList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _headerIntegerList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private long? _headerLong;
        private int? _headerShort;
        private string _headerString;
        private List<string> _headerStringList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _headerStringSet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DateTime> _headerTimestampList = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private bool? _headerTrueBool;

        /// <summary>
        /// Gets and sets the property HeaderBooleanList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool> HeaderBooleanList
        {
            get { return this._headerBooleanList; }
            set { this._headerBooleanList = value; }
        }

        // Check to see if HeaderBooleanList property is set
        internal bool IsSetHeaderBooleanList()
        {
            return this._headerBooleanList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderByte.
        /// </summary>
        public int? HeaderByte
        {
            get { return this._headerByte; }
            set { this._headerByte = value; }
        }

        // Check to see if HeaderByte property is set
        internal bool IsSetHeaderByte()
        {
            return this._headerByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderDouble.
        /// </summary>
        public double? HeaderDouble
        {
            get { return this._headerDouble; }
            set { this._headerDouble = value; }
        }

        // Check to see if HeaderDouble property is set
        internal bool IsSetHeaderDouble()
        {
            return this._headerDouble.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderEnum.
        /// </summary>
        public FooEnum HeaderEnum
        {
            get { return this._headerEnum; }
            set { this._headerEnum = value; }
        }

        // Check to see if HeaderEnum property is set
        internal bool IsSetHeaderEnum()
        {
            return this._headerEnum != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderEnumList
        {
            get { return this._headerEnumList; }
            set { this._headerEnumList = value; }
        }

        // Check to see if HeaderEnumList property is set
        internal bool IsSetHeaderEnumList()
        {
            return this._headerEnumList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderFalseBool.
        /// </summary>
        public bool? HeaderFalseBool
        {
            get { return this._headerFalseBool; }
            set { this._headerFalseBool = value; }
        }

        // Check to see if HeaderFalseBool property is set
        internal bool IsSetHeaderFalseBool()
        {
            return this._headerFalseBool.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderFloat.
        /// </summary>
        public float? HeaderFloat
        {
            get { return this._headerFloat; }
            set { this._headerFloat = value; }
        }

        // Check to see if HeaderFloat property is set
        internal bool IsSetHeaderFloat()
        {
            return this._headerFloat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderInteger.
        /// </summary>
        public int? HeaderInteger
        {
            get { return this._headerInteger; }
            set { this._headerInteger = value; }
        }

        // Check to see if HeaderInteger property is set
        internal bool IsSetHeaderInteger()
        {
            return this._headerInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderIntegerEnum.
        /// </summary>
        public int? HeaderIntegerEnum
        {
            get { return this._headerIntegerEnum; }
            set { this._headerIntegerEnum = value; }
        }

        // Check to see if HeaderIntegerEnum property is set
        internal bool IsSetHeaderIntegerEnum()
        {
            return this._headerIntegerEnum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderIntegerEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> HeaderIntegerEnumList
        {
            get { return this._headerIntegerEnumList; }
            set { this._headerIntegerEnumList = value; }
        }

        // Check to see if HeaderIntegerEnumList property is set
        internal bool IsSetHeaderIntegerEnumList()
        {
            return this._headerIntegerEnumList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> HeaderIntegerList
        {
            get { return this._headerIntegerList; }
            set { this._headerIntegerList = value; }
        }

        // Check to see if HeaderIntegerList property is set
        internal bool IsSetHeaderIntegerList()
        {
            return this._headerIntegerList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderLong.
        /// </summary>
        public long? HeaderLong
        {
            get { return this._headerLong; }
            set { this._headerLong = value; }
        }

        // Check to see if HeaderLong property is set
        internal bool IsSetHeaderLong()
        {
            return this._headerLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderShort.
        /// </summary>
        public int? HeaderShort
        {
            get { return this._headerShort; }
            set { this._headerShort = value; }
        }

        // Check to see if HeaderShort property is set
        internal bool IsSetHeaderShort()
        {
            return this._headerShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeaderString.
        /// </summary>
        public string HeaderString
        {
            get { return this._headerString; }
            set { this._headerString = value; }
        }

        // Check to see if HeaderString property is set
        internal bool IsSetHeaderString()
        {
            return this._headerString != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderStringList
        {
            get { return this._headerStringList; }
            set { this._headerStringList = value; }
        }

        // Check to see if HeaderStringList property is set
        internal bool IsSetHeaderStringList()
        {
            return this._headerStringList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderStringSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderStringSet
        {
            get { return this._headerStringSet; }
            set { this._headerStringSet = value; }
        }

        // Check to see if HeaderStringSet property is set
        internal bool IsSetHeaderStringSet()
        {
            return this._headerStringSet != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderTimestampList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> HeaderTimestampList
        {
            get { return this._headerTimestampList; }
            set { this._headerTimestampList = value; }
        }

        // Check to see if HeaderTimestampList property is set
        internal bool IsSetHeaderTimestampList()
        {
            return this._headerTimestampList != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderTrueBool.
        /// </summary>
        public bool? HeaderTrueBool
        {
            get { return this._headerTrueBool; }
            set { this._headerTrueBool = value; }
        }

        // Check to see if HeaderTrueBool property is set
        internal bool IsSetHeaderTrueBool()
        {
            return this._headerTrueBool.HasValue; 
        }

    }
}