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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The environment configuration for a notebook run in Amazon DataZone.
    /// </summary>
    public partial class EnvironmentConfig
    {
        private string _imageVersion;
        private PackageConfig _packageConfig;

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The image version for the notebook run environment.
        /// </para>
        /// </summary>
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PackageConfig. 
        /// <para>
        /// The package configuration for the notebook run environment.
        /// </para>
        /// </summary>
        public PackageConfig PackageConfig
        {
            get { return this._packageConfig; }
            set { this._packageConfig = value; }
        }

        // Check to see if PackageConfig property is set
        internal bool IsSetPackageConfig()
        {
            return this._packageConfig != null;
        }

    }
}