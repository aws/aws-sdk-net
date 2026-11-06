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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A trust store.
    /// </summary>
    public partial class TrustStore
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The trust store's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The trust store's ID.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The trust store's last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The trust store's name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfCaCertificates. 
        /// <para>
        /// The trust store's number of CA certificates.
        /// </para>
        /// </summary>
        public int? NumberOfCaCertificates { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfCaCertificates property is set.
        /// </summary>
        internal bool IsSetNumberOfCaCertificates() => this.NumberOfCaCertificates.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The trust store's reason.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The trust store's status.
        /// </para>
        /// </summary>
        public TrustStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UseClientCertificateOCSPEndpoint. 
        /// <para>
        /// A Boolean that determines whether the trust store uses the CA certificate's OCSP endpoint
        /// to check certificate revocation status.
        /// </para>
        /// </summary>
        public bool? UseClientCertificateOCSPEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UseClientCertificateOCSPEndpoint property is set.
        /// </summary>
        internal bool IsSetUseClientCertificateOCSPEndpoint() => this.UseClientCertificateOCSPEndpoint.HasValue;
    }
}
