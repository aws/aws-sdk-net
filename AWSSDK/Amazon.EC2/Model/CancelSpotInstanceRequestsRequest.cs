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
    /// Cancels one or more Spot Instance requests.
    /// </summary>
    /// <remarks>
    /// Spot Instances are instances that Amazon EC2 starts on your behalf when the
    /// maximum price that you specify exceeds the current Spot Price.
    /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance
    /// capacity and current Spot Instance requests.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelSpotInstanceRequestsRequest : EC2Request
    {    
        private List<string> spotInstanceRequestIdField;

        /// <summary>
        /// The list of Spot Instance requests that you want to cancel.
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
        /// Sets the Spot Instance requests that you want to cancel.
        /// </summary>
        /// <param name="list">The list of Spot Instance requests that you
        /// want to cancel.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
