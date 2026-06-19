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
    /// Information about a finding from the evaluation form validation process. Each finding
    /// identifies a structural issue or quality improvement opportunity for the evaluation
    /// form.
    /// </summary>
    public partial class EvaluationFormValidationFinding
    {
        private string _description;
        private string _issueCode;
        private List<EvaluationFormValidationFindingItem> _items = AWSConfigs.InitializeCollections ? new List<EvaluationFormValidationFindingItem>() : null;
        private EvaluationFormValidationFindingSeverity _severity;
        private string _suggestion;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the validation issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IssueCode. 
        /// <para>
        /// A code that identifies the type of validation issue found.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IssueCode
        {
            get { return this._issueCode; }
            set { this._issueCode = value; }
        }

        // Check to see if IssueCode property is set
        internal bool IsSetIssueCode()
        {
            return this._issueCode != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A list of evaluation form items affected by this finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormValidationFindingItem> Items
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding. Valid values: <c>WARNING</c>, <c>ERROR</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormValidationFindingSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Suggestion. 
        /// <para>
        /// A suggested fix for the validation issue.
        /// </para>
        /// </summary>
        public string Suggestion
        {
            get { return this._suggestion; }
            set { this._suggestion = value; }
        }

        // Check to see if Suggestion property is set
        internal bool IsSetSuggestion()
        {
            return this._suggestion != null;
        }

    }
}