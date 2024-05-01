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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// The value for a given type of <c>UpdateSettings</c>.
    /// </summary>
    public partial class UpdateValue
    {
        private OSUpdateSettings _osUpdateSettings;

        /// <summary>
        /// Gets and sets the property OSUpdateSettings. 
        /// <para>
        ///  The OS update related settings. 
        /// </para>
        /// </summary>
        public OSUpdateSettings OSUpdateSettings
        {
            get { return this._osUpdateSettings; }
            set { this._osUpdateSettings = value; }
        }

        // Check to see if OSUpdateSettings property is set
        internal bool IsSetOSUpdateSettings()
        {
            return this._osUpdateSettings != null;
        }

    }
}