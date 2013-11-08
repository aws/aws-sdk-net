/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// </summary>
    public partial class DescribeGatewayInformationResult : AmazonWebServiceResponse
    {
        
        private string gatewayARN;
        private string gatewayId;
        private string gatewayTimezone;
        private string gatewayState;
        private List<NetworkInterface> gatewayNetworkInterfaces = new List<NetworkInterface>();
        private string gatewayType;
        private string nextUpdateAvailabilityDate;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

        /// <summary>
        /// The gateway ID.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>12 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayId
        {
            get { return this.gatewayId; }
            set { this.gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this.gatewayId != null;
        }

        /// <summary>
        /// One of the values that indicates the time zone configured for the gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayTimezone
        {
            get { return this.gatewayTimezone; }
            set { this.gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this.gatewayTimezone != null;
        }

        /// <summary>
        /// One of the values that indicates the operating state of the gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 25</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayState
        {
            get { return this.gatewayState; }
            set { this.gatewayState = value; }
        }

        // Check to see if GatewayState property is set
        internal bool IsSetGatewayState()
        {
            return this.gatewayState != null;
        }

        /// <summary>
        /// A <a>NetworkInterface</a> array that contains descriptions of the gateway network interfaces.
        ///  
        /// </summary>
        public List<NetworkInterface> GatewayNetworkInterfaces
        {
            get { return this.gatewayNetworkInterfaces; }
            set { this.gatewayNetworkInterfaces = value; }
        }

        // Check to see if GatewayNetworkInterfaces property is set
        internal bool IsSetGatewayNetworkInterfaces()
        {
            return this.gatewayNetworkInterfaces.Count > 0;
        }

        /// <summary>
        /// TBD
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 20</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayType
        {
            get { return this.gatewayType; }
            set { this.gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this.gatewayType != null;
        }

        /// <summary>
        /// The date at which an update to the gateway is available. This date is in the time zone of the gateway. If the gateway is not available for
        /// an update this field is not returned in the response. <!-- Q: [eronh] This next sentence doesn't seem to agree with the preceding one, nor
        /// does it agree with the response example. -->
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 25</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextUpdateAvailabilityDate
        {
            get { return this.nextUpdateAvailabilityDate; }
            set { this.nextUpdateAvailabilityDate = value; }
        }

        // Check to see if NextUpdateAvailabilityDate property is set
        internal bool IsSetNextUpdateAvailabilityDate()
        {
            return this.nextUpdateAvailabilityDate != null;
        }
    }
}
