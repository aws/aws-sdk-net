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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEvaluationForm operation.
    /// Creates an evaluation form in the specified Amazon Connect instance. The form can
    /// be used to define questions related to agent performance, and create sections to organize
    /// such questions. Question and section identifiers cannot be duplicated within the same
    /// evaluation form.
    /// </summary>
    public partial class CreateEvaluationFormRequest : AmazonConnectRequest
    {
        private bool? _asDraft;
        private EvaluationFormAutoEvaluationConfiguration _autoEvaluationConfiguration;
        private string _clientToken;
        private string _description;
        private string _instanceId;
        private List<EvaluationFormItem> _items = AWSConfigs.InitializeCollections ? new List<EvaluationFormItem>() : null;
        private EvaluationFormLanguageConfiguration _languageConfiguration;
        private EvaluationFormScoringStrategy _scoringStrategy;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private EvaluationFormTargetConfiguration _targetConfiguration;
        private string _title;

        /// <summary>
        /// Gets and sets the property AsDraft. 
        /// <para>
        /// A boolean flag indicating whether to create evaluation form in draft state.
        /// </para>
        /// </summary>
        public bool? AsDraft
        {
            get { return this._asDraft; }
            set { this._asDraft = value; }
        }

        // Check to see if AsDraft property is set
        internal bool IsSetAsDraft()
        {
            return this._asDraft.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoEvaluationConfiguration. 
        /// <para>
        /// Configuration information about automated evaluations.
        /// </para>
        /// </summary>
        public EvaluationFormAutoEvaluationConfiguration AutoEvaluationConfiguration
        {
            get { return this._autoEvaluationConfiguration; }
            set { this._autoEvaluationConfiguration = value; }
        }

        // Check to see if AutoEvaluationConfiguration property is set
        internal bool IsSetAutoEvaluationConfiguration()
        {
            return this._autoEvaluationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the evaluation form.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Items that are part of the evaluation form. The total number of sections and questions
        /// must not exceed 100 each. Questions must be contained in a section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EvaluationFormItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LanguageConfiguration. 
        /// <para>
        /// Configuration for language settings of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormLanguageConfiguration LanguageConfiguration
        {
            get { return this._languageConfiguration; }
            set { this._languageConfiguration = value; }
        }

        // Check to see if LanguageConfiguration property is set
        internal bool IsSetLanguageConfiguration()
        {
            return this._languageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScoringStrategy. 
        /// <para>
        /// A scoring strategy of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormScoringStrategy ScoringStrategy
        {
            get { return this._scoringStrategy; }
            set { this._scoringStrategy = value; }
        }

        // Check to see if ScoringStrategy property is set
        internal bool IsSetScoringStrategy()
        {
            return this._scoringStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Configuration that specifies the target for the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormTargetConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}