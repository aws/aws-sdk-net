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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegration operation. Creates a zero-ETL
    /// integration with Amazon Redshift.
    /// </summary>
    public partial class CreateIntegrationRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// An optional set of non-secret key–value pairs that contains additional contextual
        /// information about the data. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// context</a> in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can only include this parameter if you specify the <c>KMSKeyId</c> parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEncryptionContext property is set.
        /// </summary>
        internal bool IsSetAdditionalEncryptionContext() => this.AdditionalEncryptionContext != null && (this.AdditionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataFilter. 
        /// <para>
        /// Data filtering options for the integration. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/zero-etl.filtering.html">Data
        /// filtering for Aurora zero-ETL integrations with Amazon Redshift</a> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/zero-etl.filtering.html">Data
        /// filtering for Amazon RDS zero-ETL integrations with Amazon Redshift</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25600)]
        public string DataFilter { get; set; }

        /// <summary>
        /// Checks to see if the DataFilter property is set.
        /// </summary>
        internal bool IsSetDataFilter() => this.DataFilter != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// The name of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationName property is set.
        /// </summary>
        internal bool IsSetIntegrationName() => this.IntegrationName != null;

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management System (Amazon Web Services KMS) key identifier
        /// for the key to use to encrypt the integration. If you don't specify an encryption
        /// key, RDS uses a default Amazon Web Services owned key. 
        /// </para>
        /// </summary>
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyId property is set.
        /// </summary>
        internal bool IsSetKMSKeyId() => this.KMSKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database to use as the source for replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The ARN of the Redshift data warehouse to use as the target for replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
