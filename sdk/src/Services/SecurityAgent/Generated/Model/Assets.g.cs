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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The collection of assets used in a pentest configuration, including endpoints, actors,
    /// documents, source code repositories, and integrated repositories.
    /// </summary>
    public partial class Assets
    {
        /// <summary>
        /// Gets and sets the property Actors. 
        /// <para>
        /// The list of actors used during penetration testing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Actor> Actors { get; set; } = AWSConfigs.InitializeCollections ? new List<Actor>() : null;

        /// <summary>
        /// Checks to see if the Actors property is set.
        /// </summary>
        internal bool IsSetActors() => this.Actors != null && (this.Actors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The list of documents that provide context for the pentest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> Documents { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;

        /// <summary>
        /// Checks to see if the Documents property is set.
        /// </summary>
        internal bool IsSetDocuments() => this.Documents != null && (this.Documents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The list of endpoints to test during the pentest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Endpoint> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<Endpoint>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegratedRepositories. 
        /// <para>
        /// The list of integrated repositories associated with the pentest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegratedRepository> IntegratedRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegratedRepository>() : null;

        /// <summary>
        /// Checks to see if the IntegratedRepositories property is set.
        /// </summary>
        internal bool IsSetIntegratedRepositories() => this.IntegratedRepositories != null && (this.IntegratedRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceCode. 
        /// <para>
        /// The list of source code repositories to analyze during the pentest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCodeRepository> SourceCode { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceCodeRepository>() : null;

        /// <summary>
        /// Checks to see if the SourceCode property is set.
        /// </summary>
        internal bool IsSetSourceCode() => this.SourceCode != null && (this.SourceCode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustedCaCertificates. 
        /// <para>
        /// The trust anchors used to validate target endpoint TLS certificates. Provide these
        /// for endpoints served by a private or internal certificate authority (CA), an intermediate
        /// CA, or a self-signed certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrustedCaCertificate> TrustedCaCertificates { get; set; } = AWSConfigs.InitializeCollections ? new List<TrustedCaCertificate>() : null;

        /// <summary>
        /// Checks to see if the TrustedCaCertificates property is set.
        /// </summary>
        internal bool IsSetTrustedCaCertificates() => this.TrustedCaCertificates != null && (this.TrustedCaCertificates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
