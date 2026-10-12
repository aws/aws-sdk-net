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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAutonomousDatabaseWallet operation. Creates
    /// a new wallet for the specified Autonomous Database.
    /// </summary>
    public partial class CreateAutonomousDatabaseWalletRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database to create a wallet for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string AutonomousDatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseId property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseId() => this.AutonomousDatabaseId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-provided token to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password to encrypt the keys inside the wallet.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 8)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property PasswordSource. 
        /// <para>
        /// The source of the password for encrypting the wallet. When set to <c>CUSTOMER_MANAGED_AWS_SECRET</c>,
        /// the password is retrieved from an Amazon Web Services Secrets Manager secret.
        /// </para>
        /// </summary>
        public WalletPasswordSource PasswordSource { get; set; }

        /// <summary>
        /// Checks to see if the PasswordSource property is set.
        /// </summary>
        internal bool IsSetPasswordSource() => this.PasswordSource != null;

        /// <summary>
        /// Gets and sets the property PasswordSourceConfiguration. 
        /// <para>
        /// The configuration of the password source for the Autonomous Database wallet.
        /// </para>
        /// </summary>
        public WalletPasswordSourceConfigurationInput PasswordSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PasswordSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetPasswordSourceConfiguration() => this.PasswordSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property WalletType. 
        /// <para>
        /// The type of wallet to create, either a regional wallet or an instance wallet.
        /// </para>
        /// </summary>
        public WalletType WalletType { get; set; }

        /// <summary>
        /// Checks to see if the WalletType property is set.
        /// </summary>
        internal bool IsSetWalletType() => this.WalletType != null;
    }
}
