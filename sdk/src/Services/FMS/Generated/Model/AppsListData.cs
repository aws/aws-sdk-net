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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// An AWS Firewall Manager applications list.
    /// </summary>
    public partial class AppsListData
    {
        private List<App> _appsList = new List<App>();
        private DateTime? _createTime;
        private DateTime? _lastUpdateTime;
        private string _listId;
        private string _listName;
        private string _listUpdateToken;
        private Dictionary<string, List<App>> _previousAppsList = new Dictionary<string, List<App>>();

        /// <summary>
        /// Gets and sets the property AppsList. 
        /// <para>
        /// An array of applications in the AWS Firewall Manager applications list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<App> AppsList
        {
            get { return this._appsList; }
            set { this._appsList = value; }
        }

        // Check to see if AppsList property is set
        internal bool IsSetAppsList()
        {
            return this._appsList != null && this._appsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the AWS Firewall Manager applications list was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
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
        /// The time that the AWS Firewall Manager applications list was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
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
        /// The ID of the AWS Firewall Manager applications list.
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
        /// The name of the AWS Firewall Manager applications list.
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
        /// Gets and sets the property PreviousAppsList. 
        /// <para>
        /// A map of previous version numbers to their corresponding <code>App</code> object arrays.
        /// </para>
        /// </summary>
        public Dictionary<string, List<App>> PreviousAppsList
        {
            get { return this._previousAppsList; }
            set { this._previousAppsList = value; }
        }

        // Check to see if PreviousAppsList property is set
        internal bool IsSetPreviousAppsList()
        {
            return this._previousAppsList != null && this._previousAppsList.Count > 0; 
        }

    }
}