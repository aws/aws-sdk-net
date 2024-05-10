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
    /// Container for the parameters to the GetAppsList operation.
    /// Returns information about the specified Firewall Manager applications list.
    /// </summary>
    public partial class GetAppsListRequest : AmazonFMSRequest
    {
        private bool? _defaultList;
        private string _listId;

        /// <summary>
        /// Gets and sets the property DefaultList. 
        /// <para>
        /// Specifies whether the list to retrieve is a default list owned by Firewall Manager.
        /// </para>
        /// </summary>
        public bool? DefaultList
        {
            get { return this._defaultList; }
            set { this._defaultList = value; }
        }

        // Check to see if DefaultList property is set
        internal bool IsSetDefaultList()
        {
            return this._defaultList.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListId. 
        /// <para>
        /// The ID of the Firewall Manager applications list that you want the details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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

    }
}