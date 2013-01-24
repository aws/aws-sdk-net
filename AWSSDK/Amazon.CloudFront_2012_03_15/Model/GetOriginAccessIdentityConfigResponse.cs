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
    /// The GetOriginAccessIdentityConfigResponse contains the Origin Access Identity's configuration
    /// and any headers returned by CloudFront.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class GetOriginAccessIdentityConfigResponse : CloudFrontResponse
    {
        #region Private Members

        private CloudFrontOriginAccessIdentityConfig originAccessIdentityConfig;

        #endregion

        #region OriginAccessIdentityConfig

        /// <summary>
        /// Gets and Sets the OriginAccessIdentityConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OriginAccessIdentityConfig")]
        public CloudFrontOriginAccessIdentityConfig OriginAccessIdentityConfig
        {
            get { return this.originAccessIdentityConfig; }
            set { this.originAccessIdentityConfig = value; }
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// The Origin Access Identity's Configuration ETag is also
        /// set if possible.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public override string ETag
        {
            set
            {
                this.etagHeader = value;
                if (null != OriginAccessIdentityConfig)
                {
                    OriginAccessIdentityConfig.ETag = value;
                }
            }
        }

        #endregion
    }
}