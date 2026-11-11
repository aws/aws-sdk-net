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
    /// Represents information about the state of an action.
    /// </summary>
    public partial class ActionState
    {
        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property CurrentRevision. 
        /// <para>
        /// Represents information about the version (or revision) of an action.
        /// </para>
        /// </summary>
        public ActionRevision CurrentRevision { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRevision property is set.
        /// </summary>
        internal bool IsSetCurrentRevision() => this.CurrentRevision != null;

        /// <summary>
        /// Gets and sets the property EntityUrl. 
        /// <para>
        /// A URL link for more information about the state of the action, such as a deployment
        /// group details page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EntityUrl { get; set; }

        /// <summary>
        /// Checks to see if the EntityUrl property is set.
        /// </summary>
        internal bool IsSetEntityUrl() => this.EntityUrl != null;

        /// <summary>
        /// Gets and sets the property LatestExecution. 
        /// <para>
        /// Represents information about the run of an action.
        /// </para>
        /// </summary>
        public ActionExecution LatestExecution { get; set; }

        /// <summary>
        /// Checks to see if the LatestExecution property is set.
        /// </summary>
        internal bool IsSetLatestExecution() => this.LatestExecution != null;

        /// <summary>
        /// Gets and sets the property RevisionUrl. 
        /// <para>
        /// A URL link for more information about the revision, such as a commit details page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RevisionUrl { get; set; }

        /// <summary>
        /// Checks to see if the RevisionUrl property is set.
        /// </summary>
        internal bool IsSetRevisionUrl() => this.RevisionUrl != null;
    }
}
