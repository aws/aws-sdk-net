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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateManagedRuleSetVersionExpiryDate operation.
    /// </summary>
    public partial class UpdateManagedRuleSetVersionExpiryDateResponse : AmazonWebServiceResponse
    {
        private string _expiringVersion;
        private DateTime? _expiryTimestamp;
        private string _nextLockToken;

        /// <summary>
        /// Gets and sets the property ExpiringVersion. 
        /// <para>
        /// The version that is set to expire. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ExpiringVersion
        {
            get { return this._expiringVersion; }
            set { this._expiringVersion = value; }
        }

        // Check to see if ExpiringVersion property is set
        internal bool IsSetExpiringVersion()
        {
            return this._expiringVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiryTimestamp. 
        /// <para>
        /// The time that the version will expire. 
        /// </para>
        ///  
        /// <para>
        /// Times are in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, Z. For example, "2016-09-27T14:50Z". 
        /// </para>
        /// </summary>
        public DateTime? ExpiryTimestamp
        {
            get { return this._expiryTimestamp; }
            set { this._expiryTimestamp = value; }
        }

        // Check to see if ExpiryTimestamp property is set
        internal bool IsSetExpiryTimestamp()
        {
            return this._expiryTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextLockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string NextLockToken
        {
            get { return this._nextLockToken; }
            set { this._nextLockToken = value; }
        }

        // Check to see if NextLockToken property is set
        internal bool IsSetNextLockToken()
        {
            return this._nextLockToken != null;
        }

    }
}