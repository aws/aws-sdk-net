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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters that are required to connect to a Starburst data source.
    /// </summary>
    public partial class StarburstParameters
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type that you want to use for your connection. This parameter accepts
        /// OAuth and non-OAuth authentication types.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog name for the Starburst data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property DatabaseAccessControlRole. 
        /// <para>
        /// The database access control role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DatabaseAccessControlRole { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseAccessControlRole property is set.
        /// </summary>
        internal bool IsSetDatabaseAccessControlRole() => this.DatabaseAccessControlRole != null;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The host name of the Starburst data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property OAuthParameters. 
        /// <para>
        /// An object that contains information needed to create a data source connection between
        /// an Quick Sight account and Starburst.
        /// </para>
        /// </summary>
        public OAuthParameters OAuthParameters { get; set; }

        /// <summary>
        /// Checks to see if the OAuthParameters property is set.
        /// </summary>
        internal bool IsSetOAuthParameters() => this.OAuthParameters != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port for the Starburst data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The product type for the Starburst data source.
        /// </para>
        /// </summary>
        public StarburstProductType ProductType { get; set; }

        /// <summary>
        /// Checks to see if the ProductType property is set.
        /// </summary>
        internal bool IsSetProductType() => this.ProductType != null;
    }
}
