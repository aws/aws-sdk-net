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
    /// Updated healthcheck for the instances.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class ConfigureHealthCheckResult
    {
        private HealthCheck healthCheckField;

        /// <summary>
        /// Gets and sets the HealthCheck property.
        /// The LoadBalancer also monitors the health of your instances registered with your LoadBalancer.
        /// When the LoadBalancer detects a problem with an instance, it stops distributing traffic to it. When the
        /// instance is healthy again, the LoadBalancer restarts distributing traffic to it. This process allows your
        /// application to automatically react to issues that might affect your customers without your having to be involved
        /// beyond configuring the healthcheck.
        /// </summary>
        [XmlElementAttribute(ElementName = "HealthCheck")]
        public HealthCheck HealthCheck
        {
            get { return this.healthCheckField; }
            set { this.healthCheckField = value; }
        }

        /// <summary>
        /// Checks if HealthCheck property is set
        /// </summary>
        /// <returns>true if HealthCheck property is set</returns>
        public bool IsSetHealthCheck()
        {
            return this.healthCheckField != null;
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
