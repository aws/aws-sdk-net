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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the GetNetwork operation.
    /// </summary>
    public partial class GetNetworkResponse : AmazonWebServiceResponse
    {
        private AccessLevel _accessLevel;
        private string _awsAccountId;
        private string _encryptionKeyArn;
        private string _freeTrialExpiration;
        private int? _migrationState;
        private string _networkArn;
        private string _networkId;
        private string _networkName;
        private int? _standing;

        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The access level of the network (STANDARD or PREMIUM), which determines available
        /// features and capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessLevel AccessLevel
        {
            get { return this._accessLevel; }
            set { this._accessLevel = value; }
        }

        // Check to see if AccessLevel property is set
        internal bool IsSetAccessLevel()
        {
            return this._accessLevel != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS customer managed key used for encrypting sensitive
        /// data in the network.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property FreeTrialExpiration. 
        /// <para>
        /// The expiration date and time for the network's free trial period, if applicable.
        /// </para>
        /// </summary>
        public string FreeTrialExpiration
        {
            get { return this._freeTrialExpiration; }
            set { this._freeTrialExpiration = value; }
        }

        // Check to see if FreeTrialExpiration property is set
        internal bool IsSetFreeTrialExpiration()
        {
            return this._freeTrialExpiration != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationState. 
        /// <para>
        /// The SSO redirect URI migration state, managed by the SSO redirect migration wizard.
        /// Values: 0 (not started), 1 (in progress), or 2 (completed).
        /// </para>
        /// </summary>
        public int? MigrationState
        {
            get { return this._migrationState; }
            set { this._migrationState = value; }
        }

        // Check to see if MigrationState property is set
        internal bool IsSetMigrationState()
        {
            return this._migrationState.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkArn
        {
            get { return this._networkArn; }
            set { this._networkArn = value; }
        }

        // Check to see if NetworkArn property is set
        internal bool IsSetNetworkArn()
        {
            return this._networkArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkName. 
        /// <para>
        /// The name of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkName
        {
            get { return this._networkName; }
            set { this._networkName = value; }
        }

        // Check to see if NetworkName property is set
        internal bool IsSetNetworkName()
        {
            return this._networkName != null;
        }

        /// <summary>
        /// Gets and sets the property Standing. 
        /// <para>
        /// The current standing or status of the network.
        /// </para>
        /// </summary>
        public int? Standing
        {
            get { return this._standing; }
            set { this._standing = value; }
        }

        // Check to see if Standing property is set
        internal bool IsSetStanding()
        {
            return this._standing.HasValue; 
        }

    }
}