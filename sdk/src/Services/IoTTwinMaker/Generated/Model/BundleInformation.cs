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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Information about the pricing bundle.
    /// </summary>
    public partial class BundleInformation
    {
        private List<string> _bundleNames = new List<string>();
        private PricingTier _pricingTier;

        /// <summary>
        /// Gets and sets the property BundleNames. 
        /// <para>
        /// The bundle names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> BundleNames
        {
            get { return this._bundleNames; }
            set { this._bundleNames = value; }
        }

        // Check to see if BundleNames property is set
        internal bool IsSetBundleNames()
        {
            return this._bundleNames != null && this._bundleNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PricingTier. 
        /// <para>
        /// The pricing tier.
        /// </para>
        /// </summary>
        public PricingTier PricingTier
        {
            get { return this._pricingTier; }
            set { this._pricingTier = value; }
        }

        // Check to see if PricingTier property is set
        internal bool IsSetPricingTier()
        {
            return this._pricingTier != null;
        }

    }
}