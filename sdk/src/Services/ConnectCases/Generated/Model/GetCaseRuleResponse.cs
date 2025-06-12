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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
    /// Detailed case rule information. In the Amazon Connect admin website, case rules are
    /// known as <i>case field conditions</i>. For more information about case field conditions,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class GetCaseRuleResponse
    {
        private string _caseRuleArn;
        private string _caseRuleId;
        private DateTime? _createdTime;
        private bool? _deleted;
        private string _description;
        private DateTime? _lastModifiedTime;
        private string _name;
        private CaseRuleDetails _rule;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CaseRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string CaseRuleArn
        {
            get { return this._caseRuleArn; }
            set { this._caseRuleArn = value; }
        }

        // Check to see if CaseRuleArn property is set
        internal bool IsSetCaseRuleArn()
        {
            return this._caseRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CaseRuleId. 
        /// <para>
        /// Unique identifier of a case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string CaseRuleId
        {
            get { return this._caseRuleId; }
            set { this._caseRuleId = value; }
        }

        // Check to see if CaseRuleId property is set
        internal bool IsSetCaseRuleId()
        {
            return this._caseRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Timestamp when the resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Indicates whether the resource has been deleted.
        /// </para>
        /// </summary>
        public bool? Deleted
        {
            get { return this._deleted; }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of a case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Timestamp when the resource was created or last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// Represents what rule type should take place, under what conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CaseRuleDetails Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of of key-value pairs that represent tags on a resource. Tags are used to organize,
        /// track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

    }
}