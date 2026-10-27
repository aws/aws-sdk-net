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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyspace operation. The <c>CreateKeyspace</c>
    /// operation adds a new keyspace to your account. In an Amazon Web Services account,
    /// keyspace names must be unique within each Region. <para> <c>CreateKeyspace</c> is
    /// an asynchronous operation. You can monitor the creation status of the new keyspace
    /// by using the <c>GetKeyspace</c> operation. </para> <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.keyspaces.html">Create
    /// a keyspace</a> in the <i>Amazon Keyspaces Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateKeyspaceRequest : AmazonKeyspacesRequest
    {
        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property ReplicationSpecification. 
        /// <para>
        ///  The replication specification of the keyspace includes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>replicationStrategy</c> - the required value is <c>SINGLE_REGION</c> or <c>MULTI_REGION</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>regionList</c> - if the <c>replicationStrategy</c> is <c>MULTI_REGION</c>, the
        /// <c>regionList</c> requires the current Region and at least one additional Amazon Web
        /// Services Region where the keyspace is going to be replicated in.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplicationSpecification ReplicationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSpecification property is set.
        /// </summary>
        internal bool IsSetReplicationSpecification() => this.ReplicationSpecification != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pair tags to be attached to the keyspace.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
        /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
