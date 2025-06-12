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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// This is the response object from the BatchGetMembershipDatasources operation.
    /// </summary>
    public partial class BatchGetMembershipDatasourcesResponse : AmazonWebServiceResponse
    {
        private List<MembershipDatasources> _membershipDatasources = AWSConfigs.InitializeCollections ? new List<MembershipDatasources>() : null;
        private List<UnprocessedGraph> _unprocessedGraphs = AWSConfigs.InitializeCollections ? new List<UnprocessedGraph>() : null;

        /// <summary>
        /// Gets and sets the property MembershipDatasources. 
        /// <para>
        /// Details on the data source package history for an member of the behavior graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MembershipDatasources> MembershipDatasources
        {
            get { return this._membershipDatasources; }
            set { this._membershipDatasources = value; }
        }

        // Check to see if MembershipDatasources property is set
        internal bool IsSetMembershipDatasources()
        {
            return this._membershipDatasources != null && (this._membershipDatasources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedGraphs. 
        /// <para>
        /// Graphs that data source package information could not be retrieved for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedGraph> UnprocessedGraphs
        {
            get { return this._unprocessedGraphs; }
            set { this._unprocessedGraphs = value; }
        }

        // Check to see if UnprocessedGraphs property is set
        internal bool IsSetUnprocessedGraphs()
        {
            return this._unprocessedGraphs != null && (this._unprocessedGraphs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}