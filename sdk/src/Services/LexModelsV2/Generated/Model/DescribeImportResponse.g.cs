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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeImport operation.
    /// </summary>
    public partial class DescribeImportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the import was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <c>importStatus</c> field is <c>Failed</c>, this provides one or more reasons
        /// for the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier of the described import.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ImportId { get; set; }

        /// <summary>
        /// Checks to see if the ImportId property is set.
        /// </summary>
        internal bool IsSetImportId() => this.ImportId != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// The status of the import process. When the status is <c>Completed</c> the resource
        /// is imported and ready for use.
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property ImportedResourceId. 
        /// <para>
        /// The unique identifier that Amazon Lex assigned to the resource created by the import.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 10)]
        public string ImportedResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ImportedResourceId property is set.
        /// </summary>
        internal bool IsSetImportedResourceId() => this.ImportedResourceId != null;

        /// <summary>
        /// Gets and sets the property ImportedResourceName. 
        /// <para>
        /// The name of the imported resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ImportedResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ImportedResourceName property is set.
        /// </summary>
        internal bool IsSetImportedResourceName() => this.ImportedResourceName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the import was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// The strategy used when there was a name conflict between the imported resource and
        /// an existing resource. When the merge strategy is <c>FailOnConflict</c> existing resources
        /// are not overwritten and the import fails.
        /// </para>
        /// </summary>
        public MergeStrategy MergeStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MergeStrategy property is set.
        /// </summary>
        internal bool IsSetMergeStrategy() => this.MergeStrategy != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// The specifications of the imported bot, bot locale, or custom vocabulary.
        /// </para>
        /// </summary>
        public ImportResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;
    }
}
