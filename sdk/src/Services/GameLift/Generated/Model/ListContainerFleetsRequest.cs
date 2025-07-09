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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ListContainerFleets operation.
    /// Retrieves a collection of container fleet resources in an Amazon Web Services Region.
    /// For fleets that have multiple locations, this operation retrieves fleets based on
    /// their home Region only.
    /// 
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Get a list of all fleets. Call this operation without specifying a container group
    /// definition. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Get a list of fleets filtered by container group definition. Provide the container
    /// group definition name or ARN value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get a list of all Amazon GameLift Servers Realtime fleets with a specific configuration
    /// script, provide the script ID. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use the pagination parameters to retrieve results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns a collection of container fleets that match
    /// the request parameters. A NextToken value is also returned if there are more result
    /// pages to retrieve.
    /// </para>
    ///  <note> 
    /// <para>
    /// Fleet IDs are returned in no particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListContainerFleetsRequest : AmazonGameLiftRequest
    {
        private string _containerGroupDefinitionName;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ContainerGroupDefinitionName. 
        /// <para>
        /// The container group definition to filter the list on. Use this parameter to retrieve
        /// only those fleets that use the specified container group definition. You can specify
        /// the container group definition's name to get fleets with the latest versions. Alternatively,
        /// provide an ARN value to get fleets with a specific version number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ContainerGroupDefinitionName
        {
            get { return this._containerGroupDefinitionName; }
            set { this._containerGroupDefinitionName = value; }
        }

        // Check to see if ContainerGroupDefinitionName property is set
        internal bool IsSetContainerGroupDefinitionName()
        {
            return this._containerGroupDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}