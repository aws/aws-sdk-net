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
    /// Describes whether a WorkSpace image needs to be updated with the latest drivers and
    /// other components required by Amazon WorkSpaces.
    /// 
    ///  <note> 
    /// <para>
    /// Only Windows 10 WorkSpace images can be programmatically updated at this time.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateResult
    {
        private string _description;
        private bool? _updateAvailable;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of whether updates for the WorkSpace image are pending or available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateAvailable. 
        /// <para>
        /// Indicates whether updated drivers or other components are available for the specified
        /// WorkSpace image.
        /// </para>
        /// </summary>
        public bool? UpdateAvailable
        {
            get { return this._updateAvailable; }
            set { this._updateAvailable = value; }
        }

        // Check to see if UpdateAvailable property is set
        internal bool IsSetUpdateAvailable()
        {
            return this._updateAvailable.HasValue; 
        }

    }
}