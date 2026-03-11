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
    /// Container for the parameters to the CreateNetwork operation.
    /// Creates a new Wickr network with specified access level and configuration. This operation
    /// provisions a new communication network for your organization.
    /// </summary>
    public partial class CreateNetworkRequest : AmazonWickrRequest
    {
        private AccessLevel _accessLevel;
        private bool? _enablePremiumFreeTrial;
        private string _encryptionKeyArn;
        private string _networkName;

        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The access level for the network. Valid values are STANDARD or PREMIUM, which determine
        /// the features and capabilities available to network members.
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
        /// Gets and sets the property EnablePremiumFreeTrial. 
        /// <para>
        /// Specifies whether to enable a premium free trial for the network. It is optional and
        /// has a default value as false. When set to true, the network starts with premium features
        /// for a limited trial period. 
        /// </para>
        /// </summary>
        public bool? EnablePremiumFreeTrial
        {
            get { return this._enablePremiumFreeTrial; }
            set { this._enablePremiumFreeTrial = value; }
        }

        // Check to see if EnablePremiumFreeTrial property is set
        internal bool IsSetEnablePremiumFreeTrial()
        {
            return this._enablePremiumFreeTrial.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS customer managed key to use for encrypting
        /// sensitive data in the network.
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
        /// Gets and sets the property NetworkName. 
        /// <para>
        /// The name for the new network. Must be between 1 and 20 characters.
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

    }
}