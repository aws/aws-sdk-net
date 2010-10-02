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
    /// Returns data for one or more statistics of given a metric.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class GetMetricStatisticsResult
    {
        private List<Datapoint> datapointsField;
        private string labelField;

        /// <summary>
        /// Gets and sets the Datapoints property.
        /// A collection of Datapoint elements.
        /// </summary>
        [XmlElementAttribute(ElementName = "Datapoints")]
        public List<Datapoint> Datapoints
        {
            get
            {
                if (this.datapointsField == null)
                {
                    this.datapointsField = new List<Datapoint>();
                }
                return this.datapointsField;
            }
            set { this.datapointsField = value; }
        }

        /// <summary>
        /// Checks if Datapoints property is set
        /// </summary>
        /// <returns>true if Datapoints property is set</returns>
        public bool IsSetDatapoints()
        {
            return (Datapoints.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Label property.
        /// The statistic label.
        /// </summary>
        [XmlElementAttribute(ElementName = "Label")]
        public string Label
        {
            get { return this.labelField; }
            set { this.labelField = value; }
        }

        /// <summary>
        /// Checks if Label property is set
        /// </summary>
        /// <returns>true if Label property is set</returns>
        public bool IsSetLabel()
        {
            return this.labelField != null;
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
