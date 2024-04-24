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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// This is the response object from the GetConfig operation.
    /// </summary>
    public partial class GetConfigResponse : AmazonWebServiceResponse
    {
        private string _configCred;
        private string _configFile;
        private string _configType;

        /// <summary>
        /// Gets and sets the property ConfigCred. 
        /// <para>
        /// The certificate file containing the server.pem files of the HSMs.
        /// </para>
        /// </summary>
        public string ConfigCred
        {
            get { return this._configCred; }
            set { this._configCred = value; }
        }

        // Check to see if ConfigCred property is set
        internal bool IsSetConfigCred()
        {
            return this._configCred != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigFile. 
        /// <para>
        /// The chrystoki.conf configuration file.
        /// </para>
        /// </summary>
        public string ConfigFile
        {
            get { return this._configFile; }
            set { this._configFile = value; }
        }

        // Check to see if ConfigFile property is set
        internal bool IsSetConfigFile()
        {
            return this._configFile != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigType. 
        /// <para>
        /// The type of credentials.
        /// </para>
        /// </summary>
        public string ConfigType
        {
            get { return this._configType; }
            set { this._configType = value; }
        }

        // Check to see if ConfigType property is set
        internal bool IsSetConfigType()
        {
            return this._configType != null;
        }

    }
}