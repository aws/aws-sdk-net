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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The policies for a load balancer.
    /// </summary>
    public partial class Policies
    {
        private List<AppCookieStickinessPolicy> _appCookieStickinessPolicies = AWSConfigs.InitializeCollections ? new List<AppCookieStickinessPolicy>() : null;
        private List<LBCookieStickinessPolicy> _lbCookieStickinessPolicies = AWSConfigs.InitializeCollections ? new List<LBCookieStickinessPolicy>() : null;
        private List<string> _otherPolicies = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Policies() { }

        /// <summary>
        /// Gets and sets the property AppCookieStickinessPolicies. 
        /// <para>
        /// The stickiness policies created using <a>CreateAppCookieStickinessPolicy</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AppCookieStickinessPolicy> AppCookieStickinessPolicies
        {
            get { return this._appCookieStickinessPolicies; }
            set { this._appCookieStickinessPolicies = value; }
        }

        // Check to see if AppCookieStickinessPolicies property is set
        internal bool IsSetAppCookieStickinessPolicies()
        {
            return this._appCookieStickinessPolicies != null && (this._appCookieStickinessPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LBCookieStickinessPolicies. 
        /// <para>
        /// The stickiness policies created using <a>CreateLBCookieStickinessPolicy</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LBCookieStickinessPolicy> LBCookieStickinessPolicies
        {
            get { return this._lbCookieStickinessPolicies; }
            set { this._lbCookieStickinessPolicies = value; }
        }

        // Check to see if LBCookieStickinessPolicies property is set
        internal bool IsSetLBCookieStickinessPolicies()
        {
            return this._lbCookieStickinessPolicies != null && (this._lbCookieStickinessPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OtherPolicies. 
        /// <para>
        /// The policies other than the stickiness policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OtherPolicies
        {
            get { return this._otherPolicies; }
            set { this._otherPolicies = value; }
        }

        // Check to see if OtherPolicies property is set
        internal bool IsSetOtherPolicies()
        {
            return this._otherPolicies != null && (this._otherPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}