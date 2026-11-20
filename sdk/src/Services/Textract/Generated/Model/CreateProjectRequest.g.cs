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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation. Creates a project that
    /// groups the configuration used to run document insights jobs.
    /// </summary>
    public partial class CreateProjectRequest : AmazonTextractRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you use the same token for a request that matches
        /// a previous request, the service ignores the request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CustomConfiguration. 
        /// <para>
        /// The configuration that associates blueprints with the project for custom output extraction.
        /// </para>
        /// </summary>
        public CustomConfiguration CustomConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomConfiguration() => this.CustomConfiguration != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The AWS KMS encryption configuration used to encrypt the project at rest. If you don't
        /// specify a value, Amazon Textract encrypts the project using an AWS owned key.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExtractionConfiguration. 
        /// <para>
        /// The configuration that controls how Amazon Textract extracts content from the document,
        /// including bounding boxes, granularity, and output format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractionConfiguration ExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetExtractionConfiguration() => this.ExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property GenerativeConfiguration. 
        /// <para>
        /// The configuration that controls generative capabilities such as summarization and
        /// figure captioning.
        /// </para>
        /// </summary>
        public GenerativeConfiguration GenerativeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeConfiguration property is set.
        /// </summary>
        internal bool IsSetGenerativeConfiguration() => this.GenerativeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// A description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProjectDescription property is set.
        /// </summary>
        internal bool IsSetProjectDescription() => this.ProjectDescription != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// A unique name for the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property SensitiveDataConfiguration. 
        /// <para>
        /// The configuration that controls detection and redaction of sensitive data, such as
        /// personally identifiable information (PII).
        /// </para>
        /// </summary>
        public SensitiveDataConfiguration SensitiveDataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveDataConfiguration property is set.
        /// </summary>
        internal bool IsSetSensitiveDataConfiguration() => this.SensitiveDataConfiguration != null;

        /// <summary>
        /// Gets and sets the property SplitterConfiguration. 
        /// <para>
        /// The configuration that controls whether multi-document packets are split into individual
        /// documents.
        /// </para>
        /// </summary>
        public SplitterConfiguration SplitterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SplitterConfiguration property is set.
        /// </summary>
        internal bool IsSetSplitterConfiguration() => this.SplitterConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) to assign to the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
