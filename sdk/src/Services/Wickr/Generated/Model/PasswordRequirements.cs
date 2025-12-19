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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private int? _lowercase;
        private int? _minLength;
        private int? _numbers;
        private int? _symbols;
        private int? _uppercase;

        /// <summary>
        /// Gets and sets the property Lowercase. 
        /// <para>
        /// The minimum number of lowercase letters required in passwords.
        /// </para>
        /// </summary>
        public int Lowercase
        {
            get { return this._lowercase.GetValueOrDefault(); }
            set { this._lowercase = value; }
        }

        // Check to see if Lowercase property is set
        internal bool IsSetLowercase()
        {
            return this._lowercase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum password length in characters.
        /// </para>
        /// </summary>
        public int MinLength
        {
            get { return this._minLength.GetValueOrDefault(); }
            set { this._minLength = value; }
        }

        // Check to see if MinLength property is set
        internal bool IsSetMinLength()
        {
            return this._minLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Numbers. 
        /// <para>
        /// The minimum number of numeric characters required in passwords.
        /// </para>
        /// </summary>
        public int Numbers
        {
            get { return this._numbers.GetValueOrDefault(); }
            set { this._numbers = value; }
        }

        // Check to see if Numbers property is set
        internal bool IsSetNumbers()
        {
            return this._numbers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Symbols. 
        /// <para>
        /// The minimum number of special symbol characters required in passwords.
        /// </para>
        /// </summary>
        public int Symbols
        {
            get { return this._symbols.GetValueOrDefault(); }
            set { this._symbols = value; }
        }

        // Check to see if Symbols property is set
        internal bool IsSetSymbols()
        {
            return this._symbols.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uppercase. 
        /// <para>
        /// The minimum number of uppercase letters required in passwords.
        /// </para>
        /// </summary>
        public int Uppercase
        {
            get { return this._uppercase.GetValueOrDefault(); }
            set { this._uppercase = value; }
        }

        // Check to see if Uppercase property is set
        internal bool IsSetUppercase()
        {
            return this._uppercase.HasValue; 
        }

    }
}