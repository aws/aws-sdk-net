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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Container for the parameters to the ActivateNetworkSite operation.
    /// Activates the specified network site.
    /// </summary>
    public partial class ActivateNetworkSiteRequest : AmazonPrivate5GRequest
    {
        private string _clientToken;
        private CommitmentConfiguration _commitmentConfiguration;
        private string _networkSiteArn;
        private Address _shippingAddress;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property CommitmentConfiguration. 
        /// <para>
        /// Determines the duration and renewal status of the commitment period for all pending
        /// radio units.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>commitmentConfiguration</code> in the <code>ActivateNetworkSiteRequest</code>
        /// action, you must specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The commitment period for the radio unit. You can choose a 60-day, 1-year, or 3-year
        /// period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether you want your commitment period to automatically renew for one more year after
        /// your current commitment period expires.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For pricing, see <a href="http://aws.amazon.com/private5g/pricing">Amazon Web Services
        /// Private 5G Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include <code>commitmentConfiguration</code> in the <code>ActivateNetworkSiteRequest</code>
        /// action, the commitment period is set to 60-days.
        /// </para>
        /// </summary>
        public CommitmentConfiguration CommitmentConfiguration
        {
            get { return this._commitmentConfiguration; }
            set { this._commitmentConfiguration = value; }
        }

        // Check to see if CommitmentConfiguration property is set
        internal bool IsSetCommitmentConfiguration()
        {
            return this._commitmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSiteArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network site.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkSiteArn
        {
            get { return this._networkSiteArn; }
            set { this._networkSiteArn = value; }
        }

        // Check to see if NetworkSiteArn property is set
        internal bool IsSetNetworkSiteArn()
        {
            return this._networkSiteArn != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// The shipping address of the network site.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Address ShippingAddress
        {
            get { return this._shippingAddress; }
            set { this._shippingAddress = value; }
        }

        // Check to see if ShippingAddress property is set
        internal bool IsSetShippingAddress()
        {
            return this._shippingAddress != null;
        }

    }
}