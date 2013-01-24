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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the Spot Instance requests that belong to your account.
    /// </summary>
    /// <remarks>
    /// Spot Instances are instances that automatically launch
    /// when your request price exceeds that Spot Price
    /// that Amazon EC2 periodically calculates.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeSpotInstanceRequestsRequest
    {    
        private List<string> spotInstanceRequestIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more Spot Instance request IDs.
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
        /// Sets Spot Instance request IDs.
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

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified SpotInstances.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets filters used to match system-defined properties and user-defined tags associated 
        /// with the specified SpotInstances.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified SpotInstances.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeSpotInstanceRequestsRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}
