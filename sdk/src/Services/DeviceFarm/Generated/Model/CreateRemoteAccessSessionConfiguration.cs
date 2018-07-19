/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Configuration settings for a remote access session, including billing method.
    /// </summary>
    public partial class CreateRemoteAccessSessionConfiguration
    {
        private BillingMethod _billingMethod;
        private List<string> _vpceConfigurationArns = new List<string>();

        /// <summary>
        /// Gets and sets the property BillingMethod. 
        /// <para>
        /// The billing method for the remote access session.
        /// </para>
        /// </summary>
        public BillingMethod BillingMethod
        {
            get { return this._billingMethod; }
            set { this._billingMethod = value; }
        }

        // Check to see if BillingMethod property is set
        internal bool IsSetBillingMethod()
        {
            return this._billingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property VpceConfigurationArns. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) included in the VPC endpoint configuration.
        /// </para>
        /// </summary>
        public List<string> VpceConfigurationArns
        {
            get { return this._vpceConfigurationArns; }
            set { this._vpceConfigurationArns = value; }
        }

        // Check to see if VpceConfigurationArns property is set
        internal bool IsSetVpceConfigurationArns()
        {
            return this._vpceConfigurationArns != null && this._vpceConfigurationArns.Count > 0; 
        }

    }
}