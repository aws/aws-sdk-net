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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// Represents an action performed on a submission.
    /// </summary>
    public partial class SubmissionMutation
    {
        /// <summary>
        /// Gets and sets the property MutationType. 
        /// <para>
        /// The operation that is performed on a submission.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubmissionMutationKind MutationType { get; set; }

        /// <summary>
        /// Checks to see if the MutationType property is set.
        /// </summary>
        internal bool IsSetMutationType() => this.MutationType != null;

        /// <summary>
        /// Gets and sets the property SubmissionId. 
        /// <para>
        /// The unique identifier of the submission.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubmissionId { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionId property is set.
        /// </summary>
        internal bool IsSetSubmissionId() => this.SubmissionId != null;
    }
}
