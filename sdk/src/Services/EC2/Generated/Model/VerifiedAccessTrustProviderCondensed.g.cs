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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Condensed information about a trust provider.
    /// </summary>
    public partial class VerifiedAccessTrustProviderCondensed
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of trust provider.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceTrustProviderType. 
        /// <para>
        /// The type of device-based trust provider.
        /// </para>
        /// </summary>
        public DeviceTrustProviderType DeviceTrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTrustProviderType property is set.
        /// </summary>
        internal bool IsSetDeviceTrustProviderType() => this.DeviceTrustProviderType != null;

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of trust provider (user- or device-based).
        /// </para>
        /// </summary>
        public TrustProviderType TrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the TrustProviderType property is set.
        /// </summary>
        internal bool IsSetTrustProviderType() => this.TrustProviderType != null;

        /// <summary>
        /// Gets and sets the property UserTrustProviderType. 
        /// <para>
        /// The type of user-based trust provider.
        /// </para>
        /// </summary>
        public UserTrustProviderType UserTrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the UserTrustProviderType property is set.
        /// </summary>
        internal bool IsSetUserTrustProviderType() => this.UserTrustProviderType != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the trust provider.
        /// </para>
        /// </summary>
        public string VerifiedAccessTrustProviderId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessTrustProviderId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessTrustProviderId() => this.VerifiedAccessTrustProviderId != null;
    }
}
