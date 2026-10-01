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
    /// Represents the input configuration of an SLA being created.
    /// </summary>
    public partial class SlaInputConfiguration
    {
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
        /// Gets and sets the property TargetFieldValues. 
        /// <para>
        /// Represents a list of target field values for the fieldId specified in SlaInputConfiguration.
        /// The SLA is considered met if any one of these target field values matches the actual
        /// field value.
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
        /// Gets and sets the property TargetSlaMinutes. 
        /// <para>
        /// Target duration in minutes within which an SLA should be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1051200)]
        public long? TargetSlaMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TargetSlaMinutes property is set.
        /// </summary>
        internal bool IsSetTargetSlaMinutes() => this.TargetSlaMinutes.HasValue;

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
