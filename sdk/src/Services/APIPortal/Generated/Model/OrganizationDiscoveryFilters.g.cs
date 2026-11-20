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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Limits organization-scoped discovery. Set exactly one member: `inclusionFilters` to
    /// discover only the matching targets, or `exclusionFilters` to discover everything except
    /// them.
    /// </summary>
    public partial class OrganizationDiscoveryFilters
    {
        /// <summary>
        /// Gets and sets the property ExclusionFilters.
        /// </summary>
        public DiscoveryExclusionFilters ExclusionFilters { get; set; }

        /// <summary>
        /// Checks to see if the ExclusionFilters property is set.
        /// </summary>
        internal bool IsSetExclusionFilters() => this.ExclusionFilters != null;

        /// <summary>
        /// Gets and sets the property InclusionFilters.
        /// </summary>
        public DiscoveryInclusionFilters InclusionFilters { get; set; }

        /// <summary>
        /// Checks to see if the InclusionFilters property is set.
        /// </summary>
        internal bool IsSetInclusionFilters() => this.InclusionFilters != null;
    }
}
