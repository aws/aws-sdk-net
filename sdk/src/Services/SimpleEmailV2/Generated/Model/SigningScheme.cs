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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Specifies the signing scheme to apply to messages sent with a configuration set. This
    /// is a union type, so you specify exactly one of its members.
    /// </summary>
    public partial class SigningScheme
    {
        private DefaultSigningScheme _defaultScheme;
        private SmimeSigningScheme _smimeScheme;

        /// <summary>
        /// Gets and sets the property DefaultScheme. 
        /// <para>
        /// Use the default signing behavior. When you select this option, Amazon SES API v2 doesn't
        /// add an S/MIME signature to messages sent with the configuration set.
        /// </para>
        /// </summary>
        public DefaultSigningScheme DefaultScheme
        {
            get { return this._defaultScheme; }
            set { this._defaultScheme = value; }
        }

        // Check to see if DefaultScheme property is set
        internal bool IsSetDefaultScheme()
        {
            return this._defaultScheme != null;
        }

        /// <summary>
        /// Gets and sets the property SmimeScheme. 
        /// <para>
        /// Sign messages sent with the configuration set using S/MIME. For signing to apply,
        /// the email identity used to send a message must have an active S/MIME certificate association.
        /// </para>
        /// </summary>
        public SmimeSigningScheme SmimeScheme
        {
            get { return this._smimeScheme; }
            set { this._smimeScheme = value; }
        }

        // Check to see if SmimeScheme property is set
        internal bool IsSetSmimeScheme()
        {
            return this._smimeScheme != null;
        }

    }
}