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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubConfig.Model
{
    /// <summary>
    /// This is the response object from the CreateHomeRegionControl operation.
    /// </summary>
    public partial class CreateHomeRegionControlResponse : AmazonWebServiceResponse
    {
        private HomeRegionControl _homeRegionControl;

        /// <summary>
        /// Gets and sets the property HomeRegionControl. 
        /// <para>
        /// This object is the <code>HomeRegionControl</code> object that's returned by a successful
        /// call to <code>CreateHomeRegionControl</code>.
        /// </para>
        /// </summary>
        public HomeRegionControl HomeRegionControl
        {
            get { return this._homeRegionControl; }
            set { this._homeRegionControl = value; }
        }

        // Check to see if HomeRegionControl property is set
        internal bool IsSetHomeRegionControl()
        {
            return this._homeRegionControl != null;
        }

    }
}