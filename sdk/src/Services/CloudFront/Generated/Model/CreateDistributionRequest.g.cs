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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateDistribution operation. Creates a CloudFront
    /// distribution.
    /// </summary>
    public partial class CreateDistributionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateDistributionRequest() { }

        /// <summary>
        /// Instantiates CreateDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="distributionConfig">The distribution's configuration information.</param>
        public CreateDistributionRequest(DistributionConfig distributionConfig)
        {
            this.DistributionConfig = distributionConfig;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfig. 
        /// <para>
        /// The distribution's configuration information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistributionConfig DistributionConfig { get; set; }

        /// <summary>
        /// Checks to see if the DistributionConfig property is set.
        /// </summary>
        internal bool IsSetDistributionConfig() => this.DistributionConfig != null;
    }
}
