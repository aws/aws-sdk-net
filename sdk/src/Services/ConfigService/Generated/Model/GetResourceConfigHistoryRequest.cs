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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceConfigHistory operation.
    /// <important> 
    /// <para>
    /// For accurate reporting on the compliance status, you must record the <c>AWS::Config::ResourceCompliance</c>
    /// resource type.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/select-resources.html">Recording
    /// Amazon Web Services Resources</a> in the <i>Config Resources Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Returns a list of configurations items (CIs) for the specified resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Contents</b> 
    /// </para>
    ///  
    /// <para>
    /// The list contains details about each state of the resource during the specified time
    /// interval. If you specified a retention period to retain your CIs between a minimum
    /// of 30 days and a maximum of 7 years (2557 days), Config returns the CIs for the specified
    /// retention period. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Pagination</b> 
    /// </para>
    ///  
    /// <para>
    /// The response is paginated. By default, Config returns a limit of 10 configuration
    /// items per page. You can customize this number with the <c>limit</c> parameter. The
    /// response includes a <c>nextToken</c> string. To get the next page of results, run
    /// the request again and specify the string for the <c>nextToken</c> parameter.
    /// </para>
    ///  <note> 
    /// <para>
    /// Each call to the API is limited to span a duration of seven days. It is likely that
    /// the number of records returned is smaller than the specified <c>limit</c>. In such
    /// cases, you can make another call, using the <c>nextToken</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetResourceConfigHistoryRequest : AmazonConfigServiceRequest
    {
        private ChronologicalOrder _chronologicalOrder;
        private DateTime? _earlierTime;
        private DateTime? _laterTime;
        private int? _limit;
        private string _nextToken;
        private string _resourceId;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ChronologicalOrder. 
        /// <para>
        /// The chronological order for configuration items listed. By default, the results are
        /// listed in reverse chronological order.
        /// </para>
        /// </summary>
        public ChronologicalOrder ChronologicalOrder
        {
            get { return this._chronologicalOrder; }
            set { this._chronologicalOrder = value; }
        }

        // Check to see if ChronologicalOrder property is set
        internal bool IsSetChronologicalOrder()
        {
            return this._chronologicalOrder != null;
        }

        /// <summary>
        /// Gets and sets the property EarlierTime. 
        /// <para>
        /// The chronologically earliest time in the time range for which the history requested.
        /// If not specified, the action returns paginated results that contain configuration
        /// items that start when the first configuration item was recorded.
        /// </para>
        /// </summary>
        public DateTime? EarlierTime
        {
            get { return this._earlierTime; }
            set { this._earlierTime = value; }
        }

        // Check to see if EarlierTime property is set
        internal bool IsSetEarlierTime()
        {
            return this._earlierTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaterTime. 
        /// <para>
        /// The chronologically latest time in the time range for which the history requested.
        /// If not specified, current time is taken.
        /// </para>
        /// </summary>
        public DateTime? LaterTime
        {
            get { return this._laterTime; }
            set { this._laterTime = value; }
        }

        // Check to see if LaterTime property is set
        internal bool IsSetLaterTime()
        {
            return this._laterTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of configuration items returned on each page. The default is 10.
        /// You cannot specify a number greater than 100. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource (for example., <c>sg-xxxxxx</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=768)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}