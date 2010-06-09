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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns updated list of remaining instances registered with the LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DeregisterInstancesFromLoadBalancerResponse
    {
        private DeregisterInstancesFromLoadBalancerResult deregisterInstancesFromLoadBalancerResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the DeregisterInstancesFromLoadBalancerResult property.
        /// Updated list of remaining instances registered with the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeregisterInstancesFromLoadBalancerResult")]
        public DeregisterInstancesFromLoadBalancerResult DeregisterInstancesFromLoadBalancerResult
        {
            get { return this.deregisterInstancesFromLoadBalancerResultField ; }
            set { this.deregisterInstancesFromLoadBalancerResultField = value; }
        }

        /// <summary>
        /// Sets the DeregisterInstancesFromLoadBalancerResult property
        /// </summary>
        /// <param name="deregisterInstancesFromLoadBalancerResult">Updated list of remaining instances registered with the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public DeregisterInstancesFromLoadBalancerResponse WithDeregisterInstancesFromLoadBalancerResult(DeregisterInstancesFromLoadBalancerResult deregisterInstancesFromLoadBalancerResult)
        {
            this.deregisterInstancesFromLoadBalancerResultField = deregisterInstancesFromLoadBalancerResult;
            return this;
        }

        /// <summary>
        /// Checks if DeregisterInstancesFromLoadBalancerResult property is set
        /// </summary>
        /// <returns>true if DeregisterInstancesFromLoadBalancerResult property is set</returns>
        public bool IsSetDeregisterInstancesFromLoadBalancerResult()
        {
            return this.deregisterInstancesFromLoadBalancerResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Metadata associated with the original request.
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
        /// <param name="responseMetadata">Metadata associated with the original request.</param>
        /// <returns>this instance</returns>
        public DeregisterInstancesFromLoadBalancerResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
