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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Contains metadata about the ruleset.
    /// </summary>
    public partial class RulesetItem
    {
        private string _accountId;
        private DateTime? _createDate;
        private string _createdBy;
        private string _description;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedDate;
        private string _name;
        private string _resourceArn;
        private int? _ruleCount;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the ruleset was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the ruleset.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last modified the ruleset.
        /// </para>
        /// </summary>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The modification date and time of the ruleset.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleCount. 
        /// <para>
        /// The number of rules that are defined in the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int RuleCount
        {
            get { return this._ruleCount.GetValueOrDefault(); }
            set { this._ruleCount = value; }
        }

        // Check to see if RuleCount property is set
        internal bool IsSetRuleCount()
        {
            return this._ruleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags that have been applied to the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a resource (dataset) that the ruleset is associated
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}