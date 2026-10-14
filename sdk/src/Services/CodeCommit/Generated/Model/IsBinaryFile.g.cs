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
    /// Information about whether a file is binary or textual in a merge or pull request operation.
    /// </summary>
    public partial class IsBinaryFile
    {
        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The binary or non-binary status of a file in the base of a merge or pull request.
        /// </para>
        /// </summary>
        public bool? Base { get; set; }

        /// <summary>
        /// Checks to see if the Base property is set.
        /// </summary>
        internal bool IsSetBase() => this.Base.HasValue;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The binary or non-binary status of a file in the destination of a merge or pull request.
        /// </para>
        /// </summary>
        public bool? Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The binary or non-binary status of file in the source of a merge or pull request.
        /// </para>
        /// </summary>
        public bool? Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source.HasValue;
    }
}
