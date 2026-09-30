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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Defines password complexity requirements for users in a security group, including
    /// minimum length and character type requirements.
    /// </summary>
    public partial class PasswordRequirements
    {
        /// <summary>
        /// Gets and sets the property Lowercase. 
        /// <para>
        /// The minimum number of lowercase letters required in passwords.
        /// </para>
        /// </summary>
        public int? Lowercase { get; set; }

        /// <summary>
        /// Checks to see if the Lowercase property is set.
        /// </summary>
        internal bool IsSetLowercase() => this.Lowercase.HasValue;

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum password length in characters.
        /// </para>
        /// </summary>
        public int? MinLength { get; set; }

        /// <summary>
        /// Checks to see if the MinLength property is set.
        /// </summary>
        internal bool IsSetMinLength() => this.MinLength.HasValue;

        /// <summary>
        /// Gets and sets the property Numbers. 
        /// <para>
        /// The minimum number of numeric characters required in passwords.
        /// </para>
        /// </summary>
        public int? Numbers { get; set; }

        /// <summary>
        /// Checks to see if the Numbers property is set.
        /// </summary>
        internal bool IsSetNumbers() => this.Numbers.HasValue;

        /// <summary>
        /// Gets and sets the property Symbols. 
        /// <para>
        /// The minimum number of special symbol characters required in passwords.
        /// </para>
        /// </summary>
        public int? Symbols { get; set; }

        /// <summary>
        /// Checks to see if the Symbols property is set.
        /// </summary>
        internal bool IsSetSymbols() => this.Symbols.HasValue;

        /// <summary>
        /// Gets and sets the property Uppercase. 
        /// <para>
        /// The minimum number of uppercase letters required in passwords.
        /// </para>
        /// </summary>
        public int? Uppercase { get; set; }

        /// <summary>
        /// Checks to see if the Uppercase property is set.
        /// </summary>
        internal bool IsSetUppercase() => this.Uppercase.HasValue;
    }
}
