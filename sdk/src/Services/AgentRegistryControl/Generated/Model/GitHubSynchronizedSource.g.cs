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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// A GitHub source that a skill record's content was synchronized from, and the commit
    /// that the registry read.
    /// </summary>
    public partial class GitHubSynchronizedSource
    {
        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The commit that the source's branch or tag pointed to when the registry read it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 40, Max = 64)]
        public string CommitId { get; set; }

        /// <summary>
        /// Checks to see if the CommitId property is set.
        /// </summary>
        internal bool IsSetCommitId() => this.CommitId != null;

        /// <summary>
        /// Gets and sets the property SynchronizedAt. 
        /// <para>
        /// The timestamp when the registry read the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SynchronizedAt { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizedAt property is set.
        /// </summary>
        internal bool IsSetSynchronizedAt() => this.SynchronizedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The source URL that the registry read.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
