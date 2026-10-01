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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the StartImport operation.
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class StartImportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// A timestamp for the date and time that the import job was requested.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The identifier for the specific import job.
        /// </para>
        /// </summary>
        public string ImportId { get; set; }

        /// <summary>
        /// Checks to see if the ImportId property is set.
        /// </summary>
        internal bool IsSetImportId() => this.ImportId != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// The status of the import job. If the status is <c>FAILED</c>, you can get the reason
        /// for the failure using the <c>GetImport</c> operation.
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// The action to take when there is a merge conflict.
        /// </para>
        /// </summary>
        public MergeStrategy MergeStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MergeStrategy property is set.
        /// </summary>
        internal bool IsSetMergeStrategy() => this.MergeStrategy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name given to the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to import.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags added to the imported bot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
