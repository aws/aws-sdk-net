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

/*
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickProjects.Model
{
    /// <summary>
    /// An object defining the template for a placement.
    /// </summary>
    public partial class PlacementTemplate
    {
        private Dictionary<string, string> _defaultAttributes = new Dictionary<string, string>();
        private Dictionary<string, DeviceTemplate> _deviceTemplates = new Dictionary<string, DeviceTemplate>();

        /// <summary>
        /// Gets and sets the property DefaultAttributes. 
        /// <para>
        /// The default attributes (key/value pairs) to be applied to all placements using this
        /// template.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DefaultAttributes
        {
            get { return this._defaultAttributes; }
            set { this._defaultAttributes = value; }
        }

        // Check to see if DefaultAttributes property is set
        internal bool IsSetDefaultAttributes()
        {
            return this._defaultAttributes != null && this._defaultAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceTemplates. 
        /// <para>
        /// An object specifying the <a>DeviceTemplate</a> for all placements using this (<a>PlacementTemplate</a>)
        /// template.
        /// </para>
        /// </summary>
        public Dictionary<string, DeviceTemplate> DeviceTemplates
        {
            get { return this._deviceTemplates; }
            set { this._deviceTemplates = value; }
        }

        // Check to see if DeviceTemplates property is set
        internal bool IsSetDeviceTemplates()
        {
            return this._deviceTemplates != null && this._deviceTemplates.Count > 0; 
        }

    }
}