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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Contains the configuration for mapping user identities to Snowflake users, including
    /// the username attribute and optional prefix applied during the mapping.
    /// </summary>
    public partial class IdentityMapping
    {
        private string _prefix;
        private string _usernameAttribute;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix used for the identity mapping.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property UsernameAttribute. 
        /// <para>
        /// The username attribute used for the identity mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UsernameAttribute
        {
            get { return this._usernameAttribute; }
            set { this._usernameAttribute = value; }
        }

        // Check to see if UsernameAttribute property is set
        internal bool IsSetUsernameAttribute()
        {
            return this._usernameAttribute != null;
        }

    }
}