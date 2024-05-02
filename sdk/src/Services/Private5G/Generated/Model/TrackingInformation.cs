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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about tracking a shipment.
    /// </summary>
    public partial class TrackingInformation
    {
        private string _trackingNumber;

        /// <summary>
        /// Gets and sets the property TrackingNumber. 
        /// <para>
        /// The tracking number of the shipment.
        /// </para>
        /// </summary>
        public string TrackingNumber
        {
            get { return this._trackingNumber; }
            set { this._trackingNumber = value; }
        }

        // Check to see if TrackingNumber property is set
        internal bool IsSetTrackingNumber()
        {
            return this._trackingNumber != null;
        }

    }
}