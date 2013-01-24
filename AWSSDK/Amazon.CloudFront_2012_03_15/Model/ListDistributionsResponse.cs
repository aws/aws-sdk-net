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

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The ListDistributionsResponse contains the ListDistributionsResult and
    /// any headers or metadata returned by CloudFront.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class ListDistributionsResponse : CloudFrontResponse
    {
        #region Private Members

        private string marker;
        private string maxItems;
        private string nextMarker;
        private bool isTruncated;

        private List<CloudFrontDistribution> distributions = new List<CloudFrontDistribution>();

        #endregion

        #region Distribution

        /// <summary>
        /// Gets the Distribution property as a List
        /// </summary>
        [XmlElementAttribute(ElementName = "Distribution")]
        public List<CloudFrontDistribution> Distribution
        {
            get { return this.distributions; }
        }

        #endregion

        #region Marker

        /// <summary>
        /// Gets and sets the Marker property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        #endregion

        #region MaxItems

        /// <summary>
        /// Gets and sets the MaxItems property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxItems")]
        public string MaxItems
        {
            get { return this.maxItems; }
            set { this.maxItems = value; }
        }

        #endregion

        #region NextMarker

        /// <summary>
        /// Gets and sets the NextMarker property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextMarker")]
        public string NextMarker
        {
            get { return this.nextMarker; }
            set { this.nextMarker = value; }
        }

        #endregion

        #region IsTruncated

        /// <summary>
        /// Gets and sets the IsTruncated property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsTruncated")]
        public bool IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        #endregion
    }
}