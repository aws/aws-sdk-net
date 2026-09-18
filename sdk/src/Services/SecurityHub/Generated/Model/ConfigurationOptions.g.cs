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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        ///  The options for customizing a security control parameter that is a boolean. For a
        /// boolean parameter, the options are <c>true</c> and <c>false</c>. 
        /// </para>
        /// </summary>
        public BooleanConfigurationOptions Boolean { get; set; }

        /// <summary>
        /// Checks to see if the Boolean property is set.
        /// </summary>
        internal bool IsSetBoolean() => this.Boolean != null;

        /// <summary>
        /// Gets and sets the property Double. 
        /// <para>
        ///  The options for customizing a security control parameter that is a double. 
        /// </para>
        /// </summary>
        public DoubleConfigurationOptions Double { get; set; }

        /// <summary>
        /// Checks to see if the Double property is set.
        /// </summary>
        internal bool IsSetDouble() => this.Double != null;

        /// <summary>
        /// Gets and sets the property Enum. 
        /// <para>
        ///  The options for customizing a security control parameter that is an enum. 
        /// </para>
        /// </summary>
        public EnumConfigurationOptions Enum { get; set; }

        /// <summary>
        /// Checks to see if the Enum property is set.
        /// </summary>
        internal bool IsSetEnum() => this.Enum != null;

        /// <summary>
        /// Gets and sets the property EnumList. 
        /// <para>
        ///  The options for customizing a security control parameter that is a list of enums.
        /// 
        /// </para>
        /// </summary>
        public EnumListConfigurationOptions EnumList { get; set; }

        /// <summary>
        /// Checks to see if the EnumList property is set.
        /// </summary>
        internal bool IsSetEnumList() => this.EnumList != null;

        /// <summary>
        /// Gets and sets the property Integer. 
        /// <para>
        ///  The options for customizing a security control parameter that is an integer. 
        /// </para>
        /// </summary>
        public IntegerConfigurationOptions Integer { get; set; }

        /// <summary>
        /// Checks to see if the Integer property is set.
        /// </summary>
        internal bool IsSetInteger() => this.Integer != null;

        /// <summary>
        /// Gets and sets the property IntegerList. 
        /// <para>
        ///  The options for customizing a security control parameter that is a list of integers.
        /// 
        /// </para>
        /// </summary>
        public IntegerListConfigurationOptions IntegerList { get; set; }

        /// <summary>
        /// Checks to see if the IntegerList property is set.
        /// </summary>
        internal bool IsSetIntegerList() => this.IntegerList != null;

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        ///  The options for customizing a security control parameter that is a string data type.
        /// 
        /// </para>
        /// </summary>
        public StringConfigurationOptions String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property StringList. 
        /// <para>
        ///  The options for customizing a security control parameter that is a list of strings.
        /// 
        /// </para>
        /// </summary>
        public StringListConfigurationOptions StringList { get; set; }

        /// <summary>
        /// Checks to see if the StringList property is set.
        /// </summary>
        internal bool IsSetStringList() => this.StringList != null;
    }
}
