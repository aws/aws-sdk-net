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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the Global Accelerator for directory
    /// </summary>
    public partial class GlobalAcceleratorForDirectory
    {
        private AGAModeForDirectoryEnum _mode;
        private AGAPreferredProtocolForDirectory _preferredProtocol;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Indicates if Global Accelerator for directory is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AGAModeForDirectoryEnum Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredProtocol. 
        /// <para>
        /// Indicates the preferred protocol for Global Accelerator.
        /// </para>
        /// </summary>
        public AGAPreferredProtocolForDirectory PreferredProtocol
        {
            get { return this._preferredProtocol; }
            set { this._preferredProtocol = value; }
        }

        // Check to see if PreferredProtocol property is set
        internal bool IsSetPreferredProtocol()
        {
            return this._preferredProtocol != null;
        }

    }
}