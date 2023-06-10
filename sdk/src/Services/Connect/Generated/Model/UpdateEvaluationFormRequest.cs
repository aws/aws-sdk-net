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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEvaluationForm operation.
    /// Updates details about a specific evaluation form version in the specified Amazon Connect
    /// instance. Question and section identifiers cannot be duplicated within the same evaluation
    /// form.
    /// 
    ///  
    /// <para>
    /// This operation does not support partial updates. Instead it does a full update of
    /// evaluation form content.
    /// </para>
    /// </summary>
    public partial class UpdateEvaluationFormRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private bool? _createNewVersion;
        private string _description;
        private string _evaluationFormId;
        private int? _evaluationFormVersion;
        private string _instanceId;
        private List<EvaluationFormItem> _items = new List<EvaluationFormItem>();
        private EvaluationFormScoringStrategy _scoringStrategy;
        private string _title;

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
        /// Gets and sets the property CreateNewVersion. 
        /// <para>
        /// A flag indicating whether the operation must create a new version.
        /// </para>
        /// </summary>
        public bool CreateNewVersion
        {
            get { return this._createNewVersion.GetValueOrDefault(); }
            set { this._createNewVersion = value; }
        }

        // Check to see if CreateNewVersion property is set
        internal bool IsSetCreateNewVersion()
        {
            return this._createNewVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EvaluationFormId
        {
            get { return this._evaluationFormId; }
            set { this._evaluationFormId = value; }
        }

        // Check to see if EvaluationFormId property is set
        internal bool IsSetEvaluationFormId()
        {
            return this._evaluationFormId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// A version of the evaluation form to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int EvaluationFormVersion
        {
            get { return this._evaluationFormVersion.GetValueOrDefault(); }
            set { this._evaluationFormVersion = value; }
        }

        // Check to see if EvaluationFormVersion property is set
        internal bool IsSetEvaluationFormVersion()
        {
            return this._evaluationFormVersion.HasValue; 
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
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<EvaluationFormItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
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
        /// Gets and sets the property Title. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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