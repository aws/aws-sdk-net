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
    /// <para>This operation activates the gateway you previously deployed on your VMware host. For more information, see Downloading and Deploying
    /// AWS Storage Gateway VM. In the activation process you specify information such as the region you want to use for storing snapshots, the time
    /// zone for scheduled snapshots and the gateway schedule window, an activation key, and a name for your gateway. The activation process also
    /// associates your gateway with your account (see UpdateGatewayInformation).</para> <para><b>NOTE:</b>You must power on the gateway VM before
    /// you can activate your gateway.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.ActivateGateway"/>
    public class ActivateGatewayRequest : AmazonWebServiceRequest
    {
        private string activationKey;
        private string gatewayName;
        private string gatewayTimezone;
        private string gatewayRegion;
        private string gatewayType;

        /// <summary>
        /// Your gateway activation key. You can obtain the activation key by sending an HTTP GET request with redirects enabled to the gateway IP
        /// address (port 80). The redirect URL returned in the response provides you the activation key for your gateway in the query string parameter
        /// <c>activationKey</c>. It may also include other activation-related parameters, however, these are merely defaults -- the arguments you pass
        /// to the <c>ActivateGateway</c> API call determine the actual configuration of your gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 50</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ActivationKey
        {
            get { return this.activationKey; }
            set { this.activationKey = value; }
        }

        /// <summary>
        /// Sets the ActivationKey property
        /// </summary>
        /// <param name="activationKey">The value to set for the ActivationKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ActivateGatewayRequest WithActivationKey(string activationKey)
        {
            this.activationKey = activationKey;
            return this;
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

        /// <summary>
        /// Sets the GatewayName property
        /// </summary>
        /// <param name="gatewayName">The value to set for the GatewayName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ActivateGatewayRequest WithGatewayName(string gatewayName)
        {
            this.gatewayName = gatewayName;
            return this;
        }
            

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this.gatewayName != null;       
        }

        /// <summary>
        /// One of the values that indicates the time zone you want to set for the gateway. The time zone is used, for example, for scheduling snapshots
        /// and your gateway's maintenance schedule.
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
        public ActivateGatewayRequest WithGatewayTimezone(string gatewayTimezone)
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
        /// One of the values that indicates the region where you want to store the snapshot backups. The gateway region specified must be the same
        /// region as the region in your <c>Host</c> header in the request. For more information about available regions and endpoints for AWS Storage
        /// Gateway, see <a href="http://docs.amazonwebservices.com/general/latest/gr/rande.html#sg_region">Regions and Endpoints</a> in the <b>Amazon
        /// Web Services Glossary</b>. <i>Valid Values</i>: "us-east-1", "us-west-1", "us-west-2", "eu-west-1", "ap-northeast-1", "ap-southest-1",
        /// "sa-east-1"
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
        public string GatewayRegion
        {
            get { return this.gatewayRegion; }
            set { this.gatewayRegion = value; }
        }

        /// <summary>
        /// Sets the GatewayRegion property
        /// </summary>
        /// <param name="gatewayRegion">The value to set for the GatewayRegion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ActivateGatewayRequest WithGatewayRegion(string gatewayRegion)
        {
            this.gatewayRegion = gatewayRegion;
            return this;
        }
            

        // Check to see if GatewayRegion property is set
        internal bool IsSetGatewayRegion()
        {
            return this.gatewayRegion != null;       
        }

        /// <summary>
        /// One of the values that defines the type of gateway to activate. The type specified is critical to all later functions of the gateway and
        /// cannot be changed after activation. The default value is <c>STORED</c>.
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
        public ActivateGatewayRequest WithGatewayType(string gatewayType)
        {
            this.gatewayType = gatewayType;
            return this;
        }
            

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this.gatewayType != null;       
        }
    }
}
    
