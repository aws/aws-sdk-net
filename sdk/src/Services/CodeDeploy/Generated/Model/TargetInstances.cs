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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the instances to be used in the replacement environment in a blue/green
    /// deployment.
    /// </summary>
    public partial class TargetInstances
    {
        private List<string> _autoScalingGroups = new List<string>();
        private EC2TagSet _ec2TagSet;
        private List<EC2TagFilter> _tagFilters = new List<EC2TagFilter>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// The names of one or more Auto Scaling groups to identify a replacement environment
        /// for a blue/green deployment.
        /// </para>
        /// </summary>
        public List<string> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && this._autoScalingGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ec2TagSet. 
        /// <para>
        /// Information about the groups of EC2 instance tags that an instance must be identified
        /// by in order for it to be included in the replacement environment for a blue/green
        /// deployment. Cannot be used in the same call as <code>tagFilters</code>.
        /// </para>
        /// </summary>
        public EC2TagSet Ec2TagSet
        {
            get { return this._ec2TagSet; }
            set { this._ec2TagSet = value; }
        }

        // Check to see if Ec2TagSet property is set
        internal bool IsSetEc2TagSet()
        {
            return this._ec2TagSet != null;
        }

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// The tag filter key, type, and value used to identify Amazon EC2 instances in a replacement
        /// environment for a blue/green deployment. Cannot be used in the same call as <code>ec2TagSet</code>.
        /// </para>
        /// </summary>
        public List<EC2TagFilter> TagFilters
        {
            get { return this._tagFilters; }
            set { this._tagFilters = value; }
        }

        // Check to see if TagFilters property is set
        internal bool IsSetTagFilters()
        {
            return this._tagFilters != null && this._tagFilters.Count > 0; 
        }

    }
}