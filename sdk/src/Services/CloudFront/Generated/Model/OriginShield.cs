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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// CloudFront Origin Shield.
    /// 
    ///  
    /// <para>
    /// Using Origin Shield can help reduce the load on your origin. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/origin-shield.html">Using
    /// Origin Shield</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class OriginShield
    {
        private bool? _enabled;
        private string _originShieldRegion;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A flag that specifies whether Origin Shield is enabled.
        /// </para>
        ///  
        /// <para>
        /// When it's enabled, CloudFront routes all requests through Origin Shield, which can
        /// help protect your origin. When it's disabled, CloudFront might send requests directly
        /// to your origin from multiple edge locations or regional edge caches.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginShieldRegion. 
        /// <para>
        /// The Amazon Web Services Region for Origin Shield.
        /// </para>
        ///  
        /// <para>
        /// Specify the Amazon Web Services Region that has the lowest latency to your origin.
        /// To specify a region, use the region code, not the region name. For example, specify
        /// the US East (Ohio) region as <code>us-east-2</code>.
        /// </para>
        ///  
        /// <para>
        /// When you enable CloudFront Origin Shield, you must specify the Amazon Web Services
        /// Region for Origin Shield. For the list of Amazon Web Services Regions that you can
        /// specify, and for help choosing the best Region for your origin, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/origin-shield.html#choose-origin-shield-region">Choosing
        /// the Amazon Web Services Region for Origin Shield</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string OriginShieldRegion
        {
            get { return this._originShieldRegion; }
            set { this._originShieldRegion = value; }
        }

        // Check to see if OriginShieldRegion property is set
        internal bool IsSetOriginShieldRegion()
        {
            return this._originShieldRegion != null;
        }

    }
}