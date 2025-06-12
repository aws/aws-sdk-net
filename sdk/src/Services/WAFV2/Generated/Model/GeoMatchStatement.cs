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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement that labels web requests by country and region and that matches against
    /// web requests based on country code. A geo match rule labels every request that it
    /// inspects regardless of whether it finds a match.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// To manage requests only by country, you can use this statement by itself and specify
    /// the countries that you want to match against in the <c>CountryCodes</c> array. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Otherwise, configure your geo match rule with Count action so that it only labels
    /// requests. Then, add one or more label match rules to run after the geo match rule
    /// and configure them to match against the geographic labels and handle the requests
    /// as needed. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// WAF labels requests using the alpha-2 country and region codes from the International
    /// Organization for Standardization (ISO) 3166 standard. WAF determines the codes using
    /// either the IP address in the web request origin or, if you specify it, the address
    /// in the geo match <c>ForwardedIPConfig</c>. 
    /// </para>
    ///  
    /// <para>
    /// If you use the web request origin, the label formats are <c>awswaf:clientip:geo:region:&lt;ISO
    /// country code&gt;-&lt;ISO region code&gt;</c> and <c>awswaf:clientip:geo:country:&lt;ISO
    /// country code&gt;</c>.
    /// </para>
    ///  
    /// <para>
    /// If you use a forwarded IP address, the label formats are <c>awswaf:forwardedip:geo:region:&lt;ISO
    /// country code&gt;-&lt;ISO region code&gt;</c> and <c>awswaf:forwardedip:geo:country:&lt;ISO
    /// country code&gt;</c>.
    /// </para>
    ///  
    /// <para>
    /// For additional details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-type-geo-match.html">Geographic
    /// match rule statement</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
    /// Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial class GeoMatchStatement
    {
        private List<string> _countryCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ForwardedIPConfig _forwardedIPConfig;

        /// <summary>
        /// Gets and sets the property CountryCodes. 
        /// <para>
        /// An array of two-character country codes that you want to match against, for example,
        /// <c>[ "US", "CN" ]</c>, from the alpha-2 country ISO codes of the ISO 3166 international
        /// standard. 
        /// </para>
        ///  
        /// <para>
        /// When you use a geo match statement just for the region and country labels that it
        /// adds to requests, you still have to supply a country code for the rule to evaluate.
        /// In this case, you configure the rule to only count matching requests, but it will
        /// still generate logging and count metrics for any matches. You can reduce the logging
        /// and metrics that the rule produces by specifying a country that's unlikely to be a
        /// source of traffic to your site.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> CountryCodes
        {
            get { return this._countryCodes; }
            set { this._countryCodes = value; }
        }

        // Check to see if CountryCodes property is set
        internal bool IsSetCountryCodes()
        {
            return this._countryCodes != null && (this._countryCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ForwardedIPConfig. 
        /// <para>
        /// The configuration for inspecting IP addresses in an HTTP header that you specify,
        /// instead of using the IP address that's reported by the web request origin. Commonly,
        /// this is the X-Forwarded-For (XFF) header, but you can specify any header name. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the specified header isn't present in the request, WAF doesn't apply the rule to
        /// the web request at all.
        /// </para>
        ///  </note>
        /// </summary>
        public ForwardedIPConfig ForwardedIPConfig
        {
            get { return this._forwardedIPConfig; }
            set { this._forwardedIPConfig = value; }
        }

        // Check to see if ForwardedIPConfig property is set
        internal bool IsSetForwardedIPConfig()
        {
            return this._forwardedIPConfig != null;
        }

    }
}