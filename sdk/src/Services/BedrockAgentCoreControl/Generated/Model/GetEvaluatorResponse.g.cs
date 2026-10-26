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
    /// This is the response object from the GetEvaluator operation.
    /// </summary>
    public partial class GetEvaluatorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the evaluator was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluatorArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorArn property is set.
        /// </summary>
        internal bool IsSetEvaluatorArn() => this.EvaluatorArn != null;

        /// <summary>
        /// Gets and sets the property EvaluatorConfig. 
        /// <para>
        ///  The configuration of the evaluator, including LLM-as-a-Judge or code-based settings.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluatorConfig EvaluatorConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorConfig property is set.
        /// </summary>
        internal bool IsSetEvaluatorConfig() => this.EvaluatorConfig != null;

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 111)]
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorId property is set.
        /// </summary>
        internal bool IsSetEvaluatorId() => this.EvaluatorId != null;

        /// <summary>
        /// Gets and sets the property EvaluatorName. 
        /// <para>
        ///  The name of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string EvaluatorName { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorName property is set.
        /// </summary>
        internal bool IsSetEvaluatorName() => this.EvaluatorName != null;

        /// <summary>
        /// Gets and sets the property EvaluatorType. 
        /// <para>
        ///  The kind of evaluator resource. Valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Builtin</c> – An Amazon Web Services-managed global evaluator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ThirdParty</c> – An Amazon Web Services-managed global evaluator from a third-party
        /// provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Custom</c> – A customer-created evaluator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomCode</c> – A customer-created code-based evaluator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomDerived</c> – A customer-created evaluator derived from an existing base
        /// evaluator.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvaluatorType EvaluatorType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorType property is set.
        /// </summary>
        internal bool IsSetEvaluatorType() => this.EvaluatorType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the customer managed KMS key used to encrypt the
        /// evaluator's sensitive data. This field is only present for evaluators encrypted with
        /// a customer managed key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        ///  The evaluation level (<c>TOOL_CALL</c>, <c>TRACE</c>, or <c>SESSION</c>) that determines
        /// the scope of evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluatorLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property LockedForModification. 
        /// <para>
        ///  Whether the evaluator is locked for modification due to being referenced by active
        /// online evaluation configurations. 
        /// </para>
        /// </summary>
        public bool? LockedForModification { get; set; }

        /// <summary>
        /// Checks to see if the LockedForModification property is set.
        /// </summary>
        internal bool IsSetLockedForModification() => this.LockedForModification.HasValue;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        ///  The source of the evaluator's logic: Amazon Web Services, a third-party library,
        /// or you. 
        /// </para>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluatorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the evaluator was last updated. 
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
