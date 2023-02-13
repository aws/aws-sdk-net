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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// An object representing the metadata and configuration settings of EKS Anywhere on
    /// the Snow Family device.
    /// </summary>
    public partial class EKSOnDeviceServiceConfiguration
    {
        private string _eksAnywhereVersion;
        private string _kubernetesVersion;

        /// <summary>
        /// Gets and sets the property EKSAnywhereVersion. 
        /// <para>
        /// The version of EKS Anywhere on the Snow Family device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string EKSAnywhereVersion
        {
            get { return this._eksAnywhereVersion; }
            set { this._eksAnywhereVersion = value; }
        }

        // Check to see if EKSAnywhereVersion property is set
        internal bool IsSetEKSAnywhereVersion()
        {
            return this._eksAnywhereVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesVersion. 
        /// <para>
        /// The Kubernetes version for EKS Anywhere on the Snow Family device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KubernetesVersion
        {
            get { return this._kubernetesVersion; }
            set { this._kubernetesVersion = value; }
        }

        // Check to see if KubernetesVersion property is set
        internal bool IsSetKubernetesVersion()
        {
            return this._kubernetesVersion != null;
        }

    }
}