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
    /// This is the response object from the UpdateRelatedItem operation.
    /// </summary>
    public partial class UpdateRelatedItemResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// Time at which the related item was associated with the case.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssociationTime { get; set; }

        /// <summary>
        /// Checks to see if the AssociationTime property is set.
        /// </summary>
        internal bool IsSetAssociationTime() => this.AssociationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Represents the content of the updated related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelatedItemContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Represents the creator of the related item.
        /// </para>
        /// </summary>
        public UserUnion CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedUser. 
        /// <para>
        /// Represents the last user that updated the related item.
        /// </para>
        /// </summary>
        public UserUnion LastUpdatedUser { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedUser property is set.
        /// </summary>
        internal bool IsSetLastUpdatedUser() => this.LastUpdatedUser != null;

        /// <summary>
        /// Gets and sets the property RelatedItemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string RelatedItemArn { get; set; }

        /// <summary>
        /// Checks to see if the RelatedItemArn property is set.
        /// </summary>
        internal bool IsSetRelatedItemArn() => this.RelatedItemArn != null;

        /// <summary>
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// The unique identifier of the updated related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string RelatedItemId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedItemId property is set.
        /// </summary>
        internal bool IsSetRelatedItemId() => this.RelatedItemId != null;

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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the updated related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelatedItemType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
