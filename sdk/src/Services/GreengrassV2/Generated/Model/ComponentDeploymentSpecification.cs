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
    /// Contains information about a component to deploy.
    /// </summary>
    public partial class ComponentDeploymentSpecification
    {
        private string _componentVersion;
        private ComponentConfigurationUpdate _configurationUpdate;
        private ComponentRunWith _runWith;

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property ConfigurationUpdate. 
        /// <para>
        /// The configuration updates to deploy for the component. You can define <i>reset</i>
        /// updates and <i>merge</i> updates. A reset updates the keys that you specify to the
        /// default configuration for the component. A merge updates the core device's component
        /// configuration with the keys and values that you specify. The IoT Greengrass Core software
        /// applies reset updates before it applies merge updates. For more information, see <a
        /// href="https://docs.aws.amazon.com/greengrass/v2/developerguide/update-component-configurations.html">Update
        /// component configurations</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        public ComponentConfigurationUpdate ConfigurationUpdate
        {
            get { return this._configurationUpdate; }
            set { this._configurationUpdate = value; }
        }

        // Check to see if ConfigurationUpdate property is set
        internal bool IsSetConfigurationUpdate()
        {
            return this._configurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property RunWith. 
        /// <para>
        /// The system user and group that the IoT Greengrass Core software uses to run component
        /// processes on the core device. If you omit this parameter, the IoT Greengrass Core
        /// software uses the system user and group that you configure for the core device. For
        /// more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-greengrass-core-v2.html#configure-component-user">Configure
        /// the user and group that run components</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        public ComponentRunWith RunWith
        {
            get { return this._runWith; }
            set { this._runWith = value; }
        }

        // Check to see if RunWith property is set
        internal bool IsSetRunWith()
        {
            return this._runWith != null;
        }

    }
}