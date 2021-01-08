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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the WithdrawByoipCidr operation.
    /// Stops advertising an address range that is provisioned as an address pool. You can
    /// perform this operation at most once every 10 seconds, even if you specify different
    /// address ranges each time.
    /// 
    ///  
    /// <para>
    /// It can take a few minutes before traffic to the specified addresses stops routing
    /// to AWS because of propagation delays.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
    /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class WithdrawByoipCidrRequest : AmazonGlobalAcceleratorRequest
    {
        private string _cidr;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The address range, in CIDR notation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

    }
}