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
    /// Container for the parameters to the UpdateProject operation. Updates the configuration
    /// of an existing project. If you omit a configuration, UpdateProject leaves it unchanged.
    /// A configuration that you supply replaces the stored one, so include every setting
    /// that you want to keep.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonTextractRequest
    {
        /// <summary>
        /// Gets and sets the property CustomConfiguration. 
        /// <para>
        /// The configuration that associates blueprints with the project for custom output extraction.
        /// Replaces the stored custom configuration. To disable custom configuration, specify
        /// an empty <c>Blueprints</c> list.
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
        /// The AWS KMS encryption configuration used to encrypt the project at rest.
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
        /// including bounding boxes, granularity, and output format. Replaces the stored extraction
        /// configuration.
        /// </para>
        /// </summary>
        public ExtractionConfiguration ExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetExtractionConfiguration() => this.ExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property GenerativeConfiguration. 
        /// <para>
        /// The configuration that controls generative capabilities such as summarization and
        /// figure captioning. Replaces the stored generative configuration, so a capability that
        /// you omit is turned off.
        /// </para>
        /// </summary>
        public GenerativeConfiguration GenerativeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeConfiguration property is set.
        /// </summary>
        internal bool IsSetGenerativeConfiguration() => this.GenerativeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// The updated description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProjectDescription property is set.
        /// </summary>
        internal bool IsSetProjectDescription() => this.ProjectDescription != null;

        /// <summary>
        /// Gets and sets the property SensitiveDataConfiguration. 
        /// <para>
        /// The configuration that controls detection and redaction of sensitive data, such as
        /// personally identifiable information (PII). Replaces the stored sensitive data configuration.
        /// To turn off detection, set <c>DetectionMode</c> to <c>DISABLED</c>.
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
        /// documents. Replaces the stored splitter configuration.
        /// </para>
        /// </summary>
        public SplitterConfiguration SplitterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SplitterConfiguration property is set.
        /// </summary>
        internal bool IsSetSplitterConfiguration() => this.SplitterConfiguration != null;
    }
}
