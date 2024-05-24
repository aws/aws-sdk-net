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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the configuration that App Runner uses to build and run an App Runner service
    /// from a source code repository.
    /// </summary>
    public partial class CodeConfiguration
    {
        private CodeConfigurationValues _codeConfigurationValues;
        private ConfigurationSource _configurationSource;

        /// <summary>
        /// Gets and sets the property CodeConfigurationValues. 
        /// <para>
        /// The basic configuration for building and running the App Runner service. Use it to
        /// quickly launch an App Runner service without providing a <c>apprunner.yaml</c> file
        /// in the source code repository (or ignoring the file if it exists).
        /// </para>
        /// </summary>
        public CodeConfigurationValues CodeConfigurationValues
        {
            get { return this._codeConfigurationValues; }
            set { this._codeConfigurationValues = value; }
        }

        // Check to see if CodeConfigurationValues property is set
        internal bool IsSetCodeConfigurationValues()
        {
            return this._codeConfigurationValues != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSource. 
        /// <para>
        /// The source of the App Runner configuration. Values are interpreted as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REPOSITORY</c> – App Runner reads configuration values from the <c>apprunner.yaml</c>
        /// file in the source code repository and ignores <c>CodeConfigurationValues</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>API</c> – App Runner uses configuration values provided in <c>CodeConfigurationValues</c>
        /// and ignores the <c>apprunner.yaml</c> file in the source code repository.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationSource ConfigurationSource
        {
            get { return this._configurationSource; }
            set { this._configurationSource = value; }
        }

        // Check to see if ConfigurationSource property is set
        internal bool IsSetConfigurationSource()
        {
            return this._configurationSource != null;
        }

    }
}