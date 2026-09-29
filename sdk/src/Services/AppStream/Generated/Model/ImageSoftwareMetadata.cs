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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
    /// Describes the software metadata for an image, such as the installed NVIDIA GRID driver
    /// version.
    /// </summary>
    public partial class ImageSoftwareMetadata
    {
        private string _nvidiaGridDriverVersion;

        /// <summary>
        /// Gets and sets the property NvidiaGridDriverVersion. 
        /// <para>
        /// The version of the NVIDIA GRID driver installed on the image. This field is empty
        /// if no NVIDIA GRID driver is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NvidiaGridDriverVersion
        {
            get { return this._nvidiaGridDriverVersion; }
            set { this._nvidiaGridDriverVersion = value; }
        }

        // Check to see if NvidiaGridDriverVersion property is set
        internal bool IsSetNvidiaGridDriverVersion()
        {
            return this._nvidiaGridDriverVersion != null;
        }

    }
}