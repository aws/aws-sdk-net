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
    /// Represents an SLA configuration.
    /// </summary>
    public partial class SlaConfiguration
    {
        private DateTime? _completionTime;
        private string _fieldId;
        private string _name;
        private SlaStatus _status;
        private List<FieldValueUnion> _targetFieldValues = AWSConfigs.InitializeCollections ? new List<FieldValueUnion>() : null;
        private DateTime? _targetTime;
        private SlaType _type;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Time at which an SLA was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// Unique identifier of a field.
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
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=500)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of an SLA.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlaStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetFieldValues. 
        /// <para>
        /// Represents a list of target field values for the fieldId specified in SlaConfiguration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property TargetTime. 
        /// <para>
        /// Target time by which an SLA should be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? TargetTime
        {
            get { return this._targetTime; }
            set { this._targetTime = value; }
        }

        // Check to see if TargetTime property is set
        internal bool IsSetTargetTime()
        {
            return this._targetTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of SLA.
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