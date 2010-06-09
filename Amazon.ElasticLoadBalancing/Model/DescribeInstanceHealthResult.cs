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
    /// Returns the current state of the instances of the specified LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class DescribeInstanceHealthResult
    {
        private List<InstanceState> instanceStatesField;

        /// <summary>
        /// Gets and sets the InstanceStates property.
        /// Structure containing instance Health information for the specified instances, such as InService or
        /// OutOfService and any reasons associated with the OutOfService state.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceStates")]
        public List<InstanceState> InstanceStates
        {
            get
            {
                if (this.instanceStatesField == null)
                {
                    this.instanceStatesField = new List<InstanceState>();
                }
                return this.instanceStatesField;
            }
            set { this.instanceStatesField = value; }
        }

        /// <summary>
        /// Checks if InstanceStates property is set
        /// </summary>
        /// <returns>true if InstanceStates property is set</returns>
        public bool IsSetInstanceStates()
        {
            return (InstanceStates.Count > 0);
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
