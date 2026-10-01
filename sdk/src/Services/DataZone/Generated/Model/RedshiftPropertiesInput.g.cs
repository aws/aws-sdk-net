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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon Redshift properties.
    /// </summary>
    public partial class RedshiftPropertiesInput
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The Amaon Redshift credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RedshiftCredentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Amazon Redshift database name.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The Amazon Redshift host.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage sync of the Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftLineageSyncConfigurationInput LineageSync { get; set; }

        /// <summary>
        /// Checks to see if the LineageSync property is set.
        /// </summary>
        internal bool IsSetLineageSync() => this.LineageSync != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The Amaon Redshift port.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The Amazon Redshift storage.
        /// </para>
        /// </summary>
        public RedshiftStorageProperties Storage { get; set; }

        /// <summary>
        /// Checks to see if the Storage property is set.
        /// </summary>
        internal bool IsSetStorage() => this.Storage != null;
    }
}
