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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The criteria used to filter data quality rulesets.
    /// </summary>
    public partial class DataQualityRulesetFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filter on rulesets created after this date.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Filter on rulesets created before this date.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ruleset filter criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAfter. 
        /// <para>
        /// Filter on rulesets last modified after this date.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAfter { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAfter property is set.
        /// </summary>
        internal bool IsSetLastModifiedAfter() => this.LastModifiedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBefore. 
        /// <para>
        /// Filter on rulesets last modified before this date.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedBefore { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBefore property is set.
        /// </summary>
        internal bool IsSetLastModifiedBefore() => this.LastModifiedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ruleset filter criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// The name and database name of the target table.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable { get; set; }

        /// <summary>
        /// Checks to see if the TargetTable property is set.
        /// </summary>
        internal bool IsSetTargetTable() => this.TargetTable != null;
    }
}
