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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetAnnotationStoreVersion operation.
    /// </summary>
    public partial class GetAnnotationStoreVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time stamp for when an annotation store version was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for an annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The annotation store version ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the annotation store. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of an annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  The status of an annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StoreId. 
        /// <para>
        ///  The store ID for annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StoreId { get; set; }

        /// <summary>
        /// Checks to see if the StoreId property is set.
        /// </summary>
        internal bool IsSetStoreId() => this.StoreId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Any tags associated with an annotation store version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The time stamp for when an annotation store version was updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property VersionArn. 
        /// <para>
        ///  The Arn for the annotation store. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string VersionArn { get; set; }

        /// <summary>
        /// Checks to see if the VersionArn property is set.
        /// </summary>
        internal bool IsSetVersionArn() => this.VersionArn != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        ///  The name given to an annotation store version to distinguish it from others. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;

        /// <summary>
        /// Gets and sets the property VersionOptions. 
        /// <para>
        ///  The options for an annotation store version. 
        /// </para>
        /// </summary>
        public VersionOptions VersionOptions { get; set; }

        /// <summary>
        /// Checks to see if the VersionOptions property is set.
        /// </summary>
        internal bool IsSetVersionOptions() => this.VersionOptions != null;

        /// <summary>
        /// Gets and sets the property VersionSizeBytes. 
        /// <para>
        ///  The size of the annotation store version in Bytes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? VersionSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the VersionSizeBytes property is set.
        /// </summary>
        internal bool IsSetVersionSizeBytes() => this.VersionSizeBytes.HasValue;
    }
}
