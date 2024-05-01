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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListSecurityProfilesForTarget operation.
    /// Lists the Device Defender security profiles attached to a target (thing group).
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSecurityProfilesForTarget</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListSecurityProfilesForTargetRequest : AmazonIoTRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private bool? _recursive;
        private string _securityProfileTargetArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// The token for the next set of results.
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
        /// Gets and sets the property Recursive. 
        /// <para>
        /// If true, return child groups too.
        /// </para>
        /// </summary>
        public bool? Recursive
        {
            get { return this._recursive; }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileTargetArn. 
        /// <para>
        /// The ARN of the target (thing group) whose attached security profiles you want to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityProfileTargetArn
        {
            get { return this._securityProfileTargetArn; }
            set { this._securityProfileTargetArn = value; }
        }

        // Check to see if SecurityProfileTargetArn property is set
        internal bool IsSetSecurityProfileTargetArn()
        {
            return this._securityProfileTargetArn != null;
        }

    }
}