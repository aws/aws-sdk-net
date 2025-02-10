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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Object to store union of values for a provisioned cluster or serverless namespace’s
    /// identifier.
    /// </summary>
    public partial class NamespaceIdentifierUnion
    {
        private ProvisionedIdentifier _provisionedIdentifier;
        private ServerlessIdentifier _serverlessIdentifier;

        /// <summary>
        /// Gets and sets the property ProvisionedIdentifier. 
        /// <para>
        /// The identifier for a provisioned cluster.
        /// </para>
        /// </summary>
        public ProvisionedIdentifier ProvisionedIdentifier
        {
            get { return this._provisionedIdentifier; }
            set { this._provisionedIdentifier = value; }
        }

        // Check to see if ProvisionedIdentifier property is set
        internal bool IsSetProvisionedIdentifier()
        {
            return this._provisionedIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessIdentifier. 
        /// <para>
        /// The identifier for a serverless namespace.
        /// </para>
        /// </summary>
        public ServerlessIdentifier ServerlessIdentifier
        {
            get { return this._serverlessIdentifier; }
            set { this._serverlessIdentifier = value; }
        }

        // Check to see if ServerlessIdentifier property is set
        internal bool IsSetServerlessIdentifier()
        {
            return this._serverlessIdentifier != null;
        }

    }
}