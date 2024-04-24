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
    /// Fields for audit event.
    /// </summary>
    public partial class AuditEventField
    {
        private string _eventFieldId;
        private AuditEventFieldValueUnion _newValue;
        private AuditEventFieldValueUnion _oldValue;

        /// <summary>
        /// Gets and sets the property EventFieldId. 
        /// <para>
        /// Unique identifier of field in an Audit History entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EventFieldId
        {
            get { return this._eventFieldId; }
            set { this._eventFieldId = value; }
        }

        // Check to see if EventFieldId property is set
        internal bool IsSetEventFieldId()
        {
            return this._eventFieldId != null;
        }

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// Union of potential field value types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuditEventFieldValueUnion NewValue
        {
            get { return this._newValue; }
            set { this._newValue = value; }
        }

        // Check to see if NewValue property is set
        internal bool IsSetNewValue()
        {
            return this._newValue != null;
        }

        /// <summary>
        /// Gets and sets the property OldValue. 
        /// <para>
        /// Union of potential field value types.
        /// </para>
        /// </summary>
        public AuditEventFieldValueUnion OldValue
        {
            get { return this._oldValue; }
            set { this._oldValue = value; }
        }

        // Check to see if OldValue property is set
        internal bool IsSetOldValue()
        {
            return this._oldValue != null;
        }

    }
}