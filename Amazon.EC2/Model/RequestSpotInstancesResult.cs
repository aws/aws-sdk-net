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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Result of the Request Spot Instances operation.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class RequestSpotInstancesResult
    {
        private List<SpotInstanceRequest> spotInstanceRequestField;
        /// <summary>
        /// Gets and sets the SpotInstanceRequest property.
        /// A list of the SpotInstanceRequest objects returned by the service.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotInstanceRequest")]
        public List<SpotInstanceRequest> SpotInstanceRequest
        {
            get
            {
                if (this.spotInstanceRequestField == null)
                {
                    this.spotInstanceRequestField = new List<SpotInstanceRequest>();
                }
                return this.spotInstanceRequestField;
            }
            set { this.spotInstanceRequestField = value; }
        }

        /// <summary>
        /// Sets the SpotInstanceRequest property
        /// </summary>
        /// <param name="list">A list of the SpotInstanceRequest objects returned by the service.</param>
        /// <returns>this instance</returns>
        public RequestSpotInstancesResult WithSpotInstanceRequest(params SpotInstanceRequest[] list)
        {
            foreach (SpotInstanceRequest item in list)
            {
                SpotInstanceRequest.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SpotInstanceRequest property is set
        /// </summary>
        /// <returns>true if SpotInstanceRequest property is set</returns>
        public bool IsSetSpotInstanceRequest()
        {
            return (SpotInstanceRequest.Count > 0);
        }

    }
}
