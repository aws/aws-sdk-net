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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Indicates whether the user requires a password to authenticate.
    /// </summary>
    public partial class Authentication
    {
        private int? _passwordCount;
        private AuthenticationType _type;

        /// <summary>
        /// Gets and sets the property PasswordCount. 
        /// <para>
        /// The number of passwords belonging to the user. The maximum is two.
        /// </para>
        /// </summary>
        public int? PasswordCount
        {
            get { return this._passwordCount; }
            set { this._passwordCount = value; }
        }

        // Check to see if PasswordCount property is set
        internal bool IsSetPasswordCount()
        {
            return this._passwordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the user requires a password to authenticate.
        /// </para>
        /// </summary>
        public AuthenticationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}