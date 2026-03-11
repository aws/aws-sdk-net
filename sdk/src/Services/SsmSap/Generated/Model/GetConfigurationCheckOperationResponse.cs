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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// This is the response object from the GetConfigurationCheckOperation operation.
    /// </summary>
    public partial class GetConfigurationCheckOperationResponse : AmazonWebServiceResponse
    {
        private ConfigurationCheckOperation _configurationCheckOperation;

        /// <summary>
        /// Gets and sets the property ConfigurationCheckOperation. 
        /// <para>
        /// Returns the details of a configuration check operation.
        /// </para>
        /// </summary>
        public ConfigurationCheckOperation ConfigurationCheckOperation
        {
            get { return this._configurationCheckOperation; }
            set { this._configurationCheckOperation = value; }
        }

        // Check to see if ConfigurationCheckOperation property is set
        internal bool IsSetConfigurationCheckOperation()
        {
            return this._configurationCheckOperation != null;
        }

    }
}