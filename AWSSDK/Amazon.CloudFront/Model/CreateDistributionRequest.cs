/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDistribution operation.
    /// <para> Create a new distribution. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateDistribution"/>
    public class CreateDistributionRequest : AmazonWebServiceRequest
    {
        private DistributionConfig distributionConfig;

        /// <summary>
        /// The distribution's configuration information.
        ///  
        /// </summary>
        public DistributionConfig DistributionConfig
        {
            get { return this.distributionConfig; }
            set { this.distributionConfig = value; }
        }

        /// <summary>
        /// Sets the DistributionConfig property
        /// </summary>
        /// <param name="distributionConfig">The value to set for the DistributionConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDistributionRequest WithDistributionConfig(DistributionConfig distributionConfig)
        {
            this.distributionConfig = distributionConfig;
            return this;
        }
            

        // Check to see if DistributionConfig property is set
        internal bool IsSetDistributionConfig()
        {
            return this.distributionConfig != null;
        }
    }
}
    
