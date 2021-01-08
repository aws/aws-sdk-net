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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a component on a AWS IoT Greengrass core device.
    /// </summary>
    public partial class InstalledComponent
    {
        private string _componentName;
        private string _componentVersion;
        private bool? _isRoot;
        private InstalledComponentLifecycleState _lifecycleState;
        private string _lifecycleStateDetails;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ComponentVersion
        {
            get { return this._componentVersion; }
            set { this._componentVersion = value; }
        }

        // Check to see if ComponentVersion property is set
        internal bool IsSetComponentVersion()
        {
            return this._componentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IsRoot. 
        /// <para>
        /// Whether or not the component is a root component.
        /// </para>
        /// </summary>
        public bool IsRoot
        {
            get { return this._isRoot.GetValueOrDefault(); }
            set { this._isRoot = value; }
        }

        // Check to see if IsRoot property is set
        internal bool IsSetIsRoot()
        {
            return this._isRoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The lifecycle state of the component.
        /// </para>
        /// </summary>
        public InstalledComponentLifecycleState LifecycleState
        {
            get { return this._lifecycleState; }
            set { this._lifecycleState = value; }
        }

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this._lifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleStateDetails. 
        /// <para>
        /// The details about the lifecycle state of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string LifecycleStateDetails
        {
            get { return this._lifecycleStateDetails; }
            set { this._lifecycleStateDetails = value; }
        }

        // Check to see if LifecycleStateDetails property is set
        internal bool IsSetLifecycleStateDetails()
        {
            return this._lifecycleStateDetails != null;
        }

    }
}