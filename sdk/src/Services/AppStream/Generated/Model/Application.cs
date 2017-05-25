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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// An entry for a single application in the application catalog.
    /// </summary>
    public partial class Application
    {
        private string _displayName;
        private bool? _enabled;
        private string _iconURL;
        private string _launchParameters;
        private string _launchPath;
        private Dictionary<string, string> _metadata = new Dictionary<string, string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the application shown to the end users.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// An application can be disabled after image creation if there is a problem.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IconURL. 
        /// <para>
        /// The URL for the application icon. This URL may be time-limited.
        /// </para>
        /// </summary>
        public string IconURL
        {
            get { return this._iconURL; }
            set { this._iconURL = value; }
        }

        // Check to see if IconURL property is set
        internal bool IsSetIconURL()
        {
            return this._iconURL != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// A list of arguments that are passed to the application at launch.
        /// </para>
        /// </summary>
        public string LaunchParameters
        {
            get { return this._launchParameters; }
            set { this._launchParameters = value; }
        }

        // Check to see if LaunchParameters property is set
        internal bool IsSetLaunchParameters()
        {
            return this._launchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPath. 
        /// <para>
        /// The path to the application executable in the instance.
        /// </para>
        /// </summary>
        public string LaunchPath
        {
            get { return this._launchPath; }
            set { this._launchPath = value; }
        }

        // Check to see if LaunchPath property is set
        internal bool IsSetLaunchPath()
        {
            return this._launchPath != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional attributes that describe the application.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && this._metadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier for the application.
        /// </para>
        /// </summary>
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