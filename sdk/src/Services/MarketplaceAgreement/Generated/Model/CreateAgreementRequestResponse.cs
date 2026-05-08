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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// This is the response object from the CreateAgreementRequest operation.
    /// </summary>
    public partial class CreateAgreementRequestResponse : AmazonWebServiceResponse
    {
        private string _agreementRequestId;
        private ChargeSummary _chargeSummary;

        /// <summary>
        /// Gets and sets the property AgreementRequestId. 
        /// <para>
        /// The unique identifier of the agreement request created. Use this identifier with <c>AcceptAgreementRequest</c>
        /// to accept the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementRequestId
        {
            get { return this._agreementRequestId; }
            set { this._agreementRequestId = value; }
        }

        // Check to see if AgreementRequestId property is set
        internal bool IsSetAgreementRequestId()
        {
            return this._agreementRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeSummary. 
        /// <para>
        /// Provides details of the charges associated with the agreement request. This is only
        /// applicable when a request is created for <c>PurchaseAgreement</c>.
        /// </para>
        /// </summary>
        public ChargeSummary ChargeSummary
        {
            get { return this._chargeSummary; }
            set { this._chargeSummary = value; }
        }

        // Check to see if ChargeSummary property is set
        internal bool IsSetChargeSummary()
        {
            return this._chargeSummary != null;
        }

    }
}