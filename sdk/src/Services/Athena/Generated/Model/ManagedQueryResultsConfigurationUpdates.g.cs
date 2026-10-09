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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Updates the configuration for managed query results.
    /// </summary>
    public partial class ManagedQueryResultsConfigurationUpdates
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If set to true, specifies that Athena manages query results in Athena owned storage.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// If you encrypt query and calculation results in Athena owned storage, this field indicates
        /// the encryption option (for example, SSE_KMS or CSE_KMS) and key information.
        /// </para>
        /// </summary>
        public ManagedQueryResultsEncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property RemoveEncryptionConfiguration. 
        /// <para>
        /// If set to true, it removes workgroup from Athena owned storage. The existing query
        /// results are cleaned up after 24hrs. You must provide query results in location specified
        /// under <c>ResultConfiguration$OutputLocation</c>.
        /// </para>
        /// </summary>
        public bool? RemoveEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveEncryptionConfiguration() => this.RemoveEncryptionConfiguration.HasValue;
    }
}
