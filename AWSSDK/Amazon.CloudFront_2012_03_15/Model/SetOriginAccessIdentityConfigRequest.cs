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
    /// The SetOriginAccessIdentityConfigRequest contains the parameters used for the
    /// SetOriginAccessIdentityConfig operation.
    /// <br />Required Parameters: Id
    /// <br />Required Parameters: OriginAccessIdentityConfig
    /// <br />Required Parameters: ETag of the Origin Access Identity. 
    /// This value can be retrieved via a call to GetOriginAccessIdentityInfo.
    /// </summary>
    public class SetOriginAccessIdentityConfigRequest : CloudFrontRequest
    {
        #region Private Members

        private CloudFrontOriginAccessIdentityConfig oaiConfig;

        #endregion

        #region Id

        /// <summary>
        /// Gets and sets the Id property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Id")]
        public override string Id
        {
            get { return this.distId; }
            set { this.distId = value; }
        }

        /// <summary>
        /// Sets the Id property for this request.
        /// This is the Id of the CloudFront Origin Access Identity 
        /// that will be reconfigured by this request.
        /// </summary>
        /// <param name="id">The value that Id is set to</param>
        /// <returns>the request with the Id set</returns>
        public SetOriginAccessIdentityConfigRequest WithId(string id)
        {
            this.distId = id;
            return this;
        }

        #endregion

        #region OriginAccessIdentityConfig

        /// <summary>
        /// Gets and Sets the OriginAccessIdentityConfig property.
        /// The CloudFront Origin Access Identity's configuration will be modified
        /// to reflect the values in this configuration object.
        /// </summary>
        [XmlElementAttribute(ElementName = "OriginAccessIdentityConfig")]
        public CloudFrontOriginAccessIdentityConfig OriginAccessIdentityConfig
        {
            get { return this.oaiConfig; }
            set { this.oaiConfig = value; }
        }

        /// <summary>
        /// Sets the OriginAccessIdentityConfig property for this request.
        /// </summary>
        /// <param name="config">The value that OriginAccessIdentityConfig is set to</param>
        /// <returns>the request with the Configuration set</returns>
        public SetOriginAccessIdentityConfigRequest WithOriginAccessIdentityConfig(CloudFrontOriginAccessIdentityConfig config)
        {
            this.oaiConfig = config;
            return this;
        }

        /// <summary>
        /// Checks if DistributionConfig property is set.
        /// </summary>
        /// <returns>true if DistributionConfig property is set.</returns>
        internal bool IsSetOriginAccessIdentityConfig()
        {
            return OriginAccessIdentityConfig != null;
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property. This value should be the ETag of the 
        /// Origin Access Identity.
        /// <see cref="P:Amazon.CloudFront.Model.CloudFrontOriginAccessIdentity.ETag"/>
        /// </summary>
        public override string ETag
        {
            get { return this.etagHeader; }
            set { this.etagHeader = value; }
        }

        /// <summary>
        /// Sets the ETag property for this request.
        /// This is the ETag of the CloudFront Origin Access Identity which will be reconfigured.
        /// </summary>
        /// <param name="etag">The value that ETag is set to</param>
        /// <returns>the request with the ETag set</returns>
        public SetOriginAccessIdentityConfigRequest WithETag(string etag)
        {
            this.etagHeader = etag;
            return this;
        }

        #endregion
    }
}