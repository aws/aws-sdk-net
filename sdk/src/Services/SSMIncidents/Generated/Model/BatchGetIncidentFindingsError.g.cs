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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about an error returned for a <a>BatchGetIncidentFindings</a> operation.
    /// </summary>
    public partial class BatchGetIncidentFindingsError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code associated with an error that was returned for a <c>BatchGetIncidentFindings</c>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The ID of a specified finding for which an error was returned for a <c>BatchGetIncidentFindings</c>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The description for an error that was returned for a <c>BatchGetIncidentFindings</c>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
