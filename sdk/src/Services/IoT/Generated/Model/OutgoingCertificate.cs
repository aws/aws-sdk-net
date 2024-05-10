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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private string _certificateArn;
        private string _certificateId;
        private DateTime? _creationDate;
        private DateTime? _transferDate;
        private string _transferMessage;
        private string _transferredTo;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The certificate ARN.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The certificate ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string CertificateId
        {
            get { return this._certificateId; }
            set { this._certificateId = value; }
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The certificate creation date.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferDate. 
        /// <para>
        /// The date the transfer was initiated.
        /// </para>
        /// </summary>
        public DateTime? TransferDate
        {
            get { return this._transferDate; }
            set { this._transferDate = value; }
        }

        // Check to see if TransferDate property is set
        internal bool IsSetTransferDate()
        {
            return this._transferDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferMessage. 
        /// <para>
        /// The transfer message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TransferMessage
        {
            get { return this._transferMessage; }
            set { this._transferMessage = value; }
        }

        // Check to see if TransferMessage property is set
        internal bool IsSetTransferMessage()
        {
            return this._transferMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TransferredTo. 
        /// <para>
        /// The Amazon Web Services account to which the transfer was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string TransferredTo
        {
            get { return this._transferredTo; }
            set { this._transferredTo = value; }
        }

        // Check to see if TransferredTo property is set
        internal bool IsSetTransferredTo()
        {
            return this._transferredTo != null;
        }

    }
}