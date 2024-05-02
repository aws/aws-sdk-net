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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Source Server connector action.
    /// </summary>
    public partial class SourceServerConnectorAction
    {
        private string _connectorArn;
        private string _credentialsSecretArn;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// Source Server connector action connector arn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=27, Max=100)]
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsSecretArn. 
        /// <para>
        /// Source Server connector action credentials secret arn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=100)]
        public string CredentialsSecretArn
        {
            get { return this._credentialsSecretArn; }
            set { this._credentialsSecretArn = value; }
        }

        // Check to see if CredentialsSecretArn property is set
        internal bool IsSetCredentialsSecretArn()
        {
            return this._credentialsSecretArn != null;
        }

    }
}