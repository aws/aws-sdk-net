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
    /// Request to describe Spot Instance requests. Spot Instances are instances that automatically launch
    /// when your request price exceeds that Spot Price that Amazon EC2 periodically calculates.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeSpotInstanceRequestsRequest
    {
        private List<string> spotInstanceRequestIdField;

        /// <summary>
        /// Gets and sets the SpotInstanceRequestId property.
        /// The ID of the Spot Instance request.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotInstanceRequestId")]
        public List<string> SpotInstanceRequestId
        {
            get
            {
                if (this.spotInstanceRequestIdField == null)
                {
                    this.spotInstanceRequestIdField = new List<string>();
                }
                return this.spotInstanceRequestIdField;
            }
            set { this.spotInstanceRequestIdField = value; }
        }

        /// <summary>
        /// Sets the SpotInstanceRequestId property
        /// </summary>
        /// <param name="list">The ID of the Spot Instance request.</param>
        /// <returns>this instance</returns>
        public DescribeSpotInstanceRequestsRequest WithSpotInstanceRequestId(params string[] list)
        {
            foreach (string item in list)
            {
                SpotInstanceRequestId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SpotInstanceRequestId property is set
        /// </summary>
        /// <returns>true if SpotInstanceRequestId property is set</returns>
        public bool IsSetSpotInstanceRequestId()
        {
            return (SpotInstanceRequestId.Count > 0);
        }

    }
}
