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
    /// Describes a launch template and overrides. 
    /// 
    ///  
    /// <para>
    /// The overrides are used to override the instance type specified by the launch template
    /// with multiple instance types that can be used to launch On-Demand Instances and Spot
    /// Instances. 
    /// </para>
    /// </summary>
    public partial class LaunchTemplate
    {
        private LaunchTemplateSpecification _launchTemplateSpecification;
        private List<LaunchTemplateOverrides> _overrides = new List<LaunchTemplateOverrides>();

        /// <summary>
        /// Gets and sets the property LaunchTemplateSpecification. 
        /// <para>
        /// The launch template to use. You must specify either the launch template ID or launch
        /// template name in the request. 
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
        /// Currently, the only supported override is instance type. 
        /// </para>
        ///  
        /// <para>
        /// You must specify between 2 and 20 overrides.
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