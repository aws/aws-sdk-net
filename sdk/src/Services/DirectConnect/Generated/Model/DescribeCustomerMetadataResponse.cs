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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeCustomerMetadata operation.
    /// </summary>
    public partial class DescribeCustomerMetadataResponse : AmazonWebServiceResponse
    {
        private List<CustomerAgreement> _agreements = AWSConfigs.InitializeCollections ? new List<CustomerAgreement>() : null;
        private NniPartnerType _nniPartnerType;

        /// <summary>
        /// Gets and sets the property Agreements. 
        /// <para>
        /// The list of customer agreements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerAgreement> Agreements
        {
            get { return this._agreements; }
            set { this._agreements = value; }
        }

        // Check to see if Agreements property is set
        internal bool IsSetAgreements()
        {
            return this._agreements != null && (this._agreements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NniPartnerType. 
        /// <para>
        /// The type of network-to-network interface (NNI) partner. The partner type will be one
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// V1: This partner can only allocate 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, or
        /// 500Mbps subgigabit connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// V2: This partner can only allocate 1GB, 2GB, 5GB, or 10GB hosted connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// nonPartner: The customer is not a partner.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NniPartnerType NniPartnerType
        {
            get { return this._nniPartnerType; }
            set { this._nniPartnerType = value; }
        }

        // Check to see if NniPartnerType property is set
        internal bool IsSetNniPartnerType()
        {
            return this._nniPartnerType != null;
        }

    }
}