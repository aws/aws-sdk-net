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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a component that is a candidate to deploy to a Greengrass
    /// core device.
    /// </summary>
    public partial class ComponentCandidate
    {
        private string _componentName;
        private string _componentVersion;
        private Dictionary<string, string> _versionRequirements = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property VersionRequirements. 
        /// <para>
        /// The version requirements for the component's dependencies. Greengrass core devices
        /// get the version requirements from component recipes.
        /// </para>
        ///  
        /// <para>
        /// IoT Greengrass V2 uses semantic version constraints. For more information, see <a
        /// href="https://semver.org/">Semantic Versioning</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> VersionRequirements
        {
            get { return this._versionRequirements; }
            set { this._versionRequirements = value; }
        }

        // Check to see if VersionRequirements property is set
        internal bool IsSetVersionRequirements()
        {
            return this._versionRequirements != null && (this._versionRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}