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
    /// Contains information about a deployment's update to a component's configuration on
    /// Greengrass core devices. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/update-component-configurations.html">Update
    /// component configurations</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// </summary>
    public partial class ComponentConfigurationUpdate
    {
        private string _merge;
        private List<string> _reset = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Merge. 
        /// <para>
        /// A serialized JSON string that contains the configuration object to merge to target
        /// devices. The core device merges this configuration with the component's existing configuration.
        /// If this is the first time a component deploys on a device, the core device merges
        /// this configuration with the component's default configuration. This means that the
        /// core device keeps it's existing configuration for keys and values that you don't specify
        /// in this object. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/update-component-configurations.html#merge-configuration-update">Merge
        /// configuration updates</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10485760)]
        public string Merge
        {
            get { return this._merge; }
            set { this._merge = value; }
        }

        // Check to see if Merge property is set
        internal bool IsSetMerge()
        {
            return this._merge != null;
        }

        /// <summary>
        /// Gets and sets the property Reset. 
        /// <para>
        /// The list of configuration nodes to reset to default values on target devices. Use
        /// JSON pointers to specify each node to reset. JSON pointers start with a forward slash
        /// (<c>/</c>) and use forward slashes to separate the key for each level in the object.
        /// For more information, see the <a href="https://tools.ietf.org/html/rfc6901">JSON pointer
        /// specification</a> and <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/update-component-configurations.html#reset-configuration-update">Reset
        /// configuration updates</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Reset
        {
            get { return this._reset; }
            set { this._reset = value; }
        }

        // Check to see if Reset property is set
        internal bool IsSetReset()
        {
            return this._reset != null && (this._reset.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}