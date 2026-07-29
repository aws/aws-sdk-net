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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of the password source configuration for an Autonomous Database wallet.
    /// </summary>
    public partial class WalletPasswordSourceSummary
    {
        private WalletPasswordSource _passwordSource;
        private WalletPasswordSourceConfiguration _passwordSourceConfiguration;

        /// <summary>
        /// Gets and sets the property PasswordSource. 
        /// <para>
        /// The source of the password for the Autonomous Database wallet.
        /// </para>
        /// </summary>
        public WalletPasswordSource PasswordSource
        {
            get { return this._passwordSource; }
            set { this._passwordSource = value; }
        }

        // Check to see if PasswordSource property is set
        internal bool IsSetPasswordSource()
        {
            return this._passwordSource != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordSourceConfiguration. 
        /// <para>
        /// The configuration of the password source for the Autonomous Database wallet.
        /// </para>
        /// </summary>
        public WalletPasswordSourceConfiguration PasswordSourceConfiguration
        {
            get { return this._passwordSourceConfiguration; }
            set { this._passwordSourceConfiguration = value; }
        }

        // Check to see if PasswordSourceConfiguration property is set
        internal bool IsSetPasswordSourceConfiguration()
        {
            return this._passwordSourceConfiguration != null;
        }

    }
}