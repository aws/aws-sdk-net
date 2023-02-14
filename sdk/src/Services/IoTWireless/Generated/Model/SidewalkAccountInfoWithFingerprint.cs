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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Information about a Sidewalk account.
    /// </summary>
    public partial class SidewalkAccountInfoWithFingerprint
    {
        private string _amazonId;
        private string _arn;
        private string _fingerprint;

        /// <summary>
        /// Gets and sets the property AmazonId. 
        /// <para>
        /// The Sidewalk Amazon ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string AmazonId
        {
            get { return this._amazonId; }
            set { this._amazonId = value; }
        }

        // Check to see if AmazonId property is set
        internal bool IsSetAmazonId()
        {
            return this._amazonId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name of the resource.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Fingerprint. 
        /// <para>
        /// The fingerprint of the Sidewalk application server private key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=64, Max=64)]
        public string Fingerprint
        {
            get { return this._fingerprint; }
            set { this._fingerprint = value; }
        }

        // Check to see if Fingerprint property is set
        internal bool IsSetFingerprint()
        {
            return this._fingerprint != null;
        }

    }
}