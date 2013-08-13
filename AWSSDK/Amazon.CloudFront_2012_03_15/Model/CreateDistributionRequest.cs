/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */

using System.Xml.Serialization;

using Amazon.CloudFront.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The CreateDistributionRequest contains the parameters used for the CreateDistribution operation.
    /// </summary>
    public class CreateDistributionRequest : CloudFrontRequest
    {
        #region DistributionConfig

        /// <summary>
        /// Gets and Sets the DistributionConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DistributionConfig")]
        public override CloudFrontDistributionConfig DistributionConfig
        {
            get
            {
                if (this.dConfig == null)
                {
                    this.dConfig = new CloudFrontDistributionConfig();
                }
                return this.dConfig;
            }
            set { this.dConfig = value; }
        }

        /// <summary>
        /// Sets the DistributionConfig property for this request.
        /// </summary>
        /// <param name="distributionConfig">The value that DistributionConfig is set to</param>
        /// <returns>the request with the Id set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDistributionRequest WithDistributionConfig(CloudFrontDistributionConfig distributionConfig)
        {
            this.dConfig = distributionConfig;
            return this;
        }

        #endregion
    }
}
