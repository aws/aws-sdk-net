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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contact data associated with quick connect operations.
    /// </summary>
    public partial class QuickConnectContactData
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        ///  The contact ID for quick connect contact data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property InitiationTimestamp. 
        /// <para>
        ///  Timestamp when the quick connect contact was initiated. 
        /// </para>
        /// </summary>
        public DateTime? InitiationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the InitiationTimestamp property is set.
        /// </summary>
        internal bool IsSetInitiationTimestamp() => this.InitiationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property QuickConnectId. 
        /// <para>
        ///  The quick connect ID. 
        /// </para>
        /// </summary>
        public string QuickConnectId { get; set; }

        /// <summary>
        /// Checks to see if the QuickConnectId property is set.
        /// </summary>
        internal bool IsSetQuickConnectId() => this.QuickConnectId != null;

        /// <summary>
        /// Gets and sets the property QuickConnectName. 
        /// <para>
        ///  The name of the quick connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string QuickConnectName { get; set; }

        /// <summary>
        /// Checks to see if the QuickConnectName property is set.
        /// </summary>
        internal bool IsSetQuickConnectName() => this.QuickConnectName != null;

        /// <summary>
        /// Gets and sets the property QuickConnectType. 
        /// <para>
        ///  The type of the quick connect. 
        /// </para>
        /// </summary>
        public QuickConnectType QuickConnectType { get; set; }

        /// <summary>
        /// Checks to see if the QuickConnectType property is set.
        /// </summary>
        internal bool IsSetQuickConnectType() => this.QuickConnectType != null;
    }
}
