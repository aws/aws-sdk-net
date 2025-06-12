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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// An Firewall Manager protocols list.
    /// </summary>
    public partial class ProtocolsListData
    {
        private DateTime? _createTime;
        private DateTime? _lastUpdateTime;
        private string _listId;
        private string _listName;
        private string _listUpdateToken;
        private Dictionary<string, List<string>> _previousProtocolsList = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private List<string> _protocolsList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the Firewall Manager protocols list was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time that the Firewall Manager protocols list was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListId. 
        /// <para>
        /// The ID of the Firewall Manager protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ListId
        {
            get { return this._listId; }
            set { this._listId = value; }
        }

        // Check to see if ListId property is set
        internal bool IsSetListId()
        {
            return this._listId != null;
        }

        /// <summary>
        /// Gets and sets the property ListName. 
        /// <para>
        /// The name of the Firewall Manager protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ListName
        {
            get { return this._listName; }
            set { this._listName = value; }
        }

        // Check to see if ListName property is set
        internal bool IsSetListName()
        {
            return this._listName != null;
        }

        /// <summary>
        /// Gets and sets the property ListUpdateToken. 
        /// <para>
        /// A unique identifier for each update to the list. When you update the list, the update
        /// token must match the token of the current version of the application list. You can
        /// retrieve the update token by getting the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ListUpdateToken
        {
            get { return this._listUpdateToken; }
            set { this._listUpdateToken = value; }
        }

        // Check to see if ListUpdateToken property is set
        internal bool IsSetListUpdateToken()
        {
            return this._listUpdateToken != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousProtocolsList. 
        /// <para>
        /// A map of previous version numbers to their corresponding protocol arrays.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> PreviousProtocolsList
        {
            get { return this._previousProtocolsList; }
            set { this._previousProtocolsList = value; }
        }

        // Check to see if PreviousProtocolsList property is set
        internal bool IsSetPreviousProtocolsList()
        {
            return this._previousProtocolsList != null && (this._previousProtocolsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProtocolsList. 
        /// <para>
        /// An array of protocols in the Firewall Manager protocols list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ProtocolsList
        {
            get { return this._protocolsList; }
            set { this._protocolsList = value; }
        }

        // Check to see if ProtocolsList property is set
        internal bool IsSetProtocolsList()
        {
            return this._protocolsList != null && (this._protocolsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}