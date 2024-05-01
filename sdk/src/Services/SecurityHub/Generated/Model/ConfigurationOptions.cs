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
    /// The options for customizing a security control parameter.
    /// </summary>
    public partial class ConfigurationOptions
    {
        private BooleanConfigurationOptions _boolean;
        private DoubleConfigurationOptions _double;
        private EnumConfigurationOptions _enum;
        private EnumListConfigurationOptions _enumList;
        private IntegerConfigurationOptions _integer;
        private IntegerListConfigurationOptions _integerList;
        private StringConfigurationOptions _string;
        private StringListConfigurationOptions _stringList;

        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        ///  The options for customizing a security control parameter that is a boolean. For a
        /// boolean parameter, the options are <c>true</c> and <c>false</c>. 
        /// </para>
        /// </summary>
        public BooleanConfigurationOptions Boolean
        {
            get { return this._boolean; }
            set { this._boolean = value; }
        }

        // Check to see if Boolean property is set
        internal bool IsSetBoolean()
        {
            return this._boolean != null;
        }

        /// <summary>
        /// Gets and sets the property Double. 
        /// <para>
        ///  The options for customizing a security control parameter that is a double. 
        /// </para>
        /// </summary>
        public DoubleConfigurationOptions Double
        {
            get { return this._double; }
            set { this._double = value; }
        }

        // Check to see if Double property is set
        internal bool IsSetDouble()
        {
            return this._double != null;
        }

        /// <summary>
        /// Gets and sets the property Enum. 
        /// <para>
        ///  The options for customizing a security control parameter that is an enum. 
        /// </para>
        /// </summary>
        public EnumConfigurationOptions Enum
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
        ///  The options for customizing a security control parameter that is a list of enums.
        /// 
        /// </para>
        /// </summary>
        public EnumListConfigurationOptions EnumList
        {
            get { return this._enumList; }
            set { this._enumList = value; }
        }

        // Check to see if EnumList property is set
        internal bool IsSetEnumList()
        {
            return this._enumList != null;
        }

        /// <summary>
        /// Gets and sets the property Integer. 
        /// <para>
        ///  The options for customizing a security control parameter that is an integer. 
        /// </para>
        /// </summary>
        public IntegerConfigurationOptions Integer
        {
            get { return this._integer; }
            set { this._integer = value; }
        }

        // Check to see if Integer property is set
        internal bool IsSetInteger()
        {
            return this._integer != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerList. 
        /// <para>
        ///  The options for customizing a security control parameter that is a list of integers.
        /// 
        /// </para>
        /// </summary>
        public IntegerListConfigurationOptions IntegerList
        {
            get { return this._integerList; }
            set { this._integerList = value; }
        }

        // Check to see if IntegerList property is set
        internal bool IsSetIntegerList()
        {
            return this._integerList != null;
        }

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        ///  The options for customizing a security control parameter that is a string data type.
        /// 
        /// </para>
        /// </summary>
        public StringConfigurationOptions String
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
        ///  The options for customizing a security control parameter that is a list of strings.
        /// 
        /// </para>
        /// </summary>
        public StringListConfigurationOptions StringList
        {
            get { return this._stringList; }
            set { this._stringList = value; }
        }

        // Check to see if StringList property is set
        internal bool IsSetStringList()
        {
            return this._stringList != null;
        }

    }
}