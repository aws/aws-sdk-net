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
    /// Container for the parameters to the GetPartnerAccount operation.
    /// Gets information about a partner account. If <c>PartnerAccountId</c> and <c>PartnerType</c>
    /// are <c>null</c>, returns all partner accounts.
    /// </summary>
    public partial class GetPartnerAccountRequest : AmazonIoTWirelessRequest
    {
        private string _partnerAccountId;
        private PartnerType _partnerType;

        /// <summary>
        /// Gets and sets the property PartnerAccountId. 
        /// <para>
        /// The partner account ID to disassociate from the AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string PartnerAccountId
        {
            get { return this._partnerAccountId; }
            set { this._partnerAccountId = value; }
        }

        // Check to see if PartnerAccountId property is set
        internal bool IsSetPartnerAccountId()
        {
            return this._partnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerType. 
        /// <para>
        /// The partner type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PartnerType PartnerType
        {
            get { return this._partnerType; }
            set { this._partnerType = value; }
        }

        // Check to see if PartnerType property is set
        internal bool IsSetPartnerType()
        {
            return this._partnerType != null;
        }

    }
}