/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the PutSlotType operation.
    /// </summary>
    public partial class PutSlotTypeResponse : AmazonWebServiceResponse
    {
        private string _checksum;
        private DateTime? _createdDate;
        private bool? _createVersion;
        private string _description;
        private List<EnumerationValue> _enumerationValues = new List<EnumerationValue>();
        private DateTime? _lastUpdatedDate;
        private string _name;
        private SlotValueSelectionStrategy _valueSelectionStrategy;
        private string _version;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum of the <code>$LATEST</code> version of the slot type.
        /// </para>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the slot type was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateVersion.
        /// </summary>
        public bool CreateVersion
        {
            get { return this._createVersion.GetValueOrDefault(); }
            set { this._createVersion = value; }
        }

        // Check to see if CreateVersion property is set
        internal bool IsSetCreateVersion()
        {
            return this._createVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the slot type.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EnumerationValues. 
        /// <para>
        /// A list of <code>EnumerationValue</code> objects that defines the values that the slot
        /// type can take.
        /// </para>
        /// </summary>
        public List<EnumerationValue> EnumerationValues
        {
            get { return this._enumerationValues; }
            set { this._enumerationValues = value; }
        }

        // Check to see if EnumerationValues property is set
        internal bool IsSetEnumerationValues()
        {
            return this._enumerationValues != null && this._enumerationValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date that the slot type was updated. When you create a slot type, the creation
        /// date and last update date are the same.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ValueSelectionStrategy. 
        /// <para>
        /// The slot resolution strategy that Amazon Lex uses to determine the value of the slot.
        /// For more information, see <a>PutSlotType</a>.
        /// </para>
        /// </summary>
        public SlotValueSelectionStrategy ValueSelectionStrategy
        {
            get { return this._valueSelectionStrategy; }
            set { this._valueSelectionStrategy = value; }
        }

        // Check to see if ValueSelectionStrategy property is set
        internal bool IsSetValueSelectionStrategy()
        {
            return this._valueSelectionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the slot type. For a new slot type, the version is always <code>$LATEST</code>.
        /// 
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}