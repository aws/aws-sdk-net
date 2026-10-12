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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// A repository sync definition.
    /// </summary>
    public partial class RepositorySyncDefinition
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The repository branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property Directory. 
        /// <para>
        /// The directory in the repository.
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
        /// The resource that is synced from.
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
        /// The resource that is synced to.
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
