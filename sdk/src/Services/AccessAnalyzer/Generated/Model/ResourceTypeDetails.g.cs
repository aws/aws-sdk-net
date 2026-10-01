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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the total number of active cross-account and public findings
    /// for a resource type of an external access analyzer.
    /// </summary>
    public partial class ResourceTypeDetails
    {
        /// <summary>
        /// Gets and sets the property TotalActiveCrossAccount. 
        /// <para>
        /// The total number of active cross-account findings for the resource type.
        /// </para>
        /// </summary>
        public int? TotalActiveCrossAccount { get; set; }

        /// <summary>
        /// Checks to see if the TotalActiveCrossAccount property is set.
        /// </summary>
        internal bool IsSetTotalActiveCrossAccount() => this.TotalActiveCrossAccount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalActiveErrors. 
        /// <para>
        /// The total number of active errors for the resource type.
        /// </para>
        /// </summary>
        public int? TotalActiveErrors { get; set; }

        /// <summary>
        /// Checks to see if the TotalActiveErrors property is set.
        /// </summary>
        internal bool IsSetTotalActiveErrors() => this.TotalActiveErrors.HasValue;

        /// <summary>
        /// Gets and sets the property TotalActivePublic. 
        /// <para>
        /// The total number of active public findings for the resource type.
        /// </para>
        /// </summary>
        public int? TotalActivePublic { get; set; }

        /// <summary>
        /// Checks to see if the TotalActivePublic property is set.
        /// </summary>
        internal bool IsSetTotalActivePublic() => this.TotalActivePublic.HasValue;
    }
}
