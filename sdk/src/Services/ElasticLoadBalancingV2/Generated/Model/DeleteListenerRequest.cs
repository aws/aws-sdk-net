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
    /// Container for the parameters to the DeleteListener operation.
    /// Deletes the specified listener.
    /// 
    ///  
    /// <para>
    /// Alternatively, your listener is deleted when you delete the load balancer it is attached
    /// to using <a>DeleteLoadBalancer</a>.
    /// </para>
    /// </summary>
    public partial class DeleteListenerRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _listenerArn;

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

    }
}