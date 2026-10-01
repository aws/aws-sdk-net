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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Authentication method using OAuth2 providers. Supports Google, Apple, X, Telegram,
    /// and GitHub providers.
    /// </summary>
    public partial class LinkedAccountOAuth2
    {
        /// <summary>
        /// Gets and sets the property Apple. 
        /// <para>
        /// Apple OAuth2 authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuth2Authentication Apple { get; set; }

        /// <summary>
        /// Checks to see if the Apple property is set.
        /// </summary>
        internal bool IsSetApple() => this.Apple != null;

        /// <summary>
        /// Gets and sets the property Github. 
        /// <para>
        /// GitHub OAuth2 authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuth2Authentication Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property Google. 
        /// <para>
        /// Google OAuth2 authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuth2Authentication Google { get; set; }

        /// <summary>
        /// Checks to see if the Google property is set.
        /// </summary>
        internal bool IsSetGoogle() => this.Google != null;

        /// <summary>
        /// Gets and sets the property Telegram. 
        /// <para>
        /// Telegram OAuth2 authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuth2Authentication Telegram { get; set; }

        /// <summary>
        /// Checks to see if the Telegram property is set.
        /// </summary>
        internal bool IsSetTelegram() => this.Telegram != null;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// X (formerly Twitter) OAuth2 authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuth2Authentication X { get; set; }

        /// <summary>
        /// Checks to see if the X property is set.
        /// </summary>
        internal bool IsSetX() => this.X != null;
    }
}
