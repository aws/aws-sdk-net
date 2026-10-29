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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListStudioSessionMappings operation. Returns a
    /// list of all user or group session mappings for the Amazon EMR Studio specified by
    /// <c>StudioId</c>.
    /// </summary>
    public partial class ListStudioSessionMappingsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// Specifies whether to return session mappings for users or groups. If not specified,
        /// the results include session mapping details for both users and groups.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StudioId { get; set; }

        /// <summary>
        /// Checks to see if the StudioId property is set.
        /// </summary>
        internal bool IsSetStudioId() => this.StudioId != null;
    }
}
