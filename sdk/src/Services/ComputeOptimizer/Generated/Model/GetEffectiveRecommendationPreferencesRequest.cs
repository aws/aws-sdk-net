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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetEffectiveRecommendationPreferences operation.
    /// Returns the recommendation preferences that are in effect for a given resource, such
    /// as enhanced infrastructure metrics. Considers all applicable preferences that you
    /// might have set at the resource, account, and organization level.
    /// 
    ///  
    /// <para>
    /// When you create a recommendation preference, you can set its status to <c>Active</c>
    /// or <c>Inactive</c>. Use this action to view the recommendation preferences that are
    /// in effect, or <c>Active</c>.
    /// </para>
    /// </summary>
    public partial class GetEffectiveRecommendationPreferencesRequest : AmazonComputeOptimizerRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource for which to confirm effective recommendation
        /// preferences. Only EC2 instance and Auto Scaling group ARNs are currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}