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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the StartPolicyGeneration operation.
    /// </summary>
    public partial class StartPolicyGenerationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the policy generation request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// Initial findings from the policy generation process.
        /// </para>
        /// </summary>
        public string Findings { get; set; }

        /// <summary>
        /// Checks to see if the Findings property is set.
        /// </summary>
        internal bool IsSetFindings() => this.Findings != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned name for the policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine associated with the started policy generation.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyEngineId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineId property is set.
        /// </summary>
        internal bool IsSetPolicyEngineId() => this.PolicyEngineId != null;

        /// <summary>
        /// Gets and sets the property PolicyGenerationArn. 
        /// <para>
        /// The ARN of the created policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 103, Max = 210)]
        public string PolicyGenerationArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyGenerationArn property is set.
        /// </summary>
        internal bool IsSetPolicyGenerationArn() => this.PolicyGenerationArn != null;

        /// <summary>
        /// Gets and sets the property PolicyGenerationId. 
        /// <para>
        /// The unique identifier assigned to the policy generation request for tracking progress.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyGenerationId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyGenerationId property is set.
        /// </summary>
        internal bool IsSetPolicyGenerationId() => this.PolicyGenerationId != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource information associated with the policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The initial status of the policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyGenerationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Additional information about the generation status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the policy generation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
