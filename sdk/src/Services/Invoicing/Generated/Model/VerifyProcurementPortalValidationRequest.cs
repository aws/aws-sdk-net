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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Container for the parameters to the VerifyProcurementPortalValidation operation.
    /// <i> <b>This feature API is subject to changing at any time. For more information,
    /// see the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service
    /// Terms</a> (Betas and Previews).</b> </i> 
    /// 
    ///  
    /// <para>
    /// Submits a validation code to complete the validation of a procurement portal preference.
    /// Use this operation after calling <c>SendProcurementPortalValidation</c> to confirm
    /// ownership and connectivity of the configured procurement portal endpoint.
    /// </para>
    /// </summary>
    public partial class VerifyProcurementPortalValidationRequest : AmazonInvoicingRequest
    {
        private string _clientToken;
        private string _code;
        private string _procurementPortalPreferenceArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The validation code received from the procurement portal in response to a previous
        /// <c>SendProcurementPortalValidation</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property ProcurementPortalPreferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the procurement portal preference to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProcurementPortalPreferenceArn
        {
            get { return this._procurementPortalPreferenceArn; }
            set { this._procurementPortalPreferenceArn = value; }
        }

        // Check to see if ProcurementPortalPreferenceArn property is set
        internal bool IsSetProcurementPortalPreferenceArn()
        {
            return this._procurementPortalPreferenceArn != null;
        }

    }
}