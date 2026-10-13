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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetRandomPassword operation. Generates a random
    /// password. We recommend that you specify the maximum length and include every character
    /// type that the system you are generating a password for can support. By default, Secrets
    /// Manager uses uppercase and lowercase letters, numbers, and the following characters
    /// in passwords: <c>!\"#$%&amp;'()*+,-./:;&lt;=>?@[\\]^_`{|}~</c> <para> Secrets Manager
    /// generates a CloudTrail log entry when you call this action. </para> <para> <b>Required
    /// permissions: </b> <c>secretsmanager:GetRandomPassword</c>. For more information, see
    /// <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. </para>
    /// </summary>
    public partial class GetRandomPasswordRequest : AmazonSecretsManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ExcludeCharacters. 
        /// <para>
        /// A string of the characters that you don't want in the password.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string ExcludeCharacters { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeCharacters property is set.
        /// </summary>
        internal bool IsSetExcludeCharacters() => this.ExcludeCharacters != null;

        /// <summary>
        /// Gets and sets the property ExcludeLowercase. 
        /// <para>
        /// Specifies whether to exclude lowercase letters from the password. If you don't include
        /// this switch, the password can contain lowercase letters.
        /// </para>
        /// </summary>
        public bool? ExcludeLowercase { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeLowercase property is set.
        /// </summary>
        internal bool IsSetExcludeLowercase() => this.ExcludeLowercase.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludeNumbers. 
        /// <para>
        /// Specifies whether to exclude numbers from the password. If you don't include this
        /// switch, the password can contain numbers.
        /// </para>
        /// </summary>
        public bool? ExcludeNumbers { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeNumbers property is set.
        /// </summary>
        internal bool IsSetExcludeNumbers() => this.ExcludeNumbers.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludePunctuation. 
        /// <para>
        /// Specifies whether to exclude the following punctuation characters from the password:
        /// <c>! " # $ % &amp; ' ( ) * + , - . / : ; &lt; = > ? @ [ \ ] ^ _ ` { | } ~</c>. If
        /// you don't include this switch, the password can contain punctuation.
        /// </para>
        /// </summary>
        public bool? ExcludePunctuation { get; set; }

        /// <summary>
        /// Checks to see if the ExcludePunctuation property is set.
        /// </summary>
        internal bool IsSetExcludePunctuation() => this.ExcludePunctuation.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludeUppercase. 
        /// <para>
        /// Specifies whether to exclude uppercase letters from the password. If you don't include
        /// this switch, the password can contain uppercase letters.
        /// </para>
        /// </summary>
        public bool? ExcludeUppercase { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeUppercase property is set.
        /// </summary>
        internal bool IsSetExcludeUppercase() => this.ExcludeUppercase.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeSpace. 
        /// <para>
        /// Specifies whether to include the space character. If you include this switch, the
        /// password can contain space characters.
        /// </para>
        /// </summary>
        public bool? IncludeSpace { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSpace property is set.
        /// </summary>
        internal bool IsSetIncludeSpace() => this.IncludeSpace.HasValue;

        /// <summary>
        /// Gets and sets the property PasswordLength. 
        /// <para>
        /// The length of the password. If you don't include this parameter, the default length
        /// is 32 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public long? PasswordLength { get; set; }

        /// <summary>
        /// Checks to see if the PasswordLength property is set.
        /// </summary>
        internal bool IsSetPasswordLength() => this.PasswordLength.HasValue;

        /// <summary>
        /// Gets and sets the property RequireEachIncludedType. 
        /// <para>
        /// Specifies whether to include at least one upper and lowercase letter, one number,
        /// and one punctuation. If you don't include this switch, the password contains at least
        /// one of every character type.
        /// </para>
        /// </summary>
        public bool? RequireEachIncludedType { get; set; }

        /// <summary>
        /// Checks to see if the RequireEachIncludedType property is set.
        /// </summary>
        internal bool IsSetRequireEachIncludedType() => this.RequireEachIncludedType.HasValue;
    }
}
