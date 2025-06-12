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
    /// Details of the Firewall Manager protocols list.
    /// </summary>
    public partial class ProtocolsListDataSummary
    {
        private string _listArn;
        private string _listId;
        private string _listName;
        private List<string> _protocolsList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ListArn
        {
            get { return this._listArn; }
            set { this._listArn = value; }
        }

        // Check to see if ListArn property is set
        internal bool IsSetListArn()
        {
            return this._listArn != null;
        }

        /// <summary>
        /// Gets and sets the property ListId. 
        /// <para>
        /// The ID of the specified protocols list.
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
        /// The name of the specified protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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