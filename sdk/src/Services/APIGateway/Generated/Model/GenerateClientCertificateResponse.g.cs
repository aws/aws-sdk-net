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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// This is the response object from the GenerateClientCertificate operation.
    /// </summary>
    public partial class GenerateClientCertificateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of the client certificate.
        /// </para>
        /// </summary>
        public string ClientCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertificateId property is set.
        /// </summary>
        internal bool IsSetClientCertificateId() => this.ClientCertificateId != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the client certificate was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the client certificate.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The timestamp when the client certificate will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property PemEncodedCertificate. 
        /// <para>
        /// The PEM-encoded public key of the client certificate, which can be used to configure
        /// certificate authentication in the integration endpoint .
        /// </para>
        /// </summary>
        public string PemEncodedCertificate { get; set; }

        /// <summary>
        /// Checks to see if the PemEncodedCertificate property is set.
        /// </summary>
        internal bool IsSetPemEncodedCertificate() => this.PemEncodedCertificate != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
