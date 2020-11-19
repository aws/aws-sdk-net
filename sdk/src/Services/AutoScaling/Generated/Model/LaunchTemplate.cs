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
    /// Describes a launch template and overrides. 
    /// 
    ///  
    /// <para>
    /// You specify these parameters as part of a mixed instances policy. 
    /// </para>
    ///  
    /// <para>
    /// When you update the launch template or overrides, existing Amazon EC2 instances continue
    /// to run. When scale out occurs, Amazon EC2 Auto Scaling launches instances to match
    /// the new settings. When scale in occurs, Amazon EC2 Auto Scaling terminates instances
    /// according to the group's termination policies.
    /// </para>
    /// </summary>
    public partial class LaunchTemplate
    {
        private LaunchTemplateSpecification _launchTemplateSpecification;
        private List<LaunchTemplateOverrides> _overrides = new List<LaunchTemplateOverrides>();

        /// <summary>
        /// Gets and sets the property LaunchTemplateSpecification. 
        /// <para>
        /// The launch template to use.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplateSpecification
        {
            get { return this._launchTemplateSpecification; }
            set { this._launchTemplateSpecification = value; }
        }

        // Check to see if LaunchTemplateSpecification property is set
        internal bool IsSetLaunchTemplateSpecification()
        {
            return this._launchTemplateSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Any parameters that you specify override the same parameters in the launch template.
        /// If not provided, Amazon EC2 Auto Scaling uses the instance type specified in the launch
        /// template when it launches an instance. 
        /// </para>
        /// </summary>
        public List<LaunchTemplateOverrides> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && this._overrides.Count > 0; 
        }

    }
}