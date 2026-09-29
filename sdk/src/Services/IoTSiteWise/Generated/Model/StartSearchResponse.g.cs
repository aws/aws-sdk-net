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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the StartSearch operation.
    /// </summary>
    public partial class StartSearchResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The group identifier associated with the search, if one was supplied on the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 36)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The unique identifier assigned to the newly started search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 23, Max = 36)]
        public string SearchId { get; set; }

        /// <summary>
        /// Checks to see if the SearchId property is set.
        /// </summary>
        internal bool IsSetSearchId() => this.SearchId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The initial status of the search. A newly started search is <c>QUEUED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search runs against.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
