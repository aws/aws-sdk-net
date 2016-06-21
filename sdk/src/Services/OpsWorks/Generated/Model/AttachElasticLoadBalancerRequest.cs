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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the AttachElasticLoadBalancer operation.
    /// Attaches an Elastic Load Balancing load balancer to a specified layer. For more information,
    /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/load-balancer-elb.html">Elastic
    /// Load Balancing</a>.
    /// 
    ///  <note> 
    /// <para>
    /// You must create the Elastic Load Balancing instance separately, by using the Elastic
    /// Load Balancing console, API, or CLI. For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/Welcome.html">
    /// Elastic Load Balancing Developer Guide</a>.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class AttachElasticLoadBalancerRequest : AmazonOpsWorksRequest
    {
        private string _elasticLoadBalancerName;
        private string _layerId;

        /// <summary>
        /// Gets and sets the property ElasticLoadBalancerName. 
        /// <para>
        /// The Elastic Load Balancing instance's name.
        /// </para>
        /// </summary>
        public string ElasticLoadBalancerName
        {
            get { return this._elasticLoadBalancerName; }
            set { this._elasticLoadBalancerName = value; }
        }

        // Check to see if ElasticLoadBalancerName property is set
        internal bool IsSetElasticLoadBalancerName()
        {
            return this._elasticLoadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The ID of the layer that the Elastic Load Balancing instance is to be attached to.
        /// </para>
        /// </summary>
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }

    }
}