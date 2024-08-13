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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains the configuration for a continuous deployment policy.
    /// </summary>
    public partial class ContinuousDeploymentPolicyConfig
    {
        private bool? _enabled;
        private StagingDistributionDnsNames _stagingDistributionDnsNames;
        private TrafficConfig _trafficConfig;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean that indicates whether this continuous deployment policy is enabled (in
        /// effect). When this value is <c>true</c>, this policy is enabled and in effect. When
        /// this value is <c>false</c>, this policy is not enabled and has no effect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StagingDistributionDnsNames. 
        /// <para>
        /// The CloudFront domain name of the staging distribution. For example: <c>d111111abcdef8.cloudfront.net</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StagingDistributionDnsNames StagingDistributionDnsNames
        {
            get { return this._stagingDistributionDnsNames; }
            set { this._stagingDistributionDnsNames = value; }
        }

        // Check to see if StagingDistributionDnsNames property is set
        internal bool IsSetStagingDistributionDnsNames()
        {
            return this._stagingDistributionDnsNames != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficConfig. 
        /// <para>
        /// Contains the parameters for routing production traffic from your primary to staging
        /// distributions.
        /// </para>
        /// </summary>
        public TrafficConfig TrafficConfig
        {
            get { return this._trafficConfig; }
            set { this._trafficConfig = value; }
        }

        // Check to see if TrafficConfig property is set
        internal bool IsSetTrafficConfig()
        {
            return this._trafficConfig != null;
        }

    }
}