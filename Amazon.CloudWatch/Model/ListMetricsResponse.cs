/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Returns a complete list of all of the metrics being used to generate statistics for this customer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class ListMetricsResponse
    {
        private ListMetricsResult listMetricsResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the ListMetricsResult property.
        /// A complete list of all of the metrics being used to generate statistics for this customer.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListMetricsResult")]
        public ListMetricsResult ListMetricsResult
        {
            get { return this.listMetricsResultField ; }
            set { this.listMetricsResultField = value; }
        }

        /// <summary>
        /// Sets the ListMetricsResult property
        /// </summary>
        /// <param name="listMetricsResult">A complete list of all of the metrics being used to generate statistics for this customer.</param>
        /// <returns>this instance</returns>
        public ListMetricsResponse WithListMetricsResult(ListMetricsResult listMetricsResult)
        {
            this.listMetricsResultField = listMetricsResult;
            return this;
        }

        /// <summary>
        /// Checks if ListMetricsResult property is set
        /// </summary>
        /// <returns>true if ListMetricsResult property is set</returns>
        public bool IsSetListMetricsResult()
        {
            return this.listMetricsResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Information about the request.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField ; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">Information about the request.</param>
        /// <returns>this instance</returns>
        public ListMetricsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public bool IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }

        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }
    }
}
