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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An object that includes the data type of a security control parameter and its current
    /// value.
    /// </summary>
    public partial class ParameterValue
    {
        private bool? _boolean;
        private double? _double;
        private string _enum;
        private List<string> _enumList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _integer;
        private List<int> _integerList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _string;
        private List<string> _stringList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        ///  A control parameter that is a boolean. 
        /// </para>
        /// </summary>
        public bool? Boolean
        {
            get { return this._boolean; }
            set { this._boolean = value; }
        }

        // Check to see if Boolean property is set
        internal bool IsSetBoolean()
        {
            return this._boolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Double. 
        /// <para>
        ///  A control parameter that is a double. 
        /// </para>
        /// </summary>
        public double? Double
        {
            get { return this._double; }
            set { this._double = value; }
        }

        // Check to see if Double property is set
        internal bool IsSetDouble()
        {
            return this._double.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enum. 
        /// <para>
        ///  A control parameter that is an enum. 
        /// </para>
        /// </summary>
        public string Enum
        {
            get { return this._enum; }
            set { this._enum = value; }
        }

        // Check to see if Enum property is set
        internal bool IsSetEnum()
        {
            return this._enum != null;
        }

        /// <summary>
        /// Gets and sets the property EnumList. 
        /// <para>
        ///  A control parameter that is a list of enums. 
        /// </para>
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
        /// Gets and sets the property Integer. 
        /// <para>
        ///  A control parameter that is an integer. 
        /// </para>
        /// </summary>
        public int? Integer
        {
            get { return this._integer; }
            set { this._integer = value; }
        }

        // Check to see if Integer property is set
        internal bool IsSetInteger()
        {
            return this._integer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerList. 
        /// <para>
        ///  A control parameter that is a list of integers. 
        /// </para>
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
        /// Gets and sets the property String. 
        /// <para>
        ///  A control parameter that is a string. 
        /// </para>
        /// </summary>
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

        /// <summary>
        /// Gets and sets the property StringList. 
        /// <para>
        ///  A control parameter that is a list of strings. 
        /// </para>
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

    }
}