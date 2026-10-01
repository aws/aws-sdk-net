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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents an SLA configuration.
    /// </summary>
    public partial class SlaConfiguration
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Time at which an SLA was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// Unique identifier of a field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of an SLA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of an SLA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlaStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetFieldValues. 
        /// <para>
        /// Represents a list of target field values for the fieldId specified in SlaConfiguration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<FieldValueUnion> TargetFieldValues { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldValueUnion>() : null;

        /// <summary>
        /// Checks to see if the TargetFieldValues property is set.
        /// </summary>
        internal bool IsSetTargetFieldValues() => this.TargetFieldValues != null && (this.TargetFieldValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetTime. 
        /// <para>
        /// Target time by which an SLA should be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? TargetTime { get; set; }

        /// <summary>
        /// Checks to see if the TargetTime property is set.
        /// </summary>
        internal bool IsSetTargetTime() => this.TargetTime.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of SLA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlaType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
