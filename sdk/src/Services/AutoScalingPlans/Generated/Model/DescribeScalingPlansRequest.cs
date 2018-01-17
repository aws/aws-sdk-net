/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScalingPlans operation.
    /// Describes the specified scaling plans or all of your scaling plans.
    /// </summary>
    public partial class DescribeScalingPlansRequest : AmazonAutoScalingPlansRequest
    {
        private List<ApplicationSource> _applicationSources = new List<ApplicationSource>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _scalingPlanNames = new List<string>();
        private long? _scalingPlanVersion;

        /// <summary>
        /// Gets and sets the property ApplicationSources. 
        /// <para>
        /// The sources for the applications (up to 10). If you specify scaling plan names, you
        /// cannot specify application sources.
        /// </para>
        /// </summary>
        public List<ApplicationSource> ApplicationSources
        {
            get { return this._applicationSources; }
            set { this._applicationSources = value; }
        }

        // Check to see if ApplicationSources property is set
        internal bool IsSetApplicationSources()
        {
            return this._applicationSources != null && this._applicationSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of scalable resources to return. This value can be between 1 and
        /// 50. The default value is 50.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// Gets and sets the property ScalingPlanNames. 
        /// <para>
        /// The names of the scaling plans (up to 10). If you specify application sources, you
        /// cannot specify scaling plan names.
        /// </para>
        /// </summary>
        public List<string> ScalingPlanNames
        {
            get { return this._scalingPlanNames; }
            set { this._scalingPlanNames = value; }
        }

        // Check to see if ScalingPlanNames property is set
        internal bool IsSetScalingPlanNames()
        {
            return this._scalingPlanNames != null && this._scalingPlanNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version of the scaling plan. If you specify a scaling plan version, you must also
        /// specify a scaling plan name.
        /// </para>
        /// </summary>
        public long ScalingPlanVersion
        {
            get { return this._scalingPlanVersion.GetValueOrDefault(); }
            set { this._scalingPlanVersion = value; }
        }

        // Check to see if ScalingPlanVersion property is set
        internal bool IsSetScalingPlanVersion()
        {
            return this._scalingPlanVersion.HasValue; 
        }

    }
}