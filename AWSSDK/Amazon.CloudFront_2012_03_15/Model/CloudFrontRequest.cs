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

using System.Collections.Specialized;
using System.Net;
using System.Xml.Serialization;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// Base class for CloudFront operation requests.
    /// Provides a header collection which can is used to store the request headers.
    /// </summary>
    public abstract class CloudFrontRequest : BaseRequest
    {
        #region Protected Members

        /// <summary>
        /// The ID of the CloudFront distribution
        /// <list type="number">
        /// <item>Get Distribution Config</item>
        /// <item>Get Distribution Info</item>
        /// <item>Set Distribution Config</item>
        /// <item>Delete Distribution</item>
        /// </list>
        /// </summary>
        protected string distId;

        /// <summary>
        /// The ETag for the distribution. 
        /// </summary>
        /// <remarks>
        /// This value is returned by the CloudFront
        /// service when:
        /// <list type="number">
        /// <item>a distribution is created</item>
        /// <item>a distribution's info is requested</item>
        /// <item>a distribution's config is requested</item>
        /// <item>a distribution's config is modified</item>
        /// </list>
        /// </remarks>
        protected string etagHeader;

        /// <summary>
        /// The CloudFront Distribution Config object used by:
        /// <list type="number">
        /// <item>Set Distribution Config</item>
        /// <item>Create Distribution</item>
        /// </list>
        /// </summary>
        protected CloudFrontDistributionConfig dConfig;

        /// <summary>
        /// The CloudFront Streaming Distribution Config object used by:
        /// <list type="number">
        /// <item>Set Streaming Distribution Config</item>
        /// <item>Create Streaming Distribution</item>
        /// </list>
        /// </summary>
        protected CloudFrontStreamingDistributionConfig sdConfig;

        // Unique to List Distributions
        /// <summary>
        /// All keys returned will be lexiographically after the marker.
        /// Used by ListDistributionsRequest
        /// </summary>
        protected string reqMarker;

        /// <summary>
        /// Limits the result set of keys to MaxItems.
        /// Used by ListDistributionsRequest
        /// </summary>
        protected string reqMaxItems;

        #endregion

        #region Id

        /// <summary>
        /// Gets and sets the Id property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Id")]
        public virtual string Id
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Checks if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal bool IsSetId()
        {
            return !System.String.IsNullOrEmpty(this.distId);
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        public virtual string ETag
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Checks if ETag property is set.
        /// </summary>
        /// <returns>true if ETag property is set.</returns>
        internal bool IsSetETag()
        {
            return !System.String.IsNullOrEmpty(this.etagHeader);
        }

        #endregion

        #region DistributionConfig

        /// <summary>
        /// Gets and Sets the DistributionConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DistributionConfig")]
        public virtual CloudFrontDistributionConfig DistributionConfig
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Checks if DistributionConfig property is set.
        /// </summary>
        /// <returns>true if DistributionConfig property is set.</returns>
        internal bool IsSetDistributionConfig()
        {
            return DistributionConfig != null;
        }

        #endregion

        #region StreamingDistributionConfig

        /// <summary>
        /// Gets and Sets the StreamingDistributionConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StreamingDistributionConfig")]
        public virtual CloudFrontStreamingDistributionConfig StreamingDistributionConfig
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Checks if StreamingDistributionConfig property is set.
        /// </summary>
        /// <returns>true if StreamingDistributionConfig property is set.</returns>
        internal bool IsSetStreamingDistributionConfig()
        {
            return StreamingDistributionConfig != null;
        }

        #endregion

        #region Marker

        /// <summary>
        /// Gets and sets the Marker property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public virtual string Marker
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Checks if Marker property is set
        /// </summary>
        /// <returns>true if Marker property is set</returns>
        internal bool IsSetMarker()
        {
            return !System.String.IsNullOrEmpty(this.reqMarker);
        }

        #endregion

        #region MaxItems

        /// <summary>
        /// Gets and sets the MaxItems property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxItems")]
        public virtual string MaxItems
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Checks if MaxItems property is set
        /// </summary>
        /// <returns>true if MaxItems property is set</returns>
        internal bool IsSetMaxItems()
        {
            return !System.String.IsNullOrEmpty(this.reqMaxItems);
        }

        #endregion
    }
}