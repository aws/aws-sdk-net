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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides details of Amazon Security Lake object.
    /// </summary>
    public partial class DataLakeConfiguration
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Provides encryption details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeEncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LifecycleConfiguration. 
        /// <para>
        /// Provides lifecycle details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeLifecycleConfiguration LifecycleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfiguration property is set.
        /// </summary>
        internal bool IsSetLifecycleConfiguration() => this.LifecycleConfiguration != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Regions where Security Lake is automatically enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfiguration. 
        /// <para>
        /// Provides replication details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeReplicationConfiguration ReplicationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfiguration property is set.
        /// </summary>
        internal bool IsSetReplicationConfiguration() => this.ReplicationConfiguration != null;
    }
}
