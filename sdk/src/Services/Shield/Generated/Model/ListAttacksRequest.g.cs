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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the ListAttacks operation. Returns all ongoing DDoS
    /// attacks or all DDoS attacks during a specified time period.
    /// </summary>
    public partial class ListAttacksRequest : AmazonShieldRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period for the attacks. This is a <c>timestamp</c> type. The request
        /// syntax listing for this call indicates a <c>number</c> type, but you can provide the
        /// time in any valid <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">timestamp
        /// format</a> setting. 
        /// </para>
        /// </summary>
        public TimeRange EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The greatest number of objects that you want Shield Advanced to return to the list
        /// request. Shield Advanced might return fewer objects than you indicate in this setting,
        /// even if more objects are available. If there are more objects remaining, Shield Advanced
        /// will always also return a <c>NextToken</c> value in the response.
        /// </para>
        ///  
        /// <para>
        /// The default setting is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        ///  
        /// <para>
        /// On your first call to a list operation, leave this setting empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARNs (Amazon Resource Names) of the resources that were attacked. If you leave
        /// this blank, all applicable resources for this account will be included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceArns property is set.
        /// </summary>
        internal bool IsSetResourceArns() => this.ResourceArns != null && (this.ResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period for the attacks. This is a <c>timestamp</c> type. The
        /// request syntax listing for this call indicates a <c>number</c> type, but you can provide
        /// the time in any valid <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">timestamp
        /// format</a> setting. 
        /// </para>
        /// </summary>
        public TimeRange StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;
    }
}
