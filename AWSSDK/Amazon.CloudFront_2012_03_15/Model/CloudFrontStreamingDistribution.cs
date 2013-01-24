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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// Describes a CloudFront Streaming Distribution.
    /// It is used as a response element when Creating a Distribution and Getting a Distribution's Information.
    /// <para>A distribution consists of the following items:
    /// <list type="number">
    /// <item>Id</item>
    /// <item>Status</item>
    /// <item>Last Modified Timestamp</item>
    /// <item>Domain Name</item>
    /// <item>The Configuration for the Distribution</item>
    /// </list></para>
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionDatatype.html"/>
    /// </summary>
    [Serializable()]
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class CloudFrontStreamingDistribution : CloudFrontDistributionBase
    {
        #region Private Members

        private CloudFrontStreamingDistributionConfig config;

        #endregion

        #region StreamingDistributionConfig

        /// <summary>
        /// Gets and sets the Streaming Distribution's Configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "StreamingDistributionConfig")]
        public CloudFrontStreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this.config; }
            set { this.config = value; }
        }

        /// <summary>
        /// Checks if StreamingDistributionConfig property is set
        /// </summary>
        /// <returns>true if StreamingDistributionConfig property is set</returns>
        internal bool IsSetConfig()
        {
            return this.config != null;
        }

        #endregion
    }
}