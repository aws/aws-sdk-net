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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Additional options for configuring job action parameters.
    /// </summary>
    public partial class JobActionOptions
    {
        private ValidateAddressActionOptions _validateAddress;

        /// <summary>
        /// Gets and sets the property ValidateAddress. 
        /// <para>
        /// Options specific to address validation jobs.
        /// </para>
        /// </summary>
        public ValidateAddressActionOptions ValidateAddress
        {
            get { return this._validateAddress; }
            set { this._validateAddress = value; }
        }

        // Check to see if ValidateAddress property is set
        internal bool IsSetValidateAddress()
        {
            return this._validateAddress != null;
        }

    }
}