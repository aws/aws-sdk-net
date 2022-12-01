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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ListAliases operation.
    /// Retrieves all aliases for this Amazon Web Services account. You can filter the result
    /// set by alias name and/or routing strategy type. Use the pagination parameters to retrieve
    /// results in sequential pages.
    /// 
    ///  <note> 
    /// <para>
    /// Returned aliases are not listed in any particular order.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class ListAliasesRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private string _name;
        private string _nextToken;
        private RoutingStrategyType _routingStrategyType;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with an alias. Alias names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// Gets and sets the property RoutingStrategyType. 
        /// <para>
        /// The routing type to filter results on. Use this parameter to retrieve only aliases
        /// with a certain routing type. To retrieve all aliases, leave this parameter empty.
        /// </para>
        ///  
        /// <para>
        /// Possible routing types include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SIMPLE</b> -- The alias resolves to one specific fleet. Use this type when routing
        /// to active fleets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TERMINAL</b> -- The alias does not resolve to a fleet but instead can be used
        /// to display a message to the user. A terminal alias throws a TerminalRoutingStrategyException
        /// with the <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_RoutingStrategy.html">RoutingStrategy</a>
        /// message embedded.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RoutingStrategyType RoutingStrategyType
        {
            get { return this._routingStrategyType; }
            set { this._routingStrategyType = value; }
        }

        // Check to see if RoutingStrategyType property is set
        internal bool IsSetRoutingStrategyType()
        {
            return this._routingStrategyType != null;
        }

    }
}