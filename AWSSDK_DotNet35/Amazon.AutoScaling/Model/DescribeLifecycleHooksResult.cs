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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeLifecycleHooksResult : AmazonWebServiceResponse
    {
        private List<LifecycleHook> _lifecycleHooks = new List<LifecycleHook>();

        /// <summary>
        /// Gets and sets the property LifecycleHooks. 
        /// <para>
        /// The lifecycle hooks for the specified group.
        /// </para>
        /// </summary>
        public List<LifecycleHook> LifecycleHooks
        {
            get { return this._lifecycleHooks; }
            set { this._lifecycleHooks = value; }
        }

        // Check to see if LifecycleHooks property is set
        internal bool IsSetLifecycleHooks()
        {
            return this._lifecycleHooks != null && this._lifecycleHooks.Count > 0; 
        }

    }
}