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

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Summary information about the assistant association.
    /// </summary>
    public partial class AssistantAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property AssistantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Wisdom assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantArn { get; set; }

        /// <summary>
        /// Checks to see if the AssistantArn property is set.
        /// </summary>
        internal bool IsSetAssistantArn() => this.AssistantArn != null;

        /// <summary>
        /// Gets and sets the property AssistantAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the assistant association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the AssistantAssociationArn property is set.
        /// </summary>
        internal bool IsSetAssistantAssociationArn() => this.AssistantAssociationArn != null;

        /// <summary>
        /// Gets and sets the property AssistantAssociationId. 
        /// <para>
        /// The identifier of the assistant association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantAssociationId property is set.
        /// </summary>
        internal bool IsSetAssistantAssociationId() => this.AssistantAssociationId != null;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Wisdom assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property AssociationData. 
        /// <para>
        /// The association data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssistantAssociationOutputData AssociationData { get; set; }

        /// <summary>
        /// Checks to see if the AssociationData property is set.
        /// </summary>
        internal bool IsSetAssociationData() => this.AssociationData != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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
