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
    /// Describes current bundling tasks. For more information on bundling instances, go to the
    /// Amazon Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud
    /// Getting Started Guide.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeBundleTasksRequest
    {
        private List<string> bundleIdField;

        /// <summary>
        /// Gets and sets the BundleId property.
        /// The ID of the bundle task to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "BundleId")]
        public List<string> BundleId
        {
            get
            {
                if (this.bundleIdField == null)
                {
                    this.bundleIdField = new List<string>();
                }
                return this.bundleIdField;
            }
            set { this.bundleIdField = value; }
        }

        /// <summary>
        /// Sets the BundleId property
        /// </summary>
        /// <param name="list">The ID of the bundle task to describe.</param>
        /// <returns>this instance</returns>
        public DescribeBundleTasksRequest WithBundleId(params string[] list)
        {
            foreach (string item in list)
            {
                BundleId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BundleId property is set
        /// </summary>
        /// <returns>true if BundleId property is set</returns>
        public bool IsSetBundleId()
        {
            return (BundleId.Count > 0);
        }

    }
}
