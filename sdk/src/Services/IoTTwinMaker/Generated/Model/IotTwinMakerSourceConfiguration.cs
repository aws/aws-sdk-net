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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The metadata transfer job AWS IoT TwinMaker source configuration.
    /// </summary>
    public partial class IotTwinMakerSourceConfiguration
    {
        private List<IotTwinMakerSourceConfigurationFilter> _filters = AWSConfigs.InitializeCollections ? new List<IotTwinMakerSourceConfigurationFilter>() : null;
        private string _workspace;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The metadata transfer job AWS IoT TwinMaker source configuration filters.
        /// </para>
        /// </summary>
        public List<IotTwinMakerSourceConfigurationFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Workspace. 
        /// <para>
        /// The IoT TwinMaker workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Workspace
        {
            get { return this._workspace; }
            set { this._workspace = value; }
        }

        // Check to see if Workspace property is set
        internal bool IsSetWorkspace()
        {
            return this._workspace != null;
        }

    }
}