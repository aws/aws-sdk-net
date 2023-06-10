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

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Container for the parameters to the ConfigureAccessPoint operation.
    /// Configures the specified network resource. 
    /// 
    ///  
    /// <para>
    ///  Use this action to specify the geographic position of the hardware. You must provide
    /// Certified Professional Installer (CPI) credentials in the request so that we can obtain
    /// spectrum grants. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html">Radio
    /// units</a> in the <i>Amazon Web Services Private 5G User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class ConfigureAccessPointRequest : AmazonPrivate5GRequest
    {
        private string _accessPointArn;
        private string _cpiSecretKey;
        private string _cpiUserId;
        private string _cpiUsername;
        private string _cpiUserPassword;
        private Position _position;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property CpiSecretKey. 
        /// <para>
        /// A Base64 encoded string of the CPI certificate associated with the CPI user who is
        /// certifying the coordinates of the network resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100000)]
        public string CpiSecretKey
        {
            get { return this._cpiSecretKey; }
            set { this._cpiSecretKey = value; }
        }

        // Check to see if CpiSecretKey property is set
        internal bool IsSetCpiSecretKey()
        {
            return this._cpiSecretKey != null;
        }

        /// <summary>
        /// Gets and sets the property CpiUserId. 
        /// <para>
        /// The CPI user ID of the CPI user who is certifying the coordinates of the network resource.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string CpiUserId
        {
            get { return this._cpiUserId; }
            set { this._cpiUserId = value; }
        }

        // Check to see if CpiUserId property is set
        internal bool IsSetCpiUserId()
        {
            return this._cpiUserId != null;
        }

        /// <summary>
        /// Gets and sets the property CpiUsername. 
        /// <para>
        /// The CPI user name of the CPI user who is certifying the coordinates of the radio unit.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string CpiUsername
        {
            get { return this._cpiUsername; }
            set { this._cpiUsername = value; }
        }

        // Check to see if CpiUsername property is set
        internal bool IsSetCpiUsername()
        {
            return this._cpiUsername != null;
        }

        /// <summary>
        /// Gets and sets the property CpiUserPassword. 
        /// <para>
        /// The CPI password associated with the CPI certificate in <code>cpiSecretKey</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string CpiUserPassword
        {
            get { return this._cpiUserPassword; }
            set { this._cpiUserPassword = value; }
        }

        // Check to see if CpiUserPassword property is set
        internal bool IsSetCpiUserPassword()
        {
            return this._cpiUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the network resource.
        /// </para>
        /// </summary>
        public Position Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

    }
}