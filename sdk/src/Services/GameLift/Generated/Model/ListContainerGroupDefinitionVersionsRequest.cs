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
    /// Container for the parameters to the ListContainerGroupDefinitionVersions operation.
    /// Retrieves all versions of a container group definition. Use the pagination parameters
    /// to retrieve results in a set of sequential pages.
    /// 
    ///  
    /// <para>
    ///  <b>Request options:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Get all versions of a specified container group definition. Specify the container
    /// group definition name or ARN value. (If the ARN value has a version number, it's ignored.)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results:</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns the complete properties of a set of container
    /// group definition versions that match the request.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation returns the list of container group definitions in descending version
    /// order (latest first). 
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
    public partial class ListContainerGroupDefinitionVersionsRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private string _name;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier for the container group definition to retrieve properties for.
        /// You can use either the <c>Name</c> or <c>ARN</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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