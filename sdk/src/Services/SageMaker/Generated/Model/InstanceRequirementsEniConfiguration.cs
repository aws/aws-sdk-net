/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The customer ENI and additional ENIs associated with a network interface category.
    /// </summary>
    public partial class InstanceRequirementsEniConfiguration
    {
        private AdditionalEnis _additionalEnis;
        private string _customerEni;

        /// <summary>
        /// Gets and sets the property AdditionalEnis. 
        /// <para>
        /// Information about additional Elastic Network Interfaces (ENIs) associated with the
        /// instance type category.
        /// </para>
        /// </summary>
        public AdditionalEnis AdditionalEnis
        {
            get { return this._additionalEnis; }
            set { this._additionalEnis = value; }
        }

        // Check to see if AdditionalEnis property is set
        internal bool IsSetAdditionalEnis()
        {
            return this._additionalEnis != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerEni. 
        /// <para>
        /// The ID of the customer-managed Elastic Network Interface (ENI) associated with the
        /// instance type category.
        /// </para>
        /// </summary>
        public string CustomerEni
        {
            get { return this._customerEni; }
            set { this._customerEni = value; }
        }

        // Check to see if CustomerEni property is set
        internal bool IsSetCustomerEni()
        {
            return this._customerEni != null;
        }

    }
}