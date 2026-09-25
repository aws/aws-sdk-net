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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A specification about how data from the configured table can be used in a query.
    /// </summary>
    public partial class AnalysisRule
    {
        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique ID for the associated collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property CollaborationPolicy.
        /// </summary>
        public ConfiguredTableAssociationAnalysisRulePolicy CollaborationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationPolicy property is set.
        /// </summary>
        internal bool IsSetCollaborationPolicy() => this.CollaborationPolicy != null;

        /// <summary>
        /// Gets and sets the property ConsolidatedPolicy. 
        /// <para>
        ///  The consolidated policy for the analysis rule.
        /// </para>
        /// </summary>
        public ConsolidatedPolicy ConsolidatedPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ConsolidatedPolicy property is set.
        /// </summary>
        internal bool IsSetConsolidatedPolicy() => this.ConsolidatedPolicy != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the analysis rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A policy that describes the associated data usage limitations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisRulePolicy Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisRuleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the analysis rule was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
