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
    /// The SetStreamingDistributionConfigRequest contains the parameters used for the
    /// SetStreamingDistributionConfig operation.
    /// The ETag parameter is used if you wish to specify the ETag to match with the
    /// ETag of the StreamingDistribution with the Id specified.
    /// <br />Required Parameters: Id
    /// <br />Required Parameters: StreamingDistributionConfig
    /// <br />Required Parameters: ETag of the Streaming Distribution. This value can
    /// be retrieved via a call to GetStreamingDistributionInfo.
    /// </summary>
    /// <remarks>
    /// If you want to serve private content, you need to:
    /// <list type="bullet">
    /// <item>Associate an Origin Access Identity with the StreamingDistributionConfig</item>
    /// <item>Associate TrustedSigners with the StreamingDistributionConfig if you want to 
    /// serve content via Signed URLs</item>
    /// </list>
    /// </remarks>
    /// <seealso cref="T:Amazon.CloudFront.Model.CloudFrontStreamingDistributionConfig"/>
    /// <seealso cref="T:Amazon.CloudFront.Model.UrlTrustedSigners"/>
    /// <seealso cref="P:Amazon.CloudFront.Model.CloudFrontStreamingDistributionConfig.OriginAccessIdentity"/>
    /// <seealso cref="P:Amazon.CloudFront.Model.CloudFrontStreamingDistributionConfig.TrustedSigners"/>
    public class SetStreamingDistributionConfigRequest : CloudFrontRequest
    {
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
        /// This is the CloudFront Streaming Distribution Id that will be reconfigured
        /// by this request.
        /// </summary>
        /// <param name="id">The value that Id is set to</param>
        /// <returns>the request with the Id set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetStreamingDistributionConfigRequest WithId(string id)
        {
            this.distId = id;
            return this;
        }

        #endregion

        #region StreamingDistributionConfig

        /// <summary>
        /// Gets and Sets the StreamingDistributionConfig property.
        /// The CloudFront Streaming Distribution's configuration will 
        /// be modified to reflect the values in this configuration object.
        /// </summary>
        [XmlElementAttribute(ElementName = "StreamingDistributionConfig")]
        public override CloudFrontStreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this.sdConfig; }
            set { this.sdConfig = value; }
        }

        /// <summary>
        /// Sets the StreamingDistributionConfig property for this request.
        /// </summary>
        /// <param name="config">The value that StreamingDistributionConfig is set to</param>
        /// <returns>the request with the Configuration set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetStreamingDistributionConfigRequest WithStreamingDistributionConfig(CloudFrontStreamingDistributionConfig config)
        {
            this.sdConfig = config;
            return this;
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property. This should be the ETag of the 
        /// Streaming Distribution. 
        /// <see cref="P:Amazon.CloudFront.Model.CloudFrontStreamingDistribution.ETag"/>
        /// </summary>
        public override string ETag
        {
            get { return this.etagHeader; }
            set { this.etagHeader = value; }
        }

        /// <summary>
        /// Sets the ETag property for this request.
        /// This is the ETag of the CloudFront Streaming Distribution which 
        /// will be reconfigured.
        /// </summary>
        /// <param name="etag">The value that ETag is set to</param>
        /// <returns>the request with the ETag set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetStreamingDistributionConfigRequest WithETag(string etag)
        {
            this.etagHeader = etag;
            return this;
        }

        #endregion
    }
}
