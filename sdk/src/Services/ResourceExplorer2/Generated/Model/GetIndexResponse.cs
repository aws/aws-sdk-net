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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// This is the response object from the GetIndex operation.
    /// </summary>
    public partial class GetIndexResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private List<string> _replicatingFrom = new List<string>();
        private List<string> _replicatingTo = new List<string>();
        private IndexState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private IndexType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the index.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the index was originally created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the index was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicatingFrom. 
        /// <para>
        /// This response value is present only if this index is <code>Type=AGGREGATOR</code>.
        /// </para>
        ///  
        /// <para>
        /// A list of the Amazon Web Services Regions that replicate their content to the index
        /// in this Region.
        /// </para>
        /// </summary>
        public List<string> ReplicatingFrom
        {
            get { return this._replicatingFrom; }
            set { this._replicatingFrom = value; }
        }

        // Check to see if ReplicatingFrom property is set
        internal bool IsSetReplicatingFrom()
        {
            return this._replicatingFrom != null && this._replicatingFrom.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicatingTo. 
        /// <para>
        /// This response value is present only if this index is <code>Type=LOCAL</code>.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services Region that contains the aggregator index, if one exists.
        /// If an aggregator index does exist then the Region in which you called this operation
        /// replicates its index information to the Region specified in this response value. 
        /// </para>
        /// </summary>
        public List<string> ReplicatingTo
        {
            get { return this._replicatingTo; }
            set { this._replicatingTo = value; }
        }

        // Check to see if ReplicatingTo property is set
        internal bool IsSetReplicatingTo()
        {
            return this._replicatingTo != null && this._replicatingTo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the index in this Amazon Web Services Region.
        /// </para>
        /// </summary>
        public IndexState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tag key and value pairs that are attached to the index.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the index in this Region. For information about the aggregator index and
        /// how it differs from a local index, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">Turning
        /// on cross-Region search by creating an aggregator index</a>.
        /// </para>
        /// </summary>
        public IndexType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}