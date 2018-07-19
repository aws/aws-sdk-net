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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// This is the response object from the ModifyTargetGroup operation.
    /// </summary>
    public partial class ModifyTargetGroupResponse : AmazonWebServiceResponse
    {
        private List<TargetGroup> _targetGroups = new List<TargetGroup>();

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        /// Information about the modified target group.
        /// </para>
        /// </summary>
        public List<TargetGroup> TargetGroups
        {
            get { return this._targetGroups; }
            set { this._targetGroups = value; }
        }

        // Check to see if TargetGroups property is set
        internal bool IsSetTargetGroups()
        {
            return this._targetGroups != null && this._targetGroups.Count > 0; 
        }

    }
}