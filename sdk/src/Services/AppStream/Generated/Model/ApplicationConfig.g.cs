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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Configuration for an application in the imported image's application catalog. This
    /// structure defines how applications appear and launch for users.
    /// </summary>
    public partial class ApplicationConfig
    {
        /// <summary>
        /// Gets and sets the property AbsoluteAppPath. 
        /// <para>
        /// The absolute path to the executable file that launches the application. This is a
        /// required field that can be 1-32767 characters to support Windows extended file paths.
        /// Use escaped file path strings like "C:\\\\Windows\\\\System32\\\\notepad.exe".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 32767)]
        public string AbsoluteAppPath { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteAppPath property is set.
        /// </summary>
        internal bool IsSetAbsoluteAppPath() => this.AbsoluteAppPath != null;

        /// <summary>
        /// Gets and sets the property AbsoluteIconPath. 
        /// <para>
        /// The absolute path to the icon file for the application. This field is optional and
        /// can be 1-32767 characters. If not provided, the icon is derived from the executable.
        /// Use PNG images with proper transparency for the best user experience.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 32767)]
        public string AbsoluteIconPath { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteIconPath property is set.
        /// </summary>
        internal bool IsSetAbsoluteIconPath() => this.AbsoluteIconPath != null;

        /// <summary>
        /// Gets and sets the property AbsoluteManifestPath. 
        /// <para>
        /// The absolute path to the prewarm manifest file for this application. This field is
        /// optional and only applicable when using application-specific manifests. The path can
        /// be 1-32767 characters and should point to a text file containing file paths to prewarm.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 32767)]
        public string AbsoluteManifestPath { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteManifestPath property is set.
        /// </summary>
        internal bool IsSetAbsoluteManifestPath() => this.AbsoluteManifestPath != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name shown to users for this application. This field is optional and can
        /// be 0-100 characters, matching the pattern ^[a-zA-Z0-9][a-zA-Z0-9_. -]{0,99}$.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// The launch parameters to pass to the application executable. This field is optional
        /// and can be 0-1024 characters. Use escaped strings with the full list of required parameters,
        /// such as PowerShell script paths or command-line arguments.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string LaunchParameters { get; set; }

        /// <summary>
        /// Checks to see if the LaunchParameters property is set.
        /// </summary>
        internal bool IsSetLaunchParameters() => this.LaunchParameters != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application. This is a required field that must be unique within the
        /// application catalog and between 1-100 characters, matching the pattern ^[a-zA-Z0-9][a-zA-Z0-9_.-]{0,99}$.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory to use when launching the application. This field is optional
        /// and can be 0-32767 characters. Use escaped file path strings like "C:\\\\Path\\\\To\\\\Working\\\\Directory".
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 32767)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
