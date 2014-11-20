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
    public partial class DescribeLifecycleHookTypesResult : AmazonWebServiceResponse
    {
        private List<string> _lifecycleHookTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property LifecycleHookTypes. 
        /// <para>
        /// One or more of the following notification types:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>autoscaling:EC2_INSTANCE_LAUNCHING</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>autoscaling:EC2_INSTANCE_TERMINATING</code>
        /// </para>
        /// </li> </ul>
        /// </summary>
        public List<string> LifecycleHookTypes
        {
            get { return this._lifecycleHookTypes; }
            set { this._lifecycleHookTypes = value; }
        }

        // Check to see if LifecycleHookTypes property is set
        internal bool IsSetLifecycleHookTypes()
        {
            return this._lifecycleHookTypes != null && this._lifecycleHookTypes.Count > 0; 
        }

    }
}