/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeApps</c> request.</para>
    /// </summary>
    public partial class DescribeAppsResult : AmazonWebServiceResponse
    {
        
        private List<App> apps = new List<App>();


        /// <summary>
        /// An array of <c>App</c> objects that describe the specified apps.
        ///  
        /// </summary>
        public List<App> Apps
        {
            get { return this.apps; }
            set { this.apps = value; }
        }

        // Check to see if Apps property is set
        internal bool IsSetApps()
        {
            return this.apps.Count > 0;
        }
    }
}
