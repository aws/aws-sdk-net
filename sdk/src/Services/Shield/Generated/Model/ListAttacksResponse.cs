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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// This is the response object from the ListAttacks operation.
    /// </summary>
    public partial class ListAttacksResponse : AmazonWebServiceResponse
    {
        private List<AttackSummary> _attackSummaries = AWSConfigs.InitializeCollections ? new List<AttackSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AttackSummaries. 
        /// <para>
        /// The attack information for the specified time range.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttackSummary> AttackSummaries
        {
            get { return this._attackSummaries; }
            set { this._attackSummaries = value; }
        }

        // Check to see if AttackSummaries property is set
        internal bool IsSetAttackSummaries()
        {
            return this._attackSummaries != null && (this._attackSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request a list of objects from Shield Advanced, if the response does not
        /// include all of the remaining available objects, Shield Advanced includes a <c>NextToken</c>
        /// value in the response. You can retrieve the next batch of objects by requesting the
        /// list again and providing the token that was returned by the prior call in your request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can indicate the maximum number of objects that you want Shield Advanced to return
        /// for a single call with the <c>MaxResults</c> setting. Shield Advanced will not return
        /// more than <c>MaxResults</c> objects, but may return fewer, even if more objects are
        /// still available.
        /// </para>
        ///  
        /// <para>
        /// Whenever more objects remain that Shield Advanced has not yet returned to you, the
        /// response will include a <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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