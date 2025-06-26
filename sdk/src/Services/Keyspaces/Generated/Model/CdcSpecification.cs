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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The settings for the CDC stream of a table. For more information about CDC streams,
    /// see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cdc.html">Working
    /// with change data capture (CDC) streams in Amazon Keyspaces</a> in the <i>Amazon Keyspaces
    /// Developer Guide</i>.
    /// </summary>
    public partial class CdcSpecification
    {
        private CdcPropagateTags _propagateTags;
        private CdcStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ViewType _viewType;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies that the stream inherits the tags from the table.
        /// </para>
        /// </summary>
        public CdcPropagateTags PropagateTags
        {
            get { return this._propagateTags; }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the CDC stream. You can enable or disable a stream for a table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CdcStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags (key-value pairs) that you want to apply to the stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ViewType. 
        /// <para>
        /// The view type specifies the changes Amazon Keyspaces records for each changed row
        /// in the stream. After you create the stream, you can't make changes to this selection.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW_AND_OLD_IMAGES</c> - both versions of the row, before and after the change.
        /// This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_IMAGE</c> - the version of the row after the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OLD_IMAGE</c> - the version of the row before the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - the partition and clustering keys of the row that was changed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ViewType ViewType
        {
            get { return this._viewType; }
            set { this._viewType = value; }
        }

        // Check to see if ViewType property is set
        internal bool IsSetViewType()
        {
            return this._viewType != null;
        }

    }
}