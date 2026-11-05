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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// A certificate that has been transferred but not yet accepted.
    /// </summary>
    public partial class OutgoingCertificate
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The certificate ARN.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The certificate ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The certificate creation date.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property TransferDate. 
        /// <para>
        /// The date the transfer was initiated.
        /// </para>
        /// </summary>
        public DateTime? TransferDate { get; set; }

        /// <summary>
        /// Checks to see if the TransferDate property is set.
        /// </summary>
        internal bool IsSetTransferDate() => this.TransferDate.HasValue;

        /// <summary>
        /// Gets and sets the property TransferMessage. 
        /// <para>
        /// The transfer message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TransferMessage { get; set; }

        /// <summary>
        /// Checks to see if the TransferMessage property is set.
        /// </summary>
        internal bool IsSetTransferMessage() => this.TransferMessage != null;

        /// <summary>
        /// Gets and sets the property TransferredTo. 
        /// <para>
        /// The Amazon Web Services account to which the transfer was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string TransferredTo { get; set; }

        /// <summary>
        /// Checks to see if the TransferredTo property is set.
        /// </summary>
        internal bool IsSetTransferredTo() => this.TransferredTo != null;
    }
}
