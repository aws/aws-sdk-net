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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The failures in a dataset generation that share an error code.
    /// </summary>
    public partial class GenerationErrorDetail
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of sessions and traces that failed with this error code. Absent for a generation
        /// that finished before failures were counted by code. In that case, <c>sessionIds</c>
        /// is a sample.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code, for example <c>ACCESS_DENIED</c> or <c>EXPIRED_CREDENTIALS</c>. New
        /// codes can be added.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A description of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property SessionIds. 
        /// <para>
        /// Up to 10 of the sessions that failed with this error code. Each entry is a session
        /// ID, or the ID of a trace named in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> SessionIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SessionIds property is set.
        /// </summary>
        internal bool IsSetSessionIds() => this.SessionIds != null && (this.SessionIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
