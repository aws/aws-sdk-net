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
    /// A data table value summary.
    /// </summary>
    public partial class DataTableValueSummary
    {
        private string _attributeId;
        private string _attributeName;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private DataTableLockVersion _lockVersion;
        private List<PrimaryValueResponse> _primaryValues = AWSConfigs.InitializeCollections ? new List<PrimaryValueResponse>() : null;
        private string _recordId;
        private string _value;
        private DataTableAttributeValueType _valueType;

        /// <summary>
        /// Gets and sets the property AttributeId. 
        /// <para>
        /// The summary's attribute ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AttributeId
        {
            get { return this._attributeId; }
            set { this._attributeId = value; }
        }

        // Check to see if AttributeId property is set
        internal bool IsSetAttributeId()
        {
            return this._attributeId != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The summary's attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The summary's last modified region.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The summary's last modified time.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The summary's lock version.
        /// </para>
        /// </summary>
        public DataTableLockVersion LockVersion
        {
            get { return this._lockVersion; }
            set { this._lockVersion = value; }
        }

        // Check to see if LockVersion property is set
        internal bool IsSetLockVersion()
        {
            return this._lockVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The summary's primary values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PrimaryValueResponse> PrimaryValues
        {
            get { return this._primaryValues; }
            set { this._primaryValues = value; }
        }

        // Check to see if PrimaryValues property is set
        internal bool IsSetPrimaryValues()
        {
            return this._primaryValues != null && (this._primaryValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The summary's record ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The summary's value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The summary's value type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataTableAttributeValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

    }
}