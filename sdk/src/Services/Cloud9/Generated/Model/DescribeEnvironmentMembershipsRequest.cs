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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
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
namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEnvironmentMemberships operation.
    /// Gets information about environment members for an Cloud9 development environment.
    /// 
    ///  <important> 
    /// <para>
    /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
    /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
    /// more"</a> 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DescribeEnvironmentMembershipsRequest : AmazonCloud9Request
    {
        private string _environmentId;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to get environment member information about.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of environment members to get information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// During a previous call, if there are more than 25 items in the list, only the first
        /// 25 items are returned, along with a unique string called a <i>next token</i>. To get
        /// the next batch of items in the list, call this operation again, adding the next token
        /// to the call. To get all of the items in the list, keep calling this operation with
        /// each subsequent next token that is returned, until no more next tokens are returned.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The type of environment member permissions to get information about. Available values
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>owner</c>: Owns the environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>read-only</c>: Has read-only access to the environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>read-write</c>: Has read-write access to the environment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If no value is specified, information about all environment members are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an individual environment member to get information
        /// about. If no value is specified, information about all environment members are returned.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}