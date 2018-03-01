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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
    /// Activates the gateway you previously deployed on your host. In the activation process,
    /// you specify information such as the region you want to use for storing snapshots or
    /// tapes, the time zone for scheduled snapshots the gateway snapshot schedule window,
    /// an activation key, and a name for your gateway. The activation process also associates
    /// your gateway with your account; for more information, see <a>UpdateGatewayInformation</a>.
    /// 
    ///  <note> 
    /// <para>
    /// You must turn on the gateway VM before you can activate your gateway.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ActivateGatewayRequest : AmazonStorageGatewayRequest
    {
        private string _activationKey;
        private string _gatewayName;
        private string _gatewayRegion;
        private string _gatewayTimezone;
        private string _gatewayType;
        private string _mediumChangerType;
        private string _tapeDriveType;

        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// Your gateway activation key. You can obtain the activation key by sending an HTTP
        /// GET request with redirects enabled to the gateway IP address (port 80). The redirect
        /// URL returned in the response provides you the activation key for your gateway in the
        /// query string parameter <code>activationKey</code>. It may also include other activation-related
        /// parameters, however, these are merely defaults -- the arguments you pass to the <code>ActivateGateway</code>
        /// API call determine the actual configuration of your gateway. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html
        /// in the Storage Gateway User Guide.
        /// </para>
        /// </summary>
        public string ActivationKey
        {
            get { return this._activationKey; }
            set { this._activationKey = value; }
        }

        // Check to see if ActivationKey property is set
        internal bool IsSetActivationKey()
        {
            return this._activationKey != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name you configured for your gateway.
        /// </para>
        /// </summary>
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this._gatewayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayRegion. 
        /// <para>
        /// A value that indicates the region where you want to store your data. The gateway region
        /// specified must be the same region as the region in your <code>Host</code> header in
        /// the request. For more information about available regions and endpoints for AWS Storage
        /// Gateway, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sg_region">Regions
        /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: "us-east-1", "us-east-2", "us-west-1", "us-west-2", "ca-central-1",
        /// "eu-west-1", "eu-central-1", "eu-west-2", "eu-west-3", "ap-northeast-1", "ap-northeast-2",
        /// "ap-southeast-1", "ap-southeast-2", "ap-south-1", "sa-east-1"
        /// </para>
        /// </summary>
        public string GatewayRegion
        {
            get { return this._gatewayRegion; }
            set { this._gatewayRegion = value; }
        }

        // Check to see if GatewayRegion property is set
        internal bool IsSetGatewayRegion()
        {
            return this._gatewayRegion != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayTimezone. 
        /// <para>
        /// A value that indicates the time zone you want to set for the gateway. The time zone
        /// is of the format "GMT-hr:mm" or "GMT+hr:mm". For example, GMT-4:00 indicates the time
        /// is 4 hours behind GMT. GMT+2:00 indicates the time is 2 hours ahead of GMT. The time
        /// zone is used, for example, for scheduling snapshots and your gateway's maintenance
        /// schedule.
        /// </para>
        /// </summary>
        public string GatewayTimezone
        {
            get { return this._gatewayTimezone; }
            set { this._gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this._gatewayTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// A value that defines the type of gateway to activate. The type specified is critical
        /// to all later functions of the gateway and cannot be changed after activation. The
        /// default value is <code>STORED</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: "STORED", "CACHED", "VTL", "FILE_S3"
        /// </para>
        /// </summary>
        public string GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

        /// <summary>
        /// Gets and sets the property MediumChangerType. 
        /// <para>
        /// The value that indicates the type of medium changer to use for tape gateway. This
        /// field is optional.
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: "STK-L700", "AWS-Gateway-VTL"
        /// </para>
        /// </summary>
        public string MediumChangerType
        {
            get { return this._mediumChangerType; }
            set { this._mediumChangerType = value; }
        }

        // Check to see if MediumChangerType property is set
        internal bool IsSetMediumChangerType()
        {
            return this._mediumChangerType != null;
        }

        /// <summary>
        /// Gets and sets the property TapeDriveType. 
        /// <para>
        /// The value that indicates the type of tape drive to use for tape gateway. This field
        /// is optional.
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: "IBM-ULT3580-TD5" 
        /// </para>
        /// </summary>
        public string TapeDriveType
        {
            get { return this._tapeDriveType; }
            set { this._tapeDriveType = value; }
        }

        // Check to see if TapeDriveType property is set
        internal bool IsSetTapeDriveType()
        {
            return this._tapeDriveType != null;
        }

    }
}