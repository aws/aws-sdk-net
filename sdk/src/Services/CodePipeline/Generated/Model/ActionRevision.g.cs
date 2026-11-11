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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the version (or revision) of an action.
    /// </summary>
    public partial class ActionRevision
    {
        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time when the most recent version of the action was created, in timestamp
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property RevisionChangeId. 
        /// <para>
        /// The unique identifier of the change that set the state to this revision (for example,
        /// a deployment ID or timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RevisionChangeId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionChangeId property is set.
        /// </summary>
        internal bool IsSetRevisionChangeId() => this.RevisionChangeId != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The system-generated unique ID that identifies the revision number of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1500)]
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;
    }
}
