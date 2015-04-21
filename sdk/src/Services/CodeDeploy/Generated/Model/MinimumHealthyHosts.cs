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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about minimum healthy instances.
    /// </summary>
    public partial class MinimumHealthyHosts
    {
        private MinimumHealthyHostsType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The minimum healthy instances type:
        /// </para>
        ///  <ul> <li>HOST_COUNT: The minimum number of healthy instances, as an absolute value.</li>
        /// <li>FLEET_PERCENT: The minimum number of healthy instances, as a percentage of the
        /// total number of instances in the deployment.</li> </ul> 
        /// <para>
        /// For example, for 9 instances, if a HOST_COUNT of 6 is specified, deploy to up to 3
        /// instances at a time. The deployment succeeds if 6 or more instances are successfully
        /// deployed to; otherwise, the deployment fails. If a FLEET_PERCENT of 40 is specified,
        /// deploy to up to 5 instances at a time. The deployment succeeds if 4 or more instances
        /// are successfully deployed to; otherwise, the deployment fails.
        /// </para>
        ///  <note>In a call to the get deployment configuration operation, CodeDeployDefault.OneAtATime
        /// will return a minimum healthy instances type of MOST_CONCURRENCY and a value of 1.
        /// This means a deployment to only one instances at a time. (You cannot set the type
        /// to MOST_CONCURRENCY, only to HOST_COUNT or FLEET_PERCENT.)</note>
        /// </summary>
        public MinimumHealthyHostsType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The minimum healthy instances value.
        /// </para>
        /// </summary>
        public int Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}