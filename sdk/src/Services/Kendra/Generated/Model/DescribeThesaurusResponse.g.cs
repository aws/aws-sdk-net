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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the DescribeThesaurus operation.
    /// </summary>
    public partial class DescribeThesaurusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the thesaurus was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The thesaurus description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// provides more information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FileSizeBytes. 
        /// <para>
        /// The size of the thesaurus file in bytes.
        /// </para>
        /// </summary>
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the FileSizeBytes property is set.
        /// </summary>
        internal bool IsSetFileSizeBytes() => this.FileSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The thesaurus name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An IAM role that gives Amazon Kendra permissions to access thesaurus file specified
        /// in <c>SourceS3Path</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SourceS3Path.
        /// </summary>
        public S3Path SourceS3Path { get; set; }

        /// <summary>
        /// Checks to see if the SourceS3Path property is set.
        /// </summary>
        internal bool IsSetSourceS3Path() => this.SourceS3Path != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the thesaurus. When the value is <c>ACTIVE</c>, queries are
        /// able to use the thesaurus. If the <c>Status</c> field value is <c>FAILED</c>, the
        /// <c>ErrorMessage</c> field provides more information. 
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>ACTIVE_BUT_UPDATE_FAILED</c>, it means that Amazon Kendra could
        /// not ingest the new thesaurus file. The old thesaurus file is still active. 
        /// </para>
        /// </summary>
        public ThesaurusStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SynonymRuleCount. 
        /// <para>
        /// The number of synonym rules in the thesaurus file.
        /// </para>
        /// </summary>
        public long? SynonymRuleCount { get; set; }

        /// <summary>
        /// Checks to see if the SynonymRuleCount property is set.
        /// </summary>
        internal bool IsSetSynonymRuleCount() => this.SynonymRuleCount.HasValue;

        /// <summary>
        /// Gets and sets the property TermCount. 
        /// <para>
        /// The number of unique terms in the thesaurus file. For example, the synonyms <c>a,b,c</c>
        /// and <c>a=>d</c>, the term count would be 4. 
        /// </para>
        /// </summary>
        public long? TermCount { get; set; }

        /// <summary>
        /// Checks to see if the TermCount property is set.
        /// </summary>
        internal bool IsSetTermCount() => this.TermCount.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the thesaurus was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
