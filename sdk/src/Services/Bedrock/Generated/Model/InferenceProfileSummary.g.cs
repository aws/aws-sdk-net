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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains information about an inference profile.
    /// </summary>
    public partial class InferenceProfileSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the inference profile was created.
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
        /// The description of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InferenceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string InferenceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the InferenceProfileArn property is set.
        /// </summary>
        internal bool IsSetInferenceProfileArn() => this.InferenceProfileArn != null;

        /// <summary>
        /// Gets and sets the property InferenceProfileId. 
        /// <para>
        /// The unique identifier of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InferenceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the InferenceProfileId property is set.
        /// </summary>
        internal bool IsSetInferenceProfileId() => this.InferenceProfileId != null;

        /// <summary>
        /// Gets and sets the property InferenceProfileName. 
        /// <para>
        /// The name of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InferenceProfileName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceProfileName property is set.
        /// </summary>
        internal bool IsSetInferenceProfileName() => this.InferenceProfileName != null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// A list of information about each model in the inference profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<InferenceProfileModel> Models { get; set; } = AWSConfigs.InitializeCollections ? new List<InferenceProfileModel>() : null;

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null && (this.Models.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the inference profile. <c>ACTIVE</c> means that the inference profile
        /// is ready to be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the inference profile. The following types are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYSTEM_DEFINED</c> – The inference profile is defined by Amazon Bedrock. You can
        /// route inference requests across regions with these inference profiles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLICATION</c> – The inference profile was created by a user. This type of inference
        /// profile can track metrics and costs when invoking the model in it. The inference profile
        /// may route requests to one or multiple regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceProfileType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the inference profile was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
