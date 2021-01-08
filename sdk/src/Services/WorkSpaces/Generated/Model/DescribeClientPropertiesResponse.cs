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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeClientProperties operation.
    /// </summary>
    public partial class DescribeClientPropertiesResponse : AmazonWebServiceResponse
    {
        private List<ClientPropertiesResult> _clientPropertiesList = new List<ClientPropertiesResult>();

        /// <summary>
        /// Gets and sets the property ClientPropertiesList. 
        /// <para>
        /// Information about the specified Amazon WorkSpaces clients.
        /// </para>
        /// </summary>
        public List<ClientPropertiesResult> ClientPropertiesList
        {
            get { return this._clientPropertiesList; }
            set { this._clientPropertiesList = value; }
        }

        // Check to see if ClientPropertiesList property is set
        internal bool IsSetClientPropertiesList()
        {
            return this._clientPropertiesList != null && this._clientPropertiesList.Count > 0; 
        }

    }
}