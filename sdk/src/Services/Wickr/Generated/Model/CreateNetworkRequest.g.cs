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
    /// Container for the parameters to the CreateNetwork operation. Creates a new Wickr network
    /// with specified access level and configuration. This operation provisions a new communication
    /// network for your organization.
    /// </summary>
    public partial class CreateNetworkRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The access level for the network. Valid values are STANDARD or PREMIUM, which determine
        /// the features and capabilities available to network members.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Checks to see if the AccessLevel property is set.
        /// </summary>
        internal bool IsSetAccessLevel() => this.AccessLevel != null;

        /// <summary>
        /// Gets and sets the property EnablePremiumFreeTrial. 
        /// <para>
        /// Specifies whether to enable a premium free trial for the network. It is optional and
        /// has a default value as false. When set to true, the network starts with premium features
        /// for a limited trial period. 
        /// </para>
        /// </summary>
        public bool? EnablePremiumFreeTrial { get; set; }

        /// <summary>
        /// Checks to see if the EnablePremiumFreeTrial property is set.
        /// </summary>
        internal bool IsSetEnablePremiumFreeTrial() => this.EnablePremiumFreeTrial.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS customer managed key to use for encrypting
        /// sensitive data in the network.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property NetworkName. 
        /// <para>
        /// The name for the new network. Must be between 1 and 20 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkName property is set.
        /// </summary>
        internal bool IsSetNetworkName() => this.NetworkName != null;
    }
}
