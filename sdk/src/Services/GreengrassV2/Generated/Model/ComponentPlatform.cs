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
    /// Contains information about a platform that a component supports.
    /// </summary>
    public partial class ComponentPlatform
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A dictionary of attributes for the platform. The AWS IoT Greengrass Core software
        /// defines the <code>os</code> and <code>platform</code> by default. You can specify
        /// additional platform attributes for a core device when you deploy the AWS IoT Greengrass
        /// nucleus component. For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html">AWS
        /// IoT Greengrass nucleus component</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the platform. This name helps you identify the platform.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, AWS IoT Greengrass creates a friendly name from the <code>os</code>
        /// and <code>architecture</code> of the platform.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}