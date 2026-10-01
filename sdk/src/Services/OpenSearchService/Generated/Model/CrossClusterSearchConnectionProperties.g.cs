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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Cross-cluster search specific connection properties.
    /// </summary>
    public partial class CrossClusterSearchConnectionProperties
    {
        /// <summary>
        /// Gets and sets the property SkipUnavailable. 
        /// <para>
        /// The status of the <c>SkipUnavailable</c> setting for the outbound connection. This
        /// feature allows you to specify some clusters as optional and ensure that your cross-cluster
        /// queries return partial results despite failures on one or more remote clusters.
        /// </para>
        /// </summary>
        public SkipUnavailableStatus SkipUnavailable { get; set; }

        /// <summary>
        /// Checks to see if the SkipUnavailable property is set.
        /// </summary>
        internal bool IsSetSkipUnavailable() => this.SkipUnavailable != null;
    }
}
