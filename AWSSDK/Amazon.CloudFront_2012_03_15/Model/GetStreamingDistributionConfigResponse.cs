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

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The GetStreamingDistributionConfigResponse contains the StreamingDistribution's configuration
    /// and any headers returned by CloudFront.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class GetStreamingDistributionConfigResponse : CloudFrontResponse
    {
        #region Private Members

        private CloudFrontStreamingDistributionConfig distributionConfig;

        #endregion

        #region StreamingDistributionConfig

        /// <summary>
        /// Gets and Sets the StreamingDistributionConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StreamingDistributionConfig")]
        public CloudFrontStreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this.distributionConfig; }
            set { this.distributionConfig = value; }
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// The Streaming Distribution's Configuration ETag is also
        /// set if possible.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public override string ETag
        {
            set
            {
                this.etagHeader = value;
                if (null != distributionConfig)
                {
                    distributionConfig.ETag = value;
                }
            }
        }

        #endregion
    }
}