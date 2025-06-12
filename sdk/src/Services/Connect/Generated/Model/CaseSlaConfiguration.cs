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
    /// The SLA configuration for Case SlaAssignmentType.
    /// </summary>
    public partial class CaseSlaConfiguration
    {
        private string _fieldId;
        private string _name;
        private List<FieldValueUnion> _targetFieldValues = AWSConfigs.InitializeCollections ? new List<FieldValueUnion>() : null;
        private long? _targetSlaMinutes;
        private SlaType _type;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// Unique identifier of a Case field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of an SLA.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
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
        /// Gets and sets the property TargetFieldValues. 
        /// <para>
        /// Represents a list of target field values for the fieldId specified in CaseSlaConfiguration.
        /// The SLA is considered met if any one of these target field values matches the actual
        /// field value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<FieldValueUnion> TargetFieldValues
        {
            get { return this._targetFieldValues; }
            set { this._targetFieldValues = value; }
        }

        // Check to see if TargetFieldValues property is set
        internal bool IsSetTargetFieldValues()
        {
            return this._targetFieldValues != null && (this._targetFieldValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetSlaMinutes. 
        /// <para>
        /// Target duration in minutes within which an SLA should be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=129600)]
        public long? TargetSlaMinutes
        {
            get { return this._targetSlaMinutes; }
            set { this._targetSlaMinutes = value; }
        }

        // Check to see if TargetSlaMinutes property is set
        internal bool IsSetTargetSlaMinutes()
        {
            return this._targetSlaMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of SLA for Case SlaAssignmentType.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlaType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}