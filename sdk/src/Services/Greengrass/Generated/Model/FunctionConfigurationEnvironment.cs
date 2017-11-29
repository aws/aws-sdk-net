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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Environment of the function configuration
    /// </summary>
    public partial class FunctionConfigurationEnvironment
    {
        private bool? _accessSysfs;
        private List<ResourceAccessPolicy> _resourceAccessPolicies = new List<ResourceAccessPolicy>();
        private Dictionary<string, string> _variables = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccessSysfs. Flag to allow lambda access sys filesystem.
        /// </summary>
        public bool AccessSysfs
        {
            get { return this._accessSysfs.GetValueOrDefault(); }
            set { this._accessSysfs = value; }
        }

        // Check to see if AccessSysfs property is set
        internal bool IsSetAccessSysfs()
        {
            return this._accessSysfs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceAccessPolicies. Policies for the function to access
        /// resources.
        /// </summary>
        public List<ResourceAccessPolicy> ResourceAccessPolicies
        {
            get { return this._resourceAccessPolicies; }
            set { this._resourceAccessPolicies = value; }
        }

        // Check to see if ResourceAccessPolicies property is set
        internal bool IsSetResourceAccessPolicies()
        {
            return this._resourceAccessPolicies != null && this._resourceAccessPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Variables. Environment variables for the lambda function.
        /// </summary>
        public Dictionary<string, string> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && this._variables.Count > 0; 
        }

    }
}