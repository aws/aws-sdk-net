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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the target groups to attach to a Spot fleet. Spot fleet registers the running
    /// Spot instances with these target groups.
    /// </summary>
    public partial class TargetGroupsConfig
    {
        private List<TargetGroup> _targetGroups = new List<TargetGroup>();

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        /// One or more target groups.
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