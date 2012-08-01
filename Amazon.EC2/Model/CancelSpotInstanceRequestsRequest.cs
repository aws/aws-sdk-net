/*******************************************************************************
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Request to cancel existing Spot Instance
    /// requests.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelSpotInstanceRequestsRequest
    {    
        private List<string> spotInstanceRequestIdField;

        /// <summary>
        /// Gets and sets the SpotInstanceRequestId property.
        /// The list of Spot Instance requests that you
        /// want to cancel.
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
        /// <param name="list">The list of Spot Instance requests that you
        /// want to cancel.</param>
        /// <returns>this instance</returns>
        public CancelSpotInstanceRequestsRequest WithSpotInstanceRequestId(params string[] list)
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
