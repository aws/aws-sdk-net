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
    /// Fields for audit event.
    /// </summary>
    public partial class AuditEventField
    {
        /// <summary>
        /// Gets and sets the property EventFieldId. 
        /// <para>
        /// Unique identifier of field in an Audit History entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EventFieldId { get; set; }

        /// <summary>
        /// Checks to see if the EventFieldId property is set.
        /// </summary>
        internal bool IsSetEventFieldId() => this.EventFieldId != null;

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// Union of potential field value types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuditEventFieldValueUnion NewValue { get; set; }

        /// <summary>
        /// Checks to see if the NewValue property is set.
        /// </summary>
        internal bool IsSetNewValue() => this.NewValue != null;

        /// <summary>
        /// Gets and sets the property OldValue. 
        /// <para>
        /// Union of potential field value types.
        /// </para>
        /// </summary>
        public AuditEventFieldValueUnion OldValue { get; set; }

        /// <summary>
        /// Checks to see if the OldValue property is set.
        /// </summary>
        internal bool IsSetOldValue() => this.OldValue != null;
    }
}
