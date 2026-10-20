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
    /// Provides summary information about an import in an import list.
    /// </summary>
    public partial class ImportSummary
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
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier that Amazon Lex assigned to the import.
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
        /// The status of the resource. When the status is <c>Completed</c> the resource is ready
        /// to build.
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
        /// The unique identifier that Amazon Lex assigned to the imported resource.
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
        /// The name that you gave the imported resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ImportedResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ImportedResourceName property is set.
        /// </summary>
        internal bool IsSetImportedResourceName() => this.ImportedResourceName != null;

        /// <summary>
        /// Gets and sets the property ImportedResourceType. 
        /// <para>
        /// The type of resource that was imported.
        /// </para>
        /// </summary>
        public ImportResourceType ImportedResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ImportedResourceType property is set.
        /// </summary>
        internal bool IsSetImportedResourceType() => this.ImportedResourceType != null;

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
        /// The strategy used to merge existing bot or bot locale definitions with the imported
        /// definition.
        /// </para>
        /// </summary>
        public MergeStrategy MergeStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MergeStrategy property is set.
        /// </summary>
        internal bool IsSetMergeStrategy() => this.MergeStrategy != null;
    }
}
