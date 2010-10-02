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
 *  API Version: 2009-11-25
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns an updated list of Availability Zones for the LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class EnableAvailabilityZonesForLoadBalancerResponse
    {
        private EnableAvailabilityZonesForLoadBalancerResult enableAvailabilityZonesForLoadBalancerResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the EnableAvailabilityZonesForLoadBalancerResult property.
        /// Returns an updated list of Availability Zones for the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "EnableAvailabilityZonesForLoadBalancerResult")]
        public EnableAvailabilityZonesForLoadBalancerResult EnableAvailabilityZonesForLoadBalancerResult
        {
            get { return this.enableAvailabilityZonesForLoadBalancerResultField; }
            set { this.enableAvailabilityZonesForLoadBalancerResultField = value; }
        }

        /// <summary>
        /// Checks if EnableAvailabilityZonesForLoadBalancerResult property is set
        /// </summary>
        /// <returns>true if EnableAvailabilityZonesForLoadBalancerResult property is set</returns>
        public bool IsSetEnableAvailabilityZonesForLoadBalancerResult()
        {
            return this.enableAvailabilityZonesForLoadBalancerResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Metadata associated with the original request.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
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
