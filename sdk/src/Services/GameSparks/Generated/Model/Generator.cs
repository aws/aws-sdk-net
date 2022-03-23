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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Properties that specify the code generator for a generated code job.
    /// </summary>
    public partial class Generator
    {
        private string _gameSdkVersion;
        private string _language;
        private string _targetPlatform;

        /// <summary>
        /// Gets and sets the property GameSdkVersion. 
        /// <para>
        /// The target version of the GameSparks Game SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=10)]
        public string GameSdkVersion
        {
            get { return this._gameSdkVersion; }
            set { this._gameSdkVersion = value; }
        }

        // Check to see if GameSdkVersion property is set
        internal bool IsSetGameSdkVersion()
        {
            return this._gameSdkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The programming language for the generated code.
        /// </para>
        ///  
        /// <para>
        ///  Not all languages are supported for each platform. For cases where multiple languages
        /// are supported, this parameter specifies the language to be used. If this value is
        /// omitted, the default language for the target platform will be used. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPlatform. 
        /// <para>
        /// The platform that will be used to run the generated code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string TargetPlatform
        {
            get { return this._targetPlatform; }
            set { this._targetPlatform = value; }
        }

        // Check to see if TargetPlatform property is set
        internal bool IsSetTargetPlatform()
        {
            return this._targetPlatform != null;
        }

    }
}