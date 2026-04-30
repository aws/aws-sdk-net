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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the GetMpaTeamAssociation operation.
    /// Returns the Multi-Party Approval (MPA) team association for a protected operation.
    /// 
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_AssociateMpaTeam.html">AssociateMpaTeam</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisassociateMpaTeam.html">DisassociateMpaTeam</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetMpaTeamAssociationRequest : AmazonPaymentCryptographyRequest
    {
        private MpaOperation _action;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The protected operation whose MPA team association you want to retrieve. Currently,
        /// the only supported value is <c>IMPORT_ROOT_PUBLIC_KEY_CERTIFICATE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MpaOperation Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

    }
}