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
    /// An object that includes the data type of a security control parameter and its current
    /// value.
    /// </summary>
    public partial class ParameterValue
    {
        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        ///  A control parameter that is a boolean. 
        /// </para>
        /// </summary>
        public bool? Boolean { get; set; }

        /// <summary>
        /// Checks to see if the Boolean property is set.
        /// </summary>
        internal bool IsSetBoolean() => this.Boolean.HasValue;

        /// <summary>
        /// Gets and sets the property Double. 
        /// <para>
        ///  A control parameter that is a double. 
        /// </para>
        /// </summary>
        public double? Double { get; set; }

        /// <summary>
        /// Checks to see if the Double property is set.
        /// </summary>
        internal bool IsSetDouble() => this.Double.HasValue;

        /// <summary>
        /// Gets and sets the property Enum. 
        /// <para>
        ///  A control parameter that is an enum. 
        /// </para>
        /// </summary>
        public string Enum { get; set; }

        /// <summary>
        /// Checks to see if the Enum property is set.
        /// </summary>
        internal bool IsSetEnum() => this.Enum != null;

        /// <summary>
        /// Gets and sets the property EnumList. 
        /// <para>
        ///  A control parameter that is a list of enums. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnumList property is set.
        /// </summary>
        internal bool IsSetEnumList() => this.EnumList != null && (this.EnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Integer. 
        /// <para>
        ///  A control parameter that is an integer. 
        /// </para>
        /// </summary>
        public int? Integer { get; set; }

        /// <summary>
        /// Checks to see if the Integer property is set.
        /// </summary>
        internal bool IsSetInteger() => this.Integer.HasValue;

        /// <summary>
        /// Gets and sets the property IntegerList. 
        /// <para>
        ///  A control parameter that is a list of integers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IntegerList property is set.
        /// </summary>
        internal bool IsSetIntegerList() => this.IntegerList != null && (this.IntegerList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        ///  A control parameter that is a string. 
        /// </para>
        /// </summary>
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property StringList. 
        /// <para>
        ///  A control parameter that is a list of strings. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringList property is set.
        /// </summary>
        internal bool IsSetStringList() => this.StringList != null && (this.StringList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
