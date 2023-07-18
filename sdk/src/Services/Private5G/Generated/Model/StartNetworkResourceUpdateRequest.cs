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
    /// Container for the parameters to the StartNetworkResourceUpdate operation.
    /// Use this action to do the following tasks:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Update the duration and renewal status of the commitment period for a radio unit.
    /// The update goes into effect immediately.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Request a replacement for a network resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Request that you return a network resource.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you submit a request to replace or return a network resource, the status of
    /// the network resource changes to <code>CREATING_SHIPPING_LABEL</code>. The shipping
    /// label is available when the status of the network resource is <code>PENDING_RETURN</code>.
    /// After the network resource is successfully returned, its status changes to <code>DELETED</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
    /// a radio unit</a>.
    /// </para>
    /// </summary>
    public partial class StartNetworkResourceUpdateRequest : AmazonPrivate5GRequest
    {
        private CommitmentConfiguration _commitmentConfiguration;
        private string _networkResourceArn;
        private string _returnReason;
        private Address _shippingAddress;
        private UpdateType _updateType;

        /// <summary>
        /// Gets and sets the property CommitmentConfiguration. 
        /// <para>
        /// Use this action to extend and automatically renew the commitment period for the radio
        /// unit. You can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Change a 60-day commitment to a 1-year or 3-year commitment. The change is immediate
        /// and the hourly rate decreases to the rate for the new commitment period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change a 1-year commitment to a 3-year commitment. The change is immediate and the
        /// hourly rate decreases to the rate for the 3-year commitment period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set a 1-year commitment to automatically renew for an additional 1 year. The hourly
        /// rate for the additional year will continue to be the same as your existing 1-year
        /// rate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set a 3-year commitment to automatically renew for an additional 1 year. The hourly
        /// rate for the additional year will continue to be the same as your existing 3-year
        /// rate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Turn off a previously-enabled automatic renewal on a 1-year or 3-year commitment.
        /// You cannot use the automatic-renewal option for a 60-day commitment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For pricing, see <a href="http://aws.amazon.com/private5g/pricing">Amazon Web Services
        /// Private 5G Pricing</a>.
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
        /// Gets and sets the property NetworkResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkResourceArn
        {
            get { return this._networkResourceArn; }
            set { this._networkResourceArn = value; }
        }

        // Check to see if NetworkResourceArn property is set
        internal bool IsSetNetworkResourceArn()
        {
            return this._networkResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnReason. 
        /// <para>
        /// The reason for the return. Providing a reason for a return is optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ReturnReason
        {
            get { return this._returnReason; }
            set { this._returnReason = value; }
        }

        // Check to see if ReturnReason property is set
        internal bool IsSetReturnReason()
        {
            return this._returnReason != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// The shipping address. If you don't provide a shipping address when replacing or returning
        /// a network resource, we use the address from the original order for the network resource.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The update type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLACE</code> - Submits a request to replace a defective radio unit. We provide
        /// a shipping label that you can use for the return process and we ship a replacement
        /// radio unit to you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RETURN</code> - Submits a request to return a radio unit that you no longer
        /// need. We provide a shipping label that you can use for the return process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMMITMENT</code> - Submits a request to change or renew the commitment period.
        /// If you choose this value, then you must set <a href="https://docs.aws.amazon.com/private-networks/latest/APIReference/API_StartNetworkResourceUpdate.html#privatenetworks-StartNetworkResourceUpdate-request-commitmentConfiguration">
        /// <code>commitmentConfiguration</code> </a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}