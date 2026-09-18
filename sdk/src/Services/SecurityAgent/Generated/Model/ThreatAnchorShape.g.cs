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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// DFD element that a threat is anchored to.
    /// </summary>
    public partial class ThreatAnchorShape
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the DFD element.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The kind of DFD element.
        /// </para>
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// Checks to see if the Kind property is set.
        /// </summary>
        internal bool IsSetKind() => this.Kind != null;

        /// <summary>
        /// Gets and sets the property PackageId. 
        /// <para>
        /// The package identifier containing the DFD element.
        /// </para>
        /// </summary>
        public string PackageId { get; set; }

        /// <summary>
        /// Checks to see if the PackageId property is set.
        /// </summary>
        internal bool IsSetPackageId() => this.PackageId != null;
    }
}
