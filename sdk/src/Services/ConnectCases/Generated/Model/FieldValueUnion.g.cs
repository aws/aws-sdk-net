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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Object to store union of Field values.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>Summary</c> system field accepts up to 3000 characters, while all other fields
    /// accept up to 4100 characters. If you use multi-byte characters, the effective character
    /// limit may be lower.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FieldValueUnion
    {
        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// Can be either null, or have a Boolean value type. Only one value can be provided.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// Can be either null, or have a Double number value type. Only one value can be provided.
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property EmptyValue. 
        /// <para>
        /// An empty value.
        /// </para>
        /// </summary>
        public EmptyFieldValue EmptyValue { get; set; }

        /// <summary>
        /// Checks to see if the EmptyValue property is set.
        /// </summary>
        internal bool IsSetEmptyValue() => this.EmptyValue != null;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// String value type.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 4100)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;

        /// <summary>
        /// Gets and sets the property UserArnValue. 
        /// <para>
        /// Represents the user that performed the audit.
        /// </para>
        /// </summary>
        public string UserArnValue { get; set; }

        /// <summary>
        /// Checks to see if the UserArnValue property is set.
        /// </summary>
        internal bool IsSetUserArnValue() => this.UserArnValue != null;
    }
}
