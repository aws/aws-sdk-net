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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The group of AWS resource types that AWS Config records when starting the configuration
    /// recorder.
    /// 
    ///  
    /// <para>
    /// <b>recordingGroup</b> can have one and only one parameter. Choose either <b>allSupported</b>
    /// or <b>resourceTypes</b>.
    /// </para>
    /// </summary>
    public partial class RecordingGroup
    {
        private bool? _allSupported;
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property AllSupported. 
        /// <para>
        /// Records all supported resource types in the recording group. For a list of supported
        /// resource types, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
        /// resource types</a>. If you specify <b>allSupported</b>, you cannot enumerate a list
        /// of <b>resourceTypes</b>. 
        /// </para>
        /// </summary>
        public bool AllSupported
        {
            get { return this._allSupported.GetValueOrDefault(); }
            set { this._allSupported = value; }
        }

        // Check to see if AllSupported property is set
        internal bool IsSetAllSupported()
        {
            return this._allSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A comma-separated list of strings representing valid AWS resource types (for example,
        /// <code>AWS::EC2::Instance</code> or <code>AWS::CloudTrail::Trail</code>). <b>resourceTypes</b>
        /// is only valid if you have chosen not to select <b>allSupported</b>. For a list of
        /// valid <b>resourceTypes</b> values, see the <b>resourceType Value</b> column in the
        /// following topic: <a href="http://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
        /// AWS Resource Types</a>.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

    }
}