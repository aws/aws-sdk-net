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
    /// Container for the parameters to the ListContainerGroupDefinitions operation.
    /// <b>This operation is used with the Amazon GameLift containers feature, which is currently
    /// in public preview. </b> 
    /// 
    ///  
    /// <para>
    /// Retrieves all container group definitions for the Amazon Web Services account and
    /// Amazon Web Services Region that are currently in use. You can filter the result set
    /// by the container groups' scheduling strategy. Use the pagination parameters to retrieve
    /// results in a set of sequential pages.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation returns the list of container group definitions in no particular order.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Manage
    /// a container group definition</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListContainerGroupDefinitionsRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private string _nextToken;
        private ContainerSchedulingStrategy _schedulingStrategy;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        [AWSProperty(Min=1)]
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

        /// <summary>
        /// Gets and sets the property SchedulingStrategy. 
        /// <para>
        /// The type of container group definitions to retrieve.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DAEMON</c> -- Daemon container groups run background processes and are deployed
        /// once per fleet instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLICA</c> -- Replica container groups run your game server application and supporting
        /// software. Replica groups might be deployed multiple times per fleet instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerSchedulingStrategy SchedulingStrategy
        {
            get { return this._schedulingStrategy; }
            set { this._schedulingStrategy = value; }
        }

        // Check to see if SchedulingStrategy property is set
        internal bool IsSetSchedulingStrategy()
        {
            return this._schedulingStrategy != null;
        }

    }
}