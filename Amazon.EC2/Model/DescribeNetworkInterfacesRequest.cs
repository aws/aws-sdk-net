﻿/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-12-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Network Interfaces request
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-12-15/", IsNullable = false)]
    public class DescribeNetworkInterfacesRequest
    {
        private List<string> networkInterfaceIdField;
        private List<Filter> filterField;

        /// <summary>
        /// Gets and sets the NetworkInterfaceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public List<string> NetworkInterfaceId
        {
            get
            {
                if (this.networkInterfaceIdField == null)
                {
                    this.networkInterfaceIdField = new List<string>();
                }
                return this.networkInterfaceIdField;
            }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the NetworkInterfaceId property
        /// </summary>
        /// <param name="list">Network Interface Ids to describe</param>
        /// <returns>this instance</returns>
        public DescribeNetworkInterfacesRequest WithNetworkInterfaceId(params string[] list)
        {
            foreach (string item in list)
            {
                NetworkInterfaceId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if NetworkInterfaceId property is set
        /// </summary>
        /// <returns>true if NetworkInterfaceId property is set</returns>
        public bool IsSetNetworkInterfaceId()
        {
            return (NetworkInterfaceId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Filter property.
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
        /// Sets the Filter property
        /// </summary>
        /// <param name="list">A list of filters.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeNetworkInterfacesRequest WithFilter(params Filter[] list)
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
