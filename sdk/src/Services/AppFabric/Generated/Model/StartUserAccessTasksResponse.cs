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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// This is the response object from the StartUserAccessTasks operation.
    /// </summary>
    public partial class StartUserAccessTasksResponse : AmazonWebServiceResponse
    {
        private List<UserAccessTaskItem> _userAccessTasksList = new List<UserAccessTaskItem>();

        /// <summary>
        /// Gets and sets the property UserAccessTasksList. 
        /// <para>
        /// Contains a list of user access task information.
        /// </para>
        /// </summary>
        public List<UserAccessTaskItem> UserAccessTasksList
        {
            get { return this._userAccessTasksList; }
            set { this._userAccessTasksList = value; }
        }

        // Check to see if UserAccessTasksList property is set
        internal bool IsSetUserAccessTasksList()
        {
            return this._userAccessTasksList != null && this._userAccessTasksList.Count > 0; 
        }

    }
}