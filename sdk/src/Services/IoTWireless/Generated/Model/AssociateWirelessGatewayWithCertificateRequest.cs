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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateWirelessGatewayWithCertificate operation.
    /// Associates a wireless gateway with a certificate.
    /// </summary>
    public partial class AssociateWirelessGatewayWithCertificateRequest : AmazonIoTWirelessRequest
    {
        private string _id;
        private string _iotCertificateId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IotCertificateId. 
        /// <para>
        /// The ID of the certificate to associate with the wireless gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string IotCertificateId
        {
            get { return this._iotCertificateId; }
            set { this._iotCertificateId = value; }
        }

        // Check to see if IotCertificateId property is set
        internal bool IsSetIotCertificateId()
        {
            return this._iotCertificateId != null;
        }

    }
}