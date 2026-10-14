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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a target for a pull request.
    /// </summary>
    public partial class Target
    {
        /// <summary>
        /// Gets and sets the property DestinationReference. 
        /// <para>
        /// The branch of the repository where the pull request changes are merged. Also known
        /// as the destination branch.
        /// </para>
        /// </summary>
        public string DestinationReference { get; set; }

        /// <summary>
        /// Checks to see if the DestinationReference property is set.
        /// </summary>
        internal bool IsSetDestinationReference() => this.DestinationReference != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the pull request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SourceReference. 
        /// <para>
        /// The branch of the repository that contains the changes for the pull request. Also
        /// known as the source branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceReference { get; set; }

        /// <summary>
        /// Checks to see if the SourceReference property is set.
        /// </summary>
        internal bool IsSetSourceReference() => this.SourceReference != null;
    }
}
