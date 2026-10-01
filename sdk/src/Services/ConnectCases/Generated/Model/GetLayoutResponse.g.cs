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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the GetLayout operation.
    /// </summary>
    public partial class GetLayoutResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Information about which fields will be present in the layout, the order of the fields,
        /// and read-only attribute of the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LayoutContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Timestamp at which the resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Denotes whether or not the resource has been deleted.
        /// </para>
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Checks to see if the Deleted property is set.
        /// </summary>
        internal bool IsSetDeleted() => this.Deleted.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Timestamp at which the resource was created or last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LayoutArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the newly created layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string LayoutArn { get; set; }

        /// <summary>
        /// Checks to see if the LayoutArn property is set.
        /// </summary>
        internal bool IsSetLayoutArn() => this.LayoutArn != null;

        /// <summary>
        /// Gets and sets the property LayoutId. 
        /// <para>
        /// The unique identifier of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string LayoutId { get; set; }

        /// <summary>
        /// Checks to see if the LayoutId property is set.
        /// </summary>
        internal bool IsSetLayoutId() => this.LayoutId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the layout. It must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of of key-value pairs that represent tags on a resource. Tags are used to organize,
        /// track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
