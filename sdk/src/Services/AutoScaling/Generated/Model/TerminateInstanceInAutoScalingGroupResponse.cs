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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the TerminateInstanceInAutoScalingGroup operation.
    /// </summary>
    public partial class TerminateInstanceInAutoScalingGroupResponse : AmazonWebServiceResponse
    {
        private Activity _activity;

        /// <summary>
        /// Gets and sets the property Activity. 
        /// <para>
        /// A scaling activity.
        /// </para>
        /// </summary>
        public Activity Activity
        {
            get { return this._activity; }
            set { this._activity = value; }
        }

        // Check to see if Activity property is set
        internal bool IsSetActivity()
        {
            return this._activity != null;
        }

    }
}