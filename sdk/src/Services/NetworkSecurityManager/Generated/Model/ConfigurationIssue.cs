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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Describes a single configuration value that does not match the intended configuration.
    /// </summary>
    public partial class ConfigurationIssue
    {
        private string _actualValue;
        private string _configurationName;
        private string _expectedValue;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The configuration value that was found on the resource.
        /// </para>
        /// </summary>
        public string ActualValue
        {
            get { return this._actualValue; }
            set { this._actualValue = value; }
        }

        // Check to see if ActualValue property is set
        internal bool IsSetActualValue()
        {
            return this._actualValue != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// The name of the configuration setting that is in conflict.
        /// </para>
        /// </summary>
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedValue. 
        /// <para>
        /// The configuration value that AWS Network Security Manager expected.
        /// </para>
        /// </summary>
        public string ExpectedValue
        {
            get { return this._expectedValue; }
            set { this._expectedValue = value; }
        }

        // Check to see if ExpectedValue property is set
        internal bool IsSetExpectedValue()
        {
            return this._expectedValue != null;
        }

    }
}