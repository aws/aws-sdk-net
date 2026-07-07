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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains metadata about a container image associated with a covered resource.
    /// </summary>
    public partial class ContainerImageMetadata
    {
        private DateTime? _imagePulledAt;
        private List<string> _imageTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _inUseCount;
        private DateTime? _lastInUseAt;

        /// <summary>
        /// Gets and sets the property ImagePulledAt. 
        /// <para>
        /// The date and time the container image was pulled.
        /// </para>
        /// </summary>
        public DateTime? ImagePulledAt
        {
            get { return this._imagePulledAt; }
            set { this._imagePulledAt = value; }
        }

        // Check to see if ImagePulledAt property is set
        internal bool IsSetImagePulledAt()
        {
            return this._imagePulledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The tags attached to the container image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && (this._imageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InUseCount. 
        /// <para>
        /// The number of times the container image is in use.
        /// </para>
        /// </summary>
        public long? InUseCount
        {
            get { return this._inUseCount; }
            set { this._inUseCount = value; }
        }

        // Check to see if InUseCount property is set
        internal bool IsSetInUseCount()
        {
            return this._inUseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastInUseAt. 
        /// <para>
        /// The last time the container image was in use.
        /// </para>
        /// </summary>
        public DateTime? LastInUseAt
        {
            get { return this._lastInUseAt; }
            set { this._lastInUseAt = value; }
        }

        // Check to see if LastInUseAt property is set
        internal bool IsSetLastInUseAt()
        {
            return this._lastInUseAt.HasValue; 
        }

    }
}