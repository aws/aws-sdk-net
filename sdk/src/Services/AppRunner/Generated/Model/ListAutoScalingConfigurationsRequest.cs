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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the ListAutoScalingConfigurations operation.
    /// Returns a list of active App Runner automatic scaling configurations in your Amazon
    /// Web Services account. You can query the revisions for a specific configuration name
    /// or the revisions for all active configurations in your account. You can optionally
    /// query only the latest revision of each requested name.
    /// 
    ///  
    /// <para>
    /// To retrieve a full description of a particular configuration revision, call and provide
    /// one of the ARNs returned by <c>ListAutoScalingConfigurations</c>.
    /// </para>
    /// </summary>
    public partial class ListAutoScalingConfigurationsRequest : AmazonAppRunnerRequest
    {
        private string _autoScalingConfigurationName;
        private bool? _latestOnly;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationName. 
        /// <para>
        /// The name of the App Runner auto scaling configuration that you want to list. If specified,
        /// App Runner lists revisions that share this name. If not specified, App Runner returns
        /// revisions of all active configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=32)]
        public string AutoScalingConfigurationName
        {
            get { return this._autoScalingConfigurationName; }
            set { this._autoScalingConfigurationName = value; }
        }

        // Check to see if AutoScalingConfigurationName property is set
        internal bool IsSetAutoScalingConfigurationName()
        {
            return this._autoScalingConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestOnly. 
        /// <para>
        /// Set to <c>true</c> to list only the latest revision for each requested configuration
        /// name.
        /// </para>
        ///  
        /// <para>
        /// Set to <c>false</c> to list all revisions for each requested configuration name.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? LatestOnly
        {
            get { return this._latestOnly; }
            set { this._latestOnly = value; }
        }

        // Check to see if LatestOnly property is set
        internal bool IsSetLatestOnly()
        {
            return this._latestOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in each response (result page). It's used
        /// for a paginated request.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>MaxResults</c>, the request retrieves all available results
        /// in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A token from a previous result page. It's used for a paginated request. The request
        /// retrieves the next result page. All other parameter values must be identical to the
        /// ones that are specified in the initial request.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>NextToken</c>, the request retrieves the first result page.
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