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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkSite operation.
    /// Deletes the specified network site. Return the hardware after you delete the network
    /// site. You are responsible for minimum charges. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/hardware-maintenance.html">Hardware
    /// returns</a> in the <i>Amazon Web Services Private 5G User Guide</i>.
    /// </summary>
    public partial class DeleteNetworkSiteRequest : AmazonPrivate5GRequest
    {
        private string _clientToken;
        private string _networkSiteArn;

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

    }
}