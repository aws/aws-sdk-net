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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A run identifier.
    /// </summary>
    public partial class RunIdentifier
    {
        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The Job Run ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Checks to see if the JobRunId property is set.
        /// </summary>
        internal bool IsSetJobRunId() => this.JobRunId != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The Run ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;
    }
}
