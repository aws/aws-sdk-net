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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Vpn Connections Response
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeVpnConnectionsResponse
    {
        private ResponseMetadata responseMetadataField;
        private DescribeVpnConnectionsResult describeVpnConnectionsResultField;

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Response Metadata
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
        /// <param name="responseMetadata">Response Metadata</param>
        /// <returns>this instance</returns>
        public DescribeVpnConnectionsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
        /// Gets and sets the DescribeVpnConnectionsResult property.
        /// Describe Vpn Connections Result
        /// </summary>
        [XmlElementAttribute(ElementName = "DescribeVpnConnectionsResult")]
        public DescribeVpnConnectionsResult DescribeVpnConnectionsResult
        {
            get { return this.describeVpnConnectionsResultField ; }
            set { this.describeVpnConnectionsResultField = value; }
        }

        /// <summary>
        /// Sets the DescribeVpnConnectionsResult property
        /// </summary>
        /// <param name="describeVpnConnectionsResult">Describe Vpn Connections Result</param>
        /// <returns>this instance</returns>
        public DescribeVpnConnectionsResponse WithDescribeVpnConnectionsResult(DescribeVpnConnectionsResult describeVpnConnectionsResult)
        {
            this.describeVpnConnectionsResultField = describeVpnConnectionsResult;
            return this;
        }

        /// <summary>
        /// Checks if DescribeVpnConnectionsResult property is set
        /// </summary>
        /// <returns>true if DescribeVpnConnectionsResult property is set</returns>
        public bool IsSetDescribeVpnConnectionsResult()
        {
            return this.describeVpnConnectionsResultField != null;
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
