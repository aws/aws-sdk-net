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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the StartPiiEntitiesDetectionJob operation. Starts
    /// an asynchronous PII entity detection job for a collection of documents.
    /// </summary>
    public partial class StartPiiEntitiesDetectionJobRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you don't set the client request token, Amazon
        /// Comprehend generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend read
        /// access to your input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input properties for a PII entities detection job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The identifier of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the input documents. Enter the language code for English (en) or Spanish
        /// (es).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies whether the output provides the locations (offsets) of PII entities or a
        /// file in which PII entities are redacted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PiiEntitiesDetectionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Provides conﬁguration parameters for the output of PII entity detection jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property RedactionConfig. 
        /// <para>
        /// Provides configuration parameters for PII entity redaction.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you set the <c>Mode</c> parameter to <c>ONLY_REDACTION</c>.
        /// In that case, you must provide a <c>RedactionConfig</c> definition that includes the
        /// <c>PiiEntityTypes</c> parameter.
        /// </para>
        /// </summary>
        public RedactionConfig RedactionConfig { get; set; }

        /// <summary>
        /// Checks to see if the RedactionConfig property is set.
        /// </summary>
        internal bool IsSetRedactionConfig() => this.RedactionConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the PII entities detection job. A tag is a key-value pair that
        /// adds metadata to a resource used by Amazon Comprehend. For example, a tag with "Sales"
        /// as the key might be added to a resource to indicate its use by the sales department.
        /// </para>
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
    }
}
