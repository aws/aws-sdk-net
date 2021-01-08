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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the ActivateGateway operation.
    /// Activates the gateway you previously deployed on your host. In the activation process,
    /// you specify information such as the AWS Region that you want to use for storing snapshots
    /// or tapes, the time zone for scheduled snapshots the gateway snapshot schedule window,
    /// an activation key, and a name for your gateway. The activation process also associates
    /// your gateway with your account. For more information, see <a>UpdateGatewayInformation</a>.
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
        private List<Tag> _tags = new List<Tag>();
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
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html">Getting
        /// activation key</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        [AWSProperty(Required=true, Min=2, Max=255)]
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
        /// A value that indicates the AWS Region where you want to store your data. The gateway
        /// AWS Region specified must be the same AWS Region as the AWS Region in your <code>Host</code>
        /// header in the request. For more information about available AWS Regions and endpoints
        /// for AWS Storage Gateway, see <a href="https://docs.aws.amazon.com/general/latest/gr/sg.html">AWS
        /// Storage Gateway endpoints and quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: See <a href="https://docs.aws.amazon.com/general/latest/gr/sg.html">AWS
        /// Storage Gateway endpoints and quotas</a> in the <i>AWS General Reference</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
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
        [AWSProperty(Required=true, Min=3, Max=10)]
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
        /// default value is <code>CACHED</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>STORED</code> | <code>CACHED</code> | <code>VTL</code> | <code>FILE_S3</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=20)]
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
        /// Valid Values: <code>STK-L700</code> | <code>AWS-Gateway-VTL</code> | <code>IBM-03584L32-0402</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that you can assign to the gateway. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers that can be represented
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256 characters.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TapeDriveType. 
        /// <para>
        /// The value that indicates the type of tape drive to use for tape gateway. This field
        /// is optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>IBM-ULT3580-TD5</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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