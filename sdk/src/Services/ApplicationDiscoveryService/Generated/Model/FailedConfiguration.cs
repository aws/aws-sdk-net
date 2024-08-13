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
    /// A configuration ID paired with an error message.
    /// </summary>
    public partial class FailedConfiguration
    {
        private string _configurationId;
        private string _errorMessage;
        private int? _errorStatusCode;

        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        ///  The unique identifier of the configuration the failed to delete. 
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  A descriptive message indicating why the associated configuration failed to delete.
        /// 
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorStatusCode. 
        /// <para>
        ///  The integer error code associated with the error message. 
        /// </para>
        /// </summary>
        public int? ErrorStatusCode
        {
            get { return this._errorStatusCode; }
            set { this._errorStatusCode = value; }
        }

        // Check to see if ErrorStatusCode property is set
        internal bool IsSetErrorStatusCode()
        {
            return this._errorStatusCode.HasValue; 
        }

    }
}