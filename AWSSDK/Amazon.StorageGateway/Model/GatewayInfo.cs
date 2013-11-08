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
    /// <summary>Gateway Info
    /// </summary>
    public partial class GatewayInfo
    {
        
        private string gatewayARN;
        private string gatewayType;
        private string gatewayOperationalState;

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
        public GatewayInfo WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }
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
        public GatewayInfo WithGatewayType(string gatewayType)
        {
            this.gatewayType = gatewayType;
            return this;
        }
            

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this.gatewayType != null;
        }
        public string GatewayOperationalState
        {
            get { return this.gatewayOperationalState; }
            set { this.gatewayOperationalState = value; }
        }

        /// <summary>
        /// Sets the GatewayOperationalState property
        /// </summary>
        /// <param name="gatewayOperationalState">The value to set for the GatewayOperationalState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GatewayInfo WithGatewayOperationalState(string gatewayOperationalState)
        {
            this.gatewayOperationalState = gatewayOperationalState;
            return this;
        }
            

        // Check to see if GatewayOperationalState property is set
        internal bool IsSetGatewayOperationalState()
        {
            return this.gatewayOperationalState != null;
        }
    }
}
