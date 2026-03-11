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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private DateTime? _createdAt;
        private string _description;
        private string _evaluatorArn;
        private EvaluatorConfig _evaluatorConfig;
        private string _evaluatorId;
        private string _evaluatorName;
        private EvaluatorLevel _level;
        private bool? _lockedForModification;
        private EvaluatorStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the evaluator was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorArn
        {
            get { return this._evaluatorArn; }
            set { this._evaluatorArn = value; }
        }

        // Check to see if EvaluatorArn property is set
        internal bool IsSetEvaluatorArn()
        {
            return this._evaluatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorConfig. 
        /// <para>
        ///  The configuration of the evaluator, including LLM-as-a-Judge settings for custom
        /// evaluators. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluatorConfig EvaluatorConfig
        {
            get { return this._evaluatorConfig; }
            set { this._evaluatorConfig = value; }
        }

        // Check to see if EvaluatorConfig property is set
        internal bool IsSetEvaluatorConfig()
        {
            return this._evaluatorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorId
        {
            get { return this._evaluatorId; }
            set { this._evaluatorId = value; }
        }

        // Check to see if EvaluatorId property is set
        internal bool IsSetEvaluatorId()
        {
            return this._evaluatorId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorName. 
        /// <para>
        ///  The name of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorName
        {
            get { return this._evaluatorName; }
            set { this._evaluatorName = value; }
        }

        // Check to see if EvaluatorName property is set
        internal bool IsSetEvaluatorName()
        {
            return this._evaluatorName != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        ///  The evaluation level (<c>TOOL_CALL</c>, <c>TRACE</c>, or <c>SESSION</c>) that determines
        /// the scope of evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluatorLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property LockedForModification. 
        /// <para>
        ///  Whether the evaluator is locked for modification due to being referenced by active
        /// online evaluation configurations. 
        /// </para>
        /// </summary>
        public bool? LockedForModification
        {
            get { return this._lockedForModification; }
            set { this._lockedForModification = value; }
        }

        // Check to see if LockedForModification property is set
        internal bool IsSetLockedForModification()
        {
            return this._lockedForModification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluatorStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the evaluator was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}