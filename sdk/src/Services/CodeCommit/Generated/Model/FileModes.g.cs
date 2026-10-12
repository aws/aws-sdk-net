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
    /// Information about file modes in a merge or pull request.
    /// </summary>
    public partial class FileModes
    {
        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The file mode of a file in the base of a merge or pull request.
        /// </para>
        /// </summary>
        public FileModeTypeEnum Base { get; set; }

        /// <summary>
        /// Checks to see if the Base property is set.
        /// </summary>
        internal bool IsSetBase() => this.Base != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The file mode of a file in the destination of a merge or pull request.
        /// </para>
        /// </summary>
        public FileModeTypeEnum Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The file mode of a file in the source of a merge or pull request.
        /// </para>
        /// </summary>
        public FileModeTypeEnum Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
