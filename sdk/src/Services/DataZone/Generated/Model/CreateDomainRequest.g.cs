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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomain operation. Creates an Amazon DataZone
    /// domain.
    /// </summary>
    public partial class CreateDomainRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainExecutionRole. 
        /// <para>
        /// The domain execution role that is created when an Amazon DataZone domain is created.
        /// The domain execution role is created in the Amazon Web Services account that houses
        /// the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string DomainExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the DomainExecutionRole property is set.
        /// </summary>
        internal bool IsSetDomainExecutionRole() => this.DomainExecutionRole != null;

        /// <summary>
        /// Gets and sets the property DomainVersion. 
        /// <para>
        /// The version of the domain that is created.
        /// </para>
        /// </summary>
        public DomainVersion DomainVersion { get; set; }

        /// <summary>
        /// Checks to see if the DomainVersion property is set.
        /// </summary>
        internal bool IsSetDomainVersion() => this.DomainVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the Amazon Web Services Key Management Service (KMS) key that is
        /// used to encrypt the Amazon DataZone domain, metadata, and reporting data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role of the domain that is created.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property SingleSignOn. 
        /// <para>
        /// The single-sign on configuration of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public SingleSignOn SingleSignOn { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOn property is set.
        /// </summary>
        internal bool IsSetSingleSignOn() => this.SingleSignOn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags specified for the Amazon DataZone domain.
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
