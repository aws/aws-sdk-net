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
    /// Container for the parameters to the DeleteRecommendationPreferences operation.
    /// Deletes a recommendation preference, such as enhanced infrastructure metrics.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
    /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteRecommendationPreferencesRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _recommendationPreferenceNames = new List<string>();
        private ResourceType _resourceType;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property RecommendationPreferenceNames. 
        /// <para>
        /// The name of the recommendation preference to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RecommendationPreferenceNames
        {
            get { return this._recommendationPreferenceNames; }
            set { this._recommendationPreferenceNames = value; }
        }

        // Check to see if RecommendationPreferenceNames property is set
        internal bool IsSetRecommendationPreferenceNames()
        {
            return this._recommendationPreferenceNames != null && this._recommendationPreferenceNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The target resource type of the recommendation preference to delete.
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
        /// An object that describes the scope of the recommendation preference to delete.
        /// </para>
        ///  
        /// <para>
        /// You can delete recommendation preferences that are created at the organization level
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