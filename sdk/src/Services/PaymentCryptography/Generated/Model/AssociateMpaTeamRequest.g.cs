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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AssociateMpaTeam operation. Associates a Multi-Party
    /// Approval (MPA) team with a protected operation. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/mpa.html">Multi-Party
    /// Approval</a> in the <i>Amazon Web Services Payment Cryptography User Guide.</i> <para>
    /// <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts. </para> <para> <b>Related operations:</b> </para> <ul> <li> <para>
    /// <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisassociateMpaTeam.html">DisassociateMpaTeam</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetMpaTeamAssociation.html">GetMpaTeamAssociation</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class AssociateMpaTeamRequest : AmazonPaymentCryptographyRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The protected operation to associate with the MPA team. Currently, the only supported
        /// value is <c>IMPORT_ROOT_PUBLIC_KEY_CERTIFICATE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MpaOperation Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property MpaTeamArn. 
        /// <para>
        /// The ARN of the MPA team to associate with the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string MpaTeamArn { get; set; }

        /// <summary>
        /// Checks to see if the MpaTeamArn property is set.
        /// </summary>
        internal bool IsSetMpaTeamArn() => this.MpaTeamArn != null;

        /// <summary>
        /// Gets and sets the property RequesterComment. 
        /// <para>
        /// The comment from the requester explaining the reason for the association.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include personal, confidential or sensitive information in this field. This
        /// field may be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 200)]
        public string RequesterComment { get; set; }

        /// <summary>
        /// Checks to see if the RequesterComment property is set.
        /// </summary>
        internal bool IsSetRequesterComment() => this.RequesterComment != null;
    }
}
