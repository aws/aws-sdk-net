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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Condensed information about a trust provider.
    /// </summary>
    public partial class VerifiedAccessTrustProviderCondensed
    {
        private string _description;
        private DeviceTrustProviderType _deviceTrustProviderType;
        private TrustProviderType _trustProviderType;
        private UserTrustProviderType _userTrustProviderType;
        private string _verifiedAccessTrustProviderId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of trust provider.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTrustProviderType. 
        /// <para>
        /// The type of device-based trust provider.
        /// </para>
        /// </summary>
        public DeviceTrustProviderType DeviceTrustProviderType
        {
            get { return this._deviceTrustProviderType; }
            set { this._deviceTrustProviderType = value; }
        }

        // Check to see if DeviceTrustProviderType property is set
        internal bool IsSetDeviceTrustProviderType()
        {
            return this._deviceTrustProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of trust provider (user- or device-based).
        /// </para>
        /// </summary>
        public TrustProviderType TrustProviderType
        {
            get { return this._trustProviderType; }
            set { this._trustProviderType = value; }
        }

        // Check to see if TrustProviderType property is set
        internal bool IsSetTrustProviderType()
        {
            return this._trustProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property UserTrustProviderType. 
        /// <para>
        /// The type of user-based trust provider.
        /// </para>
        /// </summary>
        public UserTrustProviderType UserTrustProviderType
        {
            get { return this._userTrustProviderType; }
            set { this._userTrustProviderType = value; }
        }

        // Check to see if UserTrustProviderType property is set
        internal bool IsSetUserTrustProviderType()
        {
            return this._userTrustProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the trust provider.
        /// </para>
        /// </summary>
        public string VerifiedAccessTrustProviderId
        {
            get { return this._verifiedAccessTrustProviderId; }
            set { this._verifiedAccessTrustProviderId = value; }
        }

        // Check to see if VerifiedAccessTrustProviderId property is set
        internal bool IsSetVerifiedAccessTrustProviderId()
        {
            return this._verifiedAccessTrustProviderId != null;
        }

    }
}