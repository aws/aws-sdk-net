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
    /// A complete list of all of the metrics being used to generate statistics for this customer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class ListMetricsResult
    {
        private List<Metric> metricsField;
        private string nextTokenField;

        /// <summary>
        /// Gets and sets the Metrics property.
        /// A complete list of all of the metrics being used to generate statistics for this customer.
        /// </summary>
        [XmlElementAttribute(ElementName = "Metrics")]
        public List<Metric> Metrics
        {
            get
            {
                if (this.metricsField == null)
                {
                    this.metricsField = new List<Metric>();
                }
                return this.metricsField;
            }
            set { this.metricsField = value; }
        }

        /// <summary>
        /// Checks if Metrics property is set
        /// </summary>
        /// <returns>true if Metrics property is set</returns>
        public bool IsSetMetrics()
        {
            return (Metrics.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// A string that can be used to query for the next set of results.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

        /// <summary>
        /// XML Representation of this object
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

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
