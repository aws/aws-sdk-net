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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshot operation.
    /// Creates a snapshot of an existing Amazon FSx for OpenZFS volume. With snapshots, you
    /// can easily undo file changes and compare file versions by restoring the volume to
    /// a previous version.
    /// 
    ///  
    /// <para>
    /// If a snapshot with the specified client request token exists, and the parameters match,
    /// this operation returns the description of the existing snapshot. If a snapshot with
    /// the specified client request token exists, and the parameters don't match, this operation
    /// returns <c>IncompatibleParameterError</c>. If a snapshot with the specified client
    /// request token doesn't exist, <c>CreateSnapshot</c> does the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new OpenZFS snapshot with an assigned ID, and an initial lifecycle state
    /// of <c>CREATING</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the snapshot.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// By using the idempotent operation, you can retry a <c>CreateSnapshot</c> operation
    /// without the risk of creating an extra snapshot. This approach can be useful when an
    /// initial call fails in a way that makes it unclear whether a snapshot was created.
    /// If you use the same client request token and the initial call created a snapshot,
    /// the operation returns a successful result because all the parameters are the same.
    /// </para>
    ///  
    /// <para>
    /// The <c>CreateSnapshot</c> operation returns while the snapshot's lifecycle state is
    /// still <c>CREATING</c>. You can check the snapshot creation status by calling the <a
    /// href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
    /// operation, which returns the snapshot state along with other information.
    /// </para>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the snapshot. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=203)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that you are taking a snapshot of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=23, Max=23)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}