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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a Wickr network with all its configuration and status information.
    /// </summary>
    public partial class Network
    {
        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The access level of the network (STANDARD or PREMIUM), which determines available
        /// features and capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Checks to see if the AccessLevel property is set.
        /// </summary>
        internal bool IsSetAccessLevel() => this.AccessLevel != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS customer managed key used for encrypting sensitive
        /// data in the network.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property FreeTrialExpiration. 
        /// <para>
        /// The expiration date and time for the network's free trial period, if applicable.
        /// </para>
        /// </summary>
        public string FreeTrialExpiration { get; set; }

        /// <summary>
        /// Checks to see if the FreeTrialExpiration property is set.
        /// </summary>
        internal bool IsSetFreeTrialExpiration() => this.FreeTrialExpiration != null;

        /// <summary>
        /// Gets and sets the property MigrationState. 
        /// <para>
        /// The SSO redirect URI migration state, managed by the SSO redirect migration wizard.
        /// Values: 0 (not started), 1 (in progress), or 2 (completed).
        /// </para>
        /// </summary>
        public int? MigrationState { get; set; }

        /// <summary>
        /// Checks to see if the MigrationState property is set.
        /// </summary>
        internal bool IsSetMigrationState() => this.MigrationState.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkArn property is set.
        /// </summary>
        internal bool IsSetNetworkArn() => this.NetworkArn != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property NetworkName. 
        /// <para>
        /// The name of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkName property is set.
        /// </summary>
        internal bool IsSetNetworkName() => this.NetworkName != null;

        /// <summary>
        /// Gets and sets the property Standing. 
        /// <para>
        /// The current standing or status of the network.
        /// </para>
        /// </summary>
        public int? Standing { get; set; }

        /// <summary>
        /// Checks to see if the Standing property is set.
        /// </summary>
        internal bool IsSetStanding() => this.Standing.HasValue;
    }
}
