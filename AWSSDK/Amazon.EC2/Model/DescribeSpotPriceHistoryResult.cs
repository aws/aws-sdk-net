/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The Result containing the Spot Price history data.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeSpotPriceHistoryResult
    {    
        private List<SpotPriceHistory> spotPriceHistoryField;
        private string nextTokenField;

        /// <summary>
        /// Gets and sets the SpotPriceHistory property.
        /// List of data points specifying the Spot Price history.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotPriceHistory")]
        public List<SpotPriceHistory> SpotPriceHistory
        {
            get
            {
                if (this.spotPriceHistoryField == null)
                {
                    this.spotPriceHistoryField = new List<SpotPriceHistory>();
                }
                return this.spotPriceHistoryField;
            }
            set { this.spotPriceHistoryField = value; }
        }

        /// <summary>
        /// Checks if SpotPriceHistory property is set
        /// </summary>
        /// <returns>true if SpotPriceHistory property is set</returns>
        public bool IsSetSpotPriceHistory()
        {
            return (SpotPriceHistory.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// The string marking the next set of results returned. Displays empty
        /// if there are no more results to be returned.
        /// </summary>
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
