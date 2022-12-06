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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// The possible Amazon Web Services Free Tier configurations.
    /// </summary>
    public partial class UpdateFreeTierConfig
    {
        private bool? _activated;

        /// <summary>
        /// Gets and sets the property Activated. 
        /// <para>
        ///  Activate or deactivate application of Amazon Web Services Free Tier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Activated
        {
            get { return this._activated.GetValueOrDefault(); }
            set { this._activated = value; }
        }

        // Check to see if Activated property is set
        internal bool IsSetActivated()
        {
            return this._activated.HasValue; 
        }

    }
}