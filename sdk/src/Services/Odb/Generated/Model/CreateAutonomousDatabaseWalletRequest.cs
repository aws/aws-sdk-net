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
    /// Container for the parameters to the CreateAutonomousDatabaseWallet operation.
    /// Creates a new wallet for the specified Autonomous Database.
    /// </summary>
    public partial class CreateAutonomousDatabaseWalletRequest : AmazonOdbRequest
    {
        private string _autonomousDatabaseId;
        private string _clientToken;
        private string _password;
        private WalletType _walletType;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database to create a wallet for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string AutonomousDatabaseId
        {
            get { return this._autonomousDatabaseId; }
            set { this._autonomousDatabaseId = value; }
        }

        // Check to see if AutonomousDatabaseId property is set
        internal bool IsSetAutonomousDatabaseId()
        {
            return this._autonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-provided token to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password to encrypt the keys inside the wallet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=8)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property WalletType. 
        /// <para>
        /// The type of wallet to create, either a regional wallet or an instance wallet.
        /// </para>
        /// </summary>
        public WalletType WalletType
        {
            get { return this._walletType; }
            set { this._walletType = value; }
        }

        // Check to see if WalletType property is set
        internal bool IsSetWalletType()
        {
            return this._walletType != null;
        }

    }
}