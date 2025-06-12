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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Information about an IP address range that is provisioned for use with your Amazon
    /// Web Services resources through bring your own IP address (BYOIP).
    /// 
    ///  
    /// <para>
    /// The following describes each BYOIP <c>State</c> that your IP address range can be
    /// in.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>PENDING_PROVISIONING</b> — You’ve submitted a request to provision an IP address
    /// range but it is not yet provisioned with Global Accelerator.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>READY</b> — The address range is provisioned with Global Accelerator and can be
    /// advertised.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>PENDING_ADVERTISING</b> — You’ve submitted a request for Global Accelerator to
    /// advertise an address range but it is not yet being advertised.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ADVERTISING</b> — The address range is being advertised by Global Accelerator.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>PENDING_WITHDRAWING</b> — You’ve submitted a request to withdraw an address range
    /// from being advertised but it is still being advertised by Global Accelerator.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>PENDING_DEPROVISIONING</b> — You’ve submitted a request to deprovision an address
    /// range from Global Accelerator but it is still provisioned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>DEPROVISIONED</b> — The address range is deprovisioned from Global Accelerator.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>FAILED_PROVISION </b> — The request to provision the address range from Global
    /// Accelerator was not successful. Please make sure that you provide all of the correct
    /// information, and try again. If the request fails a second time, contact Amazon Web
    /// Services support.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>FAILED_ADVERTISING</b> — The request for Global Accelerator to advertise the address
    /// range was not successful. Please make sure that you provide all of the correct information,
    /// and try again. If the request fails a second time, contact Amazon Web Services support.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>FAILED_WITHDRAW</b> — The request to withdraw the address range from advertising
    /// by Global Accelerator was not successful. Please make sure that you provide all of
    /// the correct information, and try again. If the request fails a second time, contact
    /// Amazon Web Services support.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>FAILED_DEPROVISION </b> — The request to deprovision the address range from Global
    /// Accelerator was not successful. Please make sure that you provide all of the correct
    /// information, and try again. If the request fails a second time, contact Amazon Web
    /// Services support.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ByoipCidr
    {
        private string _cidr;
        private List<ByoipCidrEvent> _events = AWSConfigs.InitializeCollections ? new List<ByoipCidrEvent>() : null;
        private ByoipCidrState _state;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The address range, in CIDR notation.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// your own IP addresses (BYOIP)</a> in the Global Accelerator Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A history of status changes for an IP address range that you bring to Global Accelerator
        /// through bring your own IP address (BYOIP).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ByoipCidrEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the address pool.
        /// </para>
        /// </summary>
        public ByoipCidrState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}