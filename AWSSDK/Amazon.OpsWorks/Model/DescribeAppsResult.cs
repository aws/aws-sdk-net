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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeApps</code> request.
    /// </summary>
    public partial class DescribeAppsResult
    {
        private List<App> _apps = new List<App>();


        /// <summary>
        /// Gets and sets the property Apps. 
        /// <para>
        /// An array of <code>App</code> objects that describe the specified apps. 
        /// </para>
        /// </summary>
        public List<App> Apps
        {
            get { return this._apps; }
            set { this._apps = value; }
        }

        /// <summary>
        /// Sets the Apps property
        /// </summary>
        /// <param name="apps">The values to add to the Apps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAppsResult WithApps(params App[] apps)
        {
            foreach (var element in apps)
            {
                this._apps.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Apps property
        /// </summary>
        /// <param name="apps">The values to add to the Apps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAppsResult WithApps(IEnumerable<App> apps)
        {
            foreach (var element in apps)
            {
                this._apps.Add(element);
            }
            return this;
        }
        // Check to see if Apps property is set
        internal bool IsSetApps()
        {
            return this._apps != null && this._apps.Count > 0; 
        }

    }
}