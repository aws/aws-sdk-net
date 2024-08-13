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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetRandomPassword operation.
    /// Generates a random password. We recommend that you specify the maximum length and
    /// include every character type that the system you are generating a password for can
    /// support. By default, Secrets Manager uses uppercase and lowercase letters, numbers,
    /// and the following characters in passwords: <c>!\"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\\]^_`{|}~</c>
    /// 
    /// 
    ///  
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>secretsmanager:GetRandomPassword</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
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
        /// A string of the characters that you don't want in the password.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
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
        /// Specifies whether to exclude lowercase letters from the password. If you don't include
        /// this switch, the password can contain lowercase letters.
        /// </para>
        /// </summary>
        public bool? ExcludeLowercase
        {
            get { return this._excludeLowercase; }
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
        /// Specifies whether to exclude numbers from the password. If you don't include this
        /// switch, the password can contain numbers.
        /// </para>
        /// </summary>
        public bool? ExcludeNumbers
        {
            get { return this._excludeNumbers; }
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
        /// Specifies whether to exclude the following punctuation characters from the password:
        /// <c>! " # $ % &amp; ' ( ) * + , - . / : ; &lt; = &gt; ? @ [ \ ] ^ _ ` { | } ~</c>.
        /// If you don't include this switch, the password can contain punctuation.
        /// </para>
        /// </summary>
        public bool? ExcludePunctuation
        {
            get { return this._excludePunctuation; }
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
        /// Specifies whether to exclude uppercase letters from the password. If you don't include
        /// this switch, the password can contain uppercase letters.
        /// </para>
        /// </summary>
        public bool? ExcludeUppercase
        {
            get { return this._excludeUppercase; }
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
        /// Specifies whether to include the space character. If you include this switch, the
        /// password can contain space characters.
        /// </para>
        /// </summary>
        public bool? IncludeSpace
        {
            get { return this._includeSpace; }
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
        /// The length of the password. If you don't include this parameter, the default length
        /// is 32 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public long? PasswordLength
        {
            get { return this._passwordLength; }
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
        /// Specifies whether to include at least one upper and lowercase letter, one number,
        /// and one punctuation. If you don't include this switch, the password contains at least
        /// one of every character type.
        /// </para>
        /// </summary>
        public bool? RequireEachIncludedType
        {
            get { return this._requireEachIncludedType; }
            set { this._requireEachIncludedType = value; }
        }

        // Check to see if RequireEachIncludedType property is set
        internal bool IsSetRequireEachIncludedType()
        {
            return this._requireEachIncludedType.HasValue; 
        }

    }
}