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

namespace Amazon.CodeConnections.Model
{
    /// <summary>
    /// The definition for a repository with a sync configuration.
    /// </summary>
    public partial class RepositorySyncDefinition
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch specified for a repository sync definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property Directory. 
        /// <para>
        /// The configuration file for a repository sync definition. This value comes from creating
        /// or updating the <c>config-file</c> field of a <c>sync-configuration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Directory { get; set; }

        /// <summary>
        /// Checks to see if the Directory property is set.
        /// </summary>
        internal bool IsSetDirectory() => this.Directory != null;

        /// <summary>
        /// Gets and sets the property Parent. 
        /// <para>
        /// The parent resource specified for a repository sync definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Parent { get; set; }

        /// <summary>
        /// Checks to see if the Parent property is set.
        /// </summary>
        internal bool IsSetParent() => this.Parent != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target resource specified for a repository sync definition. In some cases, such
        /// as CFN_STACK_SYNC, the parent and target resource are the same.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
