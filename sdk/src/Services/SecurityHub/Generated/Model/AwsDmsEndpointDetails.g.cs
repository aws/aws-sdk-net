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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Database Migration Service (DMS) endpoint. An endpoint
    /// provides connection, data store type, and location information about your data store.
    /// </summary>
    public partial class AwsDmsEndpointDetails
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the SSL certificate that encrypts connections
        /// between the DMS endpoint and the replication instance. 
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the endpoint database.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the endpoint. 
        /// </para>
        /// </summary>
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        ///  The database endpoint identifier. 
        /// </para>
        /// </summary>
        public string EndpointIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIdentifier property is set.
        /// </summary>
        internal bool IsSetEndpointIdentifier() => this.EndpointIdentifier != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        ///  The type of endpoint. Valid values are source and target. 
        /// </para>
        /// </summary>
        public string EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        ///  The type of engine for the endpoint, depending on the <c>EndpointType</c> value.
        /// 
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        ///  A value that can be used for cross-account validation. 
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property ExtraConnectionAttributes. 
        /// <para>
        ///  Additional attributes associated with the connection. 
        /// </para>
        /// </summary>
        public string ExtraConnectionAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ExtraConnectionAttributes property is set.
        /// </summary>
        internal bool IsSetExtraConnectionAttributes() => this.ExtraConnectionAttributes != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  An DMS key identifier that is used to encrypt the connection parameters for the endpoint.
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then DMS uses your
        /// default encryption key. KMS creates the default encryption key for your Amazon Web
        /// Services account. Your Amazon Web Services account has a different default encryption
        /// key for each Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port used to access the endpoint. 
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        ///  The name of the server where the endpoint database resides.
        /// </para>
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property SslMode. 
        /// <para>
        ///  The SSL mode used to connect to the endpoint. The default is none.
        /// </para>
        /// </summary>
        public string SslMode { get; set; }

        /// <summary>
        /// Checks to see if the SslMode property is set.
        /// </summary>
        internal bool IsSetSslMode() => this.SslMode != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        ///  The user name to be used to log in to the endpoint database. 
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
