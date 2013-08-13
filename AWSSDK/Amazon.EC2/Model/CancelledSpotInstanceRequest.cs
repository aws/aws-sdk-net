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
    /// A cancelled Spot Instance Request.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelledSpotInstanceRequest
    {    
        private string spotInstanceRequestIdField;
        private string stateField;

        /// <summary>
        /// The ID of the Spot Instance Request.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotInstanceRequestId")]
        public string SpotInstanceRequestId
        {
            get { return this.spotInstanceRequestIdField; }
            set { this.spotInstanceRequestIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Spot Instance Request.
        /// </summary>
        /// <param name="spotInstanceRequestId">The ID of the Spot Instance Request.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CancelledSpotInstanceRequest WithSpotInstanceRequestId(string spotInstanceRequestId)
        {
            this.spotInstanceRequestIdField = spotInstanceRequestId;
            return this;
        }

        /// <summary>
        /// Checks if SpotInstanceRequestId property is set
        /// </summary>
        /// <returns>true if SpotInstanceRequestId property is set</returns>
        public bool IsSetSpotInstanceRequestId()
        {
            return this.spotInstanceRequestIdField != null;
        }

        /// <summary>
        /// The State of the Spot Instance Request.
        /// Valid values are open | closed | cancelled | failed
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the State of the Spot Instance Request.
        /// </summary>
        /// <param name="state">The State of the Spot Instance Request.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CancelledSpotInstanceRequest WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

    }
}
