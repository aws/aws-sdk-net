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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for a token.
    /// 
    ///  <important> 
    /// <para>
    /// If you're using an Amazon Kendra Gen AI Enterprise Edition index and you try to use
    /// <c>UserTokenConfigurations</c> to configure user context policy, Amazon Kendra returns
    /// a <c>ValidationException</c> error.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UserTokenConfiguration
    {
        private JsonTokenTypeConfiguration _jsonTokenTypeConfiguration;
        private JwtTokenTypeConfiguration _jwtTokenTypeConfiguration;

        /// <summary>
        /// Gets and sets the property JsonTokenTypeConfiguration. 
        /// <para>
        /// Information about the JSON token type configuration.
        /// </para>
        /// </summary>
        public JsonTokenTypeConfiguration JsonTokenTypeConfiguration
        {
            get { return this._jsonTokenTypeConfiguration; }
            set { this._jsonTokenTypeConfiguration = value; }
        }

        // Check to see if JsonTokenTypeConfiguration property is set
        internal bool IsSetJsonTokenTypeConfiguration()
        {
            return this._jsonTokenTypeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JwtTokenTypeConfiguration. 
        /// <para>
        /// Information about the JWT token type configuration.
        /// </para>
        /// </summary>
        public JwtTokenTypeConfiguration JwtTokenTypeConfiguration
        {
            get { return this._jwtTokenTypeConfiguration; }
            set { this._jwtTokenTypeConfiguration = value; }
        }

        // Check to see if JwtTokenTypeConfiguration property is set
        internal bool IsSetJwtTokenTypeConfiguration()
        {
            return this._jwtTokenTypeConfiguration != null;
        }

    }
}