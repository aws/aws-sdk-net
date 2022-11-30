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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The criteria used to filter data quality rulesets.
    /// </summary>
    public partial class DataQualityRulesetFilterCriteria
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _description;
        private DateTime? _lastModifiedAfter;
        private DateTime? _lastModifiedBefore;
        private string _name;
        private DataQualityTargetTable _targetTable;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filter on rulesets created after this date.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Filter on rulesets created before this date.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ruleset filter criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LastModifiedAfter. 
        /// <para>
        /// Filter on rulesets last modified after this date.
        /// </para>
        /// </summary>
        public DateTime LastModifiedAfter
        {
            get { return this._lastModifiedAfter.GetValueOrDefault(); }
            set { this._lastModifiedAfter = value; }
        }

        // Check to see if LastModifiedAfter property is set
        internal bool IsSetLastModifiedAfter()
        {
            return this._lastModifiedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBefore. 
        /// <para>
        /// Filter on rulesets last modified before this date.
        /// </para>
        /// </summary>
        public DateTime LastModifiedBefore
        {
            get { return this._lastModifiedBefore.GetValueOrDefault(); }
            set { this._lastModifiedBefore = value; }
        }

        // Check to see if LastModifiedBefore property is set
        internal bool IsSetLastModifiedBefore()
        {
            return this._lastModifiedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ruleset filter criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// The name and database name of the target table.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable
        {
            get { return this._targetTable; }
            set { this._targetTable = value; }
        }

        // Check to see if TargetTable property is set
        internal bool IsSetTargetTable()
        {
            return this._targetTable != null;
        }

    }
}