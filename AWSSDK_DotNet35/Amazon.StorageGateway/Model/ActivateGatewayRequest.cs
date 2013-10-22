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
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the ActivateGateway operation.
    /// 
    /// </summary>
    public partial class ActivateGatewayRequest : AmazonWebServiceRequest
    {
        private string activationKey;
        private string gatewayName;
        private GatewayTimezone gatewayTimezone;
        private string gatewayRegion;
        private GatewayType gatewayType;
        public string ActivationKey
        {
            get { return this.activationKey; }
            set { this.activationKey = value; }
        }

        // Check to see if ActivationKey property is set
        internal bool IsSetActivationKey()
        {
            return this.activationKey != null;
        }

        /// <summary>
        /// A unique identifier for your gateway. This name becomes part of the gateway Amazon Resources Name (ARN) which is what you use as an input to
        /// other operations.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[ -\.0-\[\]-~]*[!-\.0-\[\]-~][ -\.0-\[\]-~]*$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayName
        {
            get { return this.gatewayName; }
            set { this.gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this.gatewayName != null;
        }
        public GatewayTimezone GatewayTimezone
        {
            get { return this.gatewayTimezone; }
            set { this.gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this.gatewayTimezone != null;
        }
        public string GatewayRegion
        {
            get { return this.gatewayRegion; }
            set { this.gatewayRegion = value; }
        }

        // Check to see if GatewayRegion property is set
        internal bool IsSetGatewayRegion()
        {
            return this.gatewayRegion != null;
        }
        public GatewayType GatewayType
        {
            get { return this.gatewayType; }
            set { this.gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this.gatewayType != null;
        }

    }
}
    
