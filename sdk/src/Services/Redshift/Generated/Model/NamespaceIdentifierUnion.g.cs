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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ProvisionedIdentifier. 
        /// <para>
        /// The identifier for a provisioned cluster.
        /// </para>
        /// </summary>
        public ProvisionedIdentifier ProvisionedIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedIdentifier property is set.
        /// </summary>
        internal bool IsSetProvisionedIdentifier() => this.ProvisionedIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServerlessIdentifier. 
        /// <para>
        /// The identifier for a serverless namespace.
        /// </para>
        /// </summary>
        public ServerlessIdentifier ServerlessIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessIdentifier property is set.
        /// </summary>
        internal bool IsSetServerlessIdentifier() => this.ServerlessIdentifier != null;
    }
}
