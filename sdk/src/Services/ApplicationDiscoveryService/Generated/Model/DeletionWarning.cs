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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// A configuration ID paired with a warning message.
    /// </summary>
    public partial class DeletionWarning
    {
        private string _configurationId;
        private int? _warningCode;
        private string _warningText;

        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        ///  The unique identifier of the configuration that produced a warning. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string ConfigurationId
        {
            get { return this._configurationId; }
            set { this._configurationId = value; }
        }

        // Check to see if ConfigurationId property is set
        internal bool IsSetConfigurationId()
        {
            return this._configurationId != null;
        }

        /// <summary>
        /// Gets and sets the property WarningCode. 
        /// <para>
        ///  The integer warning code associated with the warning message. 
        /// </para>
        /// </summary>
        public int? WarningCode
        {
            get { return this._warningCode; }
            set { this._warningCode = value; }
        }

        // Check to see if WarningCode property is set
        internal bool IsSetWarningCode()
        {
            return this._warningCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarningText. 
        /// <para>
        ///  A descriptive message of the warning the associated configuration ID produced. 
        /// </para>
        /// </summary>
        public string WarningText
        {
            get { return this._warningText; }
            set { this._warningText = value; }
        }

        // Check to see if WarningText property is set
        internal bool IsSetWarningText()
        {
            return this._warningText != null;
        }

    }
}