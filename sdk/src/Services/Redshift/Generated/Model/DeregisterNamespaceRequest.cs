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
    /// Container for the parameters to the DeregisterNamespace operation.
    /// Deregisters a cluster or serverless namespace from the Amazon Web Services Glue Data
    /// Catalog.
    /// </summary>
    public partial class DeregisterNamespaceRequest : AmazonRedshiftRequest
    {
        private List<string> _consumerIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NamespaceIdentifierUnion _namespaceIdentifier;

        /// <summary>
        /// Gets and sets the property ConsumerIdentifiers. 
        /// <para>
        /// An array containing the ID of the consumer account that you want to deregister the
        /// cluster or serverless namespace from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> ConsumerIdentifiers
        {
            get { return this._consumerIdentifiers; }
            set { this._consumerIdentifiers = value; }
        }

        // Check to see if ConsumerIdentifiers property is set
        internal bool IsSetConsumerIdentifiers()
        {
            return this._consumerIdentifiers != null && (this._consumerIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamespaceIdentifier. 
        /// <para>
        /// The unique identifier of the cluster or serverless namespace that you want to deregister.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NamespaceIdentifierUnion NamespaceIdentifier
        {
            get { return this._namespaceIdentifier; }
            set { this._namespaceIdentifier = value; }
        }

        // Check to see if NamespaceIdentifier property is set
        internal bool IsSetNamespaceIdentifier()
        {
            return this._namespaceIdentifier != null;
        }

    }
}