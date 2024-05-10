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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an IoT SiteWise Monitor resource ID for a portal or project.
    /// </summary>
    public partial class Resource
    {
        private PortalResource _portal;
        private ProjectResource _project;

        /// <summary>
        /// Gets and sets the property Portal. 
        /// <para>
        /// A portal resource.
        /// </para>
        /// </summary>
        public PortalResource Portal
        {
            get { return this._portal; }
            set { this._portal = value; }
        }

        // Check to see if Portal property is set
        internal bool IsSetPortal()
        {
            return this._portal != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// A project resource.
        /// </para>
        /// </summary>
        public ProjectResource Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}