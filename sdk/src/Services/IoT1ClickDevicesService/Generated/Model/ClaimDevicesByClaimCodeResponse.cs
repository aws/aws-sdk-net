/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickDevicesService.Model
{
    /// <summary>
    /// This is the response object from the ClaimDevicesByClaimCode operation.
    /// </summary>
    public partial class ClaimDevicesByClaimCodeResponse : AmazonWebServiceResponse
    {
        private string _claimCode;
        private int? _total;

        /// <summary>
        /// Gets and sets the property ClaimCode. 
        /// <para>
        /// The claim code provided by the device manufacturer.
        /// </para>
        /// </summary>
        public string ClaimCode
        {
            get { return this._claimCode; }
            set { this._claimCode = value; }
        }

        // Check to see if ClaimCode property is set
        internal bool IsSetClaimCode()
        {
            return this._claimCode != null;
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of devices associated with the claim code that has been processed
        /// in the claim request.
        /// </para>
        /// </summary>
        public int Total
        {
            get { return this._total.GetValueOrDefault(); }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}