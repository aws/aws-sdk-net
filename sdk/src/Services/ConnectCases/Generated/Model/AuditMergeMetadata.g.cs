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
    /// Information about the merge that produced an audit event.
    /// </summary>
    public partial class AuditMergeMetadata
    {
        /// <summary>
        /// Gets and sets the property MergeEventId. 
        /// <para>
        /// The unique identifier of the merge. All audit events produced by the same merge, on
        /// both cases, have the same value. Use it to group the changes that a merge made.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string MergeEventId { get; set; }

        /// <summary>
        /// Checks to see if the MergeEventId property is set.
        /// </summary>
        internal bool IsSetMergeEventId() => this.MergeEventId != null;

        /// <summary>
        /// Gets and sets the property PrimaryCaseId. 
        /// <para>
        /// The unique identifier of the primary case of the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string PrimaryCaseId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryCaseId property is set.
        /// </summary>
        internal bool IsSetPrimaryCaseId() => this.PrimaryCaseId != null;

        /// <summary>
        /// Gets and sets the property SecondaryCaseId. 
        /// <para>
        /// The unique identifier of the secondary case of the merge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string SecondaryCaseId { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryCaseId property is set.
        /// </summary>
        internal bool IsSetSecondaryCaseId() => this.SecondaryCaseId != null;
    }
}
