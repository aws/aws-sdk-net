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
    /// This is the response object from the GetProject operation.
    /// </summary>
    public partial class GetProjectResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the project was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// including bounding boxes, granularity, and output format.
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
        /// figure captioning.
        /// </para>
        /// </summary>
        public GenerativeConfiguration GenerativeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeConfiguration property is set.
        /// </summary>
        internal bool IsSetGenerativeConfiguration() => this.GenerativeConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the project was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project.
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
        /// The description of the project.
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
        /// The name of the project.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the project, indicating whether it was created successfully or failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProjectStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
