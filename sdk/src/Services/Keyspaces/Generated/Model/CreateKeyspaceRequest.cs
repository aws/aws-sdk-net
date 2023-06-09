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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyspace operation.
    /// The <code>CreateKeyspace</code> operation adds a new keyspace to your account. In
    /// an Amazon Web Services account, keyspace names must be unique within each Region.
    /// 
    ///  
    /// <para>
    ///  <code>CreateKeyspace</code> is an asynchronous operation. You can monitor the creation
    /// status of the new keyspace by using the <code>GetKeyspace</code> operation.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/working-with-keyspaces.html#keyspaces-create">Creating
    /// keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateKeyspaceRequest : AmazonKeyspacesRequest
    {
        private string _keyspaceName;
        private ReplicationSpecification _replicationSpecification;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSpecification. 
        /// <para>
        ///  The replication specification of the keyspace includes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>replicationStrategy</code> - the required value is <code>SINGLE_REGION</code>
        /// or <code>MULTI_REGION</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>regionList</code> - if the <code>replicationStrategy</code> is <code>MULTI_REGION</code>,
        /// the <code>regionList</code> requires the current Region and at least one additional
        /// Amazon Web Services Region where the keyspace is going to be replicated in. The maximum
        /// number of supported replication Regions including the current Region is six.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplicationSpecification ReplicationSpecification
        {
            get { return this._replicationSpecification; }
            set { this._replicationSpecification = value; }
        }

        // Check to see if ReplicationSpecification property is set
        internal bool IsSetReplicationSpecification()
        {
            return this._replicationSpecification != null;
        }

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
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}