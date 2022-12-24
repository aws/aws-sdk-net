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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetRecommendationPreferences operation.
    /// Returns existing recommendation preferences, such as enhanced infrastructure metrics.
    /// 
    ///  
    /// <para>
    /// Use the <code>scope</code> parameter to specify which preferences to return. You can
    /// specify to return preferences for an organization, a specific account ID, or a specific
    /// EC2 instance or Auto Scaling group Amazon Resource Name (ARN).
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
    /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetRecommendationPreferencesRequest : AmazonComputeOptimizerRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ResourceType _resourceType;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendation preferences to return with a single request.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another request with the returned <code>nextToken</code>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// The token to advance to the next page of recommendation preferences.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The target resource type of the recommendation preference for which to return preferences.
        /// </para>
        ///  
        /// <para>
        /// The <code>Ec2Instance</code> option encompasses standalone instances and instances
        /// that are part of Auto Scaling groups. The <code>AutoScalingGroup</code> option encompasses
        /// only instances that are part of an Auto Scaling group.
        /// </para>
        ///  <note> 
        /// <para>
        /// The valid values for this parameter are <code>Ec2Instance</code> and <code>AutoScalingGroup</code>.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An object that describes the scope of the recommendation preference to return.
        /// </para>
        ///  
        /// <para>
        /// You can return recommendation preferences that are created at the organization level
        /// (for management accounts of an organization only), account level, and resource level.
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}