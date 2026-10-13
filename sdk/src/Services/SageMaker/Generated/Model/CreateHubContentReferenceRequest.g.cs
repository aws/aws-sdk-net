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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHubContentReference operation. Create a
    /// hub content reference in order to add a model in the JumpStart public hub to a private
    /// hub.
    /// </summary>
    public partial class CreateHubContentReferenceRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content to reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string HubContentName { get; set; }

        /// <summary>
        /// Checks to see if the HubContentName property is set.
        /// </summary>
        internal bool IsSetHubContentName() => this.HubContentName != null;

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub to add the hub content reference to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HubName { get; set; }

        /// <summary>
        /// Checks to see if the HubName property is set.
        /// </summary>
        internal bool IsSetHubName() => this.HubName != null;

        /// <summary>
        /// Gets and sets the property MinVersion. 
        /// <para>
        /// The minimum version of the hub content to reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 14)]
        public string MinVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinVersion property is set.
        /// </summary>
        internal bool IsSetMinVersion() => this.MinVersion != null;

        /// <summary>
        /// Gets and sets the property SageMakerPublicHubContentArn. 
        /// <para>
        /// The ARN of the public hub content to reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string SageMakerPublicHubContentArn { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerPublicHubContentArn property is set.
        /// </summary>
        internal bool IsSetSageMakerPublicHubContentArn() => this.SageMakerPublicHubContentArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags associated with the hub content to reference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
