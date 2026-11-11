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
    /// Container for the parameters to the ListActionTypes operation. Gets a summary of all
    /// CodePipeline action types associated with your account.
    /// </summary>
    public partial class ListActionTypesRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property ActionOwnerFilter. 
        /// <para>
        /// Filters the list of action types to those created by a specified entity.
        /// </para>
        /// </summary>
        public ActionOwner ActionOwnerFilter { get; set; }

        /// <summary>
        /// Checks to see if the ActionOwnerFilter property is set.
        /// </summary>
        internal bool IsSetActionOwnerFilter() => this.ActionOwnerFilter != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous list action types call, which can
        /// be used to return the next set of action types in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegionFilter. 
        /// <para>
        /// The Region to filter on for the list of action types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 30)]
        public string RegionFilter { get; set; }

        /// <summary>
        /// Checks to see if the RegionFilter property is set.
        /// </summary>
        internal bool IsSetRegionFilter() => this.RegionFilter != null;
    }
}
