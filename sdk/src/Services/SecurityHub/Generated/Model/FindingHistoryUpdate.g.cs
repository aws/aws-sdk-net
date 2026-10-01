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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An array of objects that provides details about a change to a finding, including
    /// the Amazon Web Services Security Finding Format (ASFF) field that changed, the value
    /// of the field before the change, and the value of the field after the change.
    /// </summary>
    public partial class FindingHistoryUpdate
    {
        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        ///  The value of the ASFF field after the finding change event. To preserve storage and
        /// readability, Security Hub CSPM omits this value if <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_FindingHistoryRecord.html">
        /// <c>FindingHistoryRecord</c> </a> exceeds database limits. 
        /// </para>
        /// </summary>
        public string NewValue { get; set; }

        /// <summary>
        /// Checks to see if the NewValue property is set.
        /// </summary>
        internal bool IsSetNewValue() => this.NewValue != null;

        /// <summary>
        /// Gets and sets the property OldValue. 
        /// <para>
        ///  The value of the ASFF field before the finding change event. 
        /// </para>
        /// </summary>
        public string OldValue { get; set; }

        /// <summary>
        /// Checks to see if the OldValue property is set.
        /// </summary>
        internal bool IsSetOldValue() => this.OldValue != null;

        /// <summary>
        /// Gets and sets the property UpdatedField. 
        /// <para>
        ///  The ASFF field that changed during the finding change event. 
        /// </para>
        /// </summary>
        public string UpdatedField { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedField property is set.
        /// </summary>
        internal bool IsSetUpdatedField() => this.UpdatedField != null;
    }
}
