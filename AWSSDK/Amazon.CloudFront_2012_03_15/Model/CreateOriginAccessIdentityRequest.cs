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
    /// The CreateOriginAccessIdentityRequest contains the parameters used for the CreateOriginAccessIdentity operation.
    /// </summary>
    public class CreateOriginAccessIdentityRequest : CloudFrontRequest
    {
        #region Private Members

        CloudFrontOriginAccessIdentityConfig oaiConfig;

        #endregion

        #region OriginAccessIdentityConfig

        /// <summary>
        /// Gets and Sets the OriginAccessIdentityConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OriginAccessIdentityConfig")]
        public CloudFrontOriginAccessIdentityConfig OriginAccessIdentityConfig
        {
            get
            {
                if (this.oaiConfig == null)
                {
                    this.oaiConfig = new CloudFrontOriginAccessIdentityConfig();
                }
                return this.oaiConfig;
            }
            set { this.oaiConfig = value; }
        }

        /// <summary>
        /// Sets the OriginAccessIdentityConfig property for this request.
        /// </summary>
        /// <param name="oaiConfig">The value that OriginAccessIdentityConfig is set to</param>
        /// <returns>the request with the Id set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateOriginAccessIdentityRequest WithOriginAccessIdentityConfig(CloudFrontOriginAccessIdentityConfig oaiConfig)
        {
            this.oaiConfig = oaiConfig;
            return this;
        }

        #endregion
    }
}
