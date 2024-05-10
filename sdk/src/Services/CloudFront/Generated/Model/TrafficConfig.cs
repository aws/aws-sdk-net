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
    /// The traffic configuration of your continuous deployment.
    /// </summary>
    public partial class TrafficConfig
    {
        private ContinuousDeploymentSingleHeaderConfig _singleHeaderConfig;
        private ContinuousDeploymentSingleWeightConfig _singleWeightConfig;
        private ContinuousDeploymentPolicyType _type;

        /// <summary>
        /// Gets and sets the property SingleHeaderConfig. 
        /// <para>
        /// Determines which HTTP requests are sent to the staging distribution.
        /// </para>
        /// </summary>
        public ContinuousDeploymentSingleHeaderConfig SingleHeaderConfig
        {
            get { return this._singleHeaderConfig; }
            set { this._singleHeaderConfig = value; }
        }

        // Check to see if SingleHeaderConfig property is set
        internal bool IsSetSingleHeaderConfig()
        {
            return this._singleHeaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SingleWeightConfig. 
        /// <para>
        /// Contains the percentage of traffic to send to the staging distribution.
        /// </para>
        /// </summary>
        public ContinuousDeploymentSingleWeightConfig SingleWeightConfig
        {
            get { return this._singleWeightConfig; }
            set { this._singleWeightConfig = value; }
        }

        // Check to see if SingleWeightConfig property is set
        internal bool IsSetSingleWeightConfig()
        {
            return this._singleWeightConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of traffic configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContinuousDeploymentPolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}