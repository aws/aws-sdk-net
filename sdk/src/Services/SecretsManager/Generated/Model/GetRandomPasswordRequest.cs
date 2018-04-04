/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetRandomPassword operation.
    /// Generates a random password of the specified complexity. This operation is intended
    /// for use in the Lambda rotation function. Per best practice, we recommend that you
    /// specify the maximum length and include every character type that the system you are
    /// generating a password for can support.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:GetRandomPassword
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetRandomPasswordRequest : AmazonSecretsManagerRequest
    {
        private string _excludeCharacters;
        private bool? _excludeLowercase;
        private bool? _excludeNumbers;
        private bool? _excludePunctuation;
        private bool? _excludeUppercase;
        private bool? _includeSpace;
        private long? _passwordLength;
        private bool? _requireEachIncludedType;

        /// <summary>
        /// Gets and sets the property ExcludeCharacters. 
        /// <para>
        /// A string that includes characters that should not be included in the generated password.
        /// The default is that all characters from the included sets can be used.
        /// </para>
        /// </summary>
        public string ExcludeCharacters
        {
            get { return this._excludeCharacters; }
            set { this._excludeCharacters = value; }
        }

        // Check to see if ExcludeCharacters property is set
        internal bool IsSetExcludeCharacters()
        {
            return this._excludeCharacters != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeLowercase. 
        /// <para>
        /// Specifies that the generated password should not include lowercase letters. The default
        /// if you do not include this switch parameter is that lowercase letters can be included.
        /// </para>
        /// </summary>
        public bool ExcludeLowercase
        {
            get { return this._excludeLowercase.GetValueOrDefault(); }
            set { this._excludeLowercase = value; }
        }

        // Check to see if ExcludeLowercase property is set
        internal bool IsSetExcludeLowercase()
        {
            return this._excludeLowercase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeNumbers. 
        /// <para>
        /// Specifies that the generated password should not include digits. The default if you
        /// do not include this switch parameter is that digits can be included.
        /// </para>
        /// </summary>
        public bool ExcludeNumbers
        {
            get { return this._excludeNumbers.GetValueOrDefault(); }
            set { this._excludeNumbers = value; }
        }

        // Check to see if ExcludeNumbers property is set
        internal bool IsSetExcludeNumbers()
        {
            return this._excludeNumbers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludePunctuation. 
        /// <para>
        /// Specifies that the generated password should not include punctuation characters. The
        /// default if you do not include this switch parameter is that punctuation characters
        /// can be included.
        /// </para>
        /// </summary>
        public bool ExcludePunctuation
        {
            get { return this._excludePunctuation.GetValueOrDefault(); }
            set { this._excludePunctuation = value; }
        }

        // Check to see if ExcludePunctuation property is set
        internal bool IsSetExcludePunctuation()
        {
            return this._excludePunctuation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeUppercase. 
        /// <para>
        /// Specifies that the generated password should not include uppercase letters. The default
        /// if you do not include this switch parameter is that uppercase letters can be included.
        /// </para>
        /// </summary>
        public bool ExcludeUppercase
        {
            get { return this._excludeUppercase.GetValueOrDefault(); }
            set { this._excludeUppercase = value; }
        }

        // Check to see if ExcludeUppercase property is set
        internal bool IsSetExcludeUppercase()
        {
            return this._excludeUppercase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeSpace. 
        /// <para>
        /// Specifies that the generated password can include the space character. The default
        /// if you do not include this switch parameter is that the space character is not included.
        /// </para>
        /// </summary>
        public bool IncludeSpace
        {
            get { return this._includeSpace.GetValueOrDefault(); }
            set { this._includeSpace = value; }
        }

        // Check to see if IncludeSpace property is set
        internal bool IsSetIncludeSpace()
        {
            return this._includeSpace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordLength. 
        /// <para>
        /// The desired length of the generated password. The default value if you do not include
        /// this parameter is 32 characters.
        /// </para>
        /// </summary>
        public long PasswordLength
        {
            get { return this._passwordLength.GetValueOrDefault(); }
            set { this._passwordLength = value; }
        }

        // Check to see if PasswordLength property is set
        internal bool IsSetPasswordLength()
        {
            return this._passwordLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireEachIncludedType. 
        /// <para>
        /// A boolean value that specifies whether the generated password must include at least
        /// one of every allowed character type. The default value is <code>True</code> and the
        /// operation requires at least one of every character type.
        /// </para>
        /// </summary>
        public bool RequireEachIncludedType
        {
            get { return this._requireEachIncludedType.GetValueOrDefault(); }
            set { this._requireEachIncludedType = value; }
        }

        // Check to see if RequireEachIncludedType property is set
        internal bool IsSetRequireEachIncludedType()
        {
            return this._requireEachIncludedType.HasValue; 
        }

    }
}