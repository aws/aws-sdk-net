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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> GatewayARN </li>
    /// <li> DescribeGatewayInformationOutput$GatewayId </li>
    /// <li> DescribeGatewayInformationOutput$GatewayNetworkInterfaces </li>
    /// <li> DescribeGatewayInformationOutput$GatewayState </li>
    /// <li> DescribeGatewayInformationOutput$GatewayTimezone </li>
    /// <li> DescribeGatewayInformationOutput$NextUpdateAvailabilityDate </li>
    /// 
    /// </ul>
    /// </summary>
    public class DescribeGatewayInformationResult  
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

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
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

        /// <summary>
        /// Sets the GatewayId property
        /// </summary>
        /// <param name="gatewayId">The value to set for the GatewayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayId(string gatewayId)
        {
            this.gatewayId = gatewayId;
            return this;
        }
            

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this.gatewayId != null;       
        }

        /// <summary>
        /// One of the <a>GatewayTimezone</a> values that indicates the time zone configured for the gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>GMT-12:00, GMT-11:00, GMT-10:00, GMT-9:00, GMT-8:00, GMT-7:00, GMT-6:00, GMT-5:00, GMT-4:00, GMT-3:30, GMT-3:00, GMT-2:00, GMT-1:00, GMT, GMT+1:00, GMT+2:00, GMT+3:00, GMT+3:30, GMT+4:00, GMT+4:30, GMT+5:00, GMT+5:30, GMT+5:45, GMT+6:00, GMT+7:00, GMT+8:00, GMT+9:00, GMT+9:30, GMT+10:00, GMT+11:00, GMT+12:00</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayTimezone
        {
            get { return this.gatewayTimezone; }
            set { this.gatewayTimezone = value; }
        }

        /// <summary>
        /// Sets the GatewayTimezone property
        /// </summary>
        /// <param name="gatewayTimezone">The value to set for the GatewayTimezone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayTimezone(string gatewayTimezone)
        {
            this.gatewayTimezone = gatewayTimezone;
            return this;
        }
            

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this.gatewayTimezone != null;       
        }

        /// <summary>
        /// One of the <a>GatewayState</a> values that indicates the operating state of the gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>RUNNING, SHUTDOWN</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayState
        {
            get { return this.gatewayState; }
            set { this.gatewayState = value; }
        }

        /// <summary>
        /// Sets the GatewayState property
        /// </summary>
        /// <param name="gatewayState">The value to set for the GatewayState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayState(string gatewayState)
        {
            this.gatewayState = gatewayState;
            return this;
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
        /// <summary>
        /// Adds elements to the GatewayNetworkInterfaces collection
        /// </summary>
        /// <param name="gatewayNetworkInterfaces">The values to add to the GatewayNetworkInterfaces collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayNetworkInterfaces(params NetworkInterface[] gatewayNetworkInterfaces)
        {
            foreach (NetworkInterface element in gatewayNetworkInterfaces)
            {
                this.gatewayNetworkInterfaces.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the GatewayNetworkInterfaces collection
        /// </summary>
        /// <param name="gatewayNetworkInterfaces">The values to add to the GatewayNetworkInterfaces collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayNetworkInterfaces(IEnumerable<NetworkInterface> gatewayNetworkInterfaces)
        {
            foreach (NetworkInterface element in gatewayNetworkInterfaces)
            {
                this.gatewayNetworkInterfaces.Add(element);
            }

            return this;
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
        ///         <term>Allowed Values</term>
        ///         <description>STORED, CACHED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayType
        {
            get { return this.gatewayType; }
            set { this.gatewayType = value; }
        }

        /// <summary>
        /// Sets the GatewayType property
        /// </summary>
        /// <param name="gatewayType">The value to set for the GatewayType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithGatewayType(string gatewayType)
        {
            this.gatewayType = gatewayType;
            return this;
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

        /// <summary>
        /// Sets the NextUpdateAvailabilityDate property
        /// </summary>
        /// <param name="nextUpdateAvailabilityDate">The value to set for the NextUpdateAvailabilityDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeGatewayInformationResult WithNextUpdateAvailabilityDate(string nextUpdateAvailabilityDate)
        {
            this.nextUpdateAvailabilityDate = nextUpdateAvailabilityDate;
            return this;
        }
            

        // Check to see if NextUpdateAvailabilityDate property is set
        internal bool IsSetNextUpdateAvailabilityDate()
        {
            return this.nextUpdateAvailabilityDate != null;       
        }
    }
}
