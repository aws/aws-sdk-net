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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// This is the response object from the GetCertificateAssociation operation.
    /// </summary>
    public partial class GetCertificateAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AcmCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACM certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 75, Max = 256)]
        public string AcmCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmCertificateArn property is set.
        /// </summary>
        internal bool IsSetAcmCertificateArn() => this.AcmCertificateArn != null;

        /// <summary>
        /// Gets and sets the property AssociatedAt. 
        /// <para>
        /// The timestamp of when the certificate was associated.
        /// </para>
        /// </summary>
        public DateTime? AssociatedAt { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedAt property is set.
        /// </summary>
        internal bool IsSetAssociatedAt() => this.AssociatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CertificateAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the certificate association was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
