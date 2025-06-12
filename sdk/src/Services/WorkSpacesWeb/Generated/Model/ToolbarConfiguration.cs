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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The configuration of the toolbar. This allows administrators to select the toolbar
    /// type and visual mode, set maximum display resolution for sessions, and choose which
    /// items are visible to end users during their sessions. If administrators do not modify
    /// these settings, end users retain control over their toolbar preferences.
    /// </summary>
    public partial class ToolbarConfiguration
    {
        private List<string> _hiddenToolbarItems = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MaxDisplayResolution _maxDisplayResolution;
        private ToolbarType _toolbarType;
        private VisualMode _visualMode;

        /// <summary>
        /// Gets and sets the property HiddenToolbarItems. 
        /// <para>
        /// The list of toolbar items to be hidden.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenToolbarItems
        {
            get { return this._hiddenToolbarItems; }
            set { this._hiddenToolbarItems = value; }
        }

        // Check to see if HiddenToolbarItems property is set
        internal bool IsSetHiddenToolbarItems()
        {
            return this._hiddenToolbarItems != null && (this._hiddenToolbarItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxDisplayResolution. 
        /// <para>
        /// The maximum display resolution that is allowed for the session.
        /// </para>
        /// </summary>
        public MaxDisplayResolution MaxDisplayResolution
        {
            get { return this._maxDisplayResolution; }
            set { this._maxDisplayResolution = value; }
        }

        // Check to see if MaxDisplayResolution property is set
        internal bool IsSetMaxDisplayResolution()
        {
            return this._maxDisplayResolution != null;
        }

        /// <summary>
        /// Gets and sets the property ToolbarType. 
        /// <para>
        /// The type of toolbar displayed during the session.
        /// </para>
        /// </summary>
        public ToolbarType ToolbarType
        {
            get { return this._toolbarType; }
            set { this._toolbarType = value; }
        }

        // Check to see if ToolbarType property is set
        internal bool IsSetToolbarType()
        {
            return this._toolbarType != null;
        }

        /// <summary>
        /// Gets and sets the property VisualMode. 
        /// <para>
        /// The visual mode of the toolbar.
        /// </para>
        /// </summary>
        public VisualMode VisualMode
        {
            get { return this._visualMode; }
            set { this._visualMode = value; }
        }

        // Check to see if VisualMode property is set
        internal bool IsSetVisualMode()
        {
            return this._visualMode != null;
        }

    }
}