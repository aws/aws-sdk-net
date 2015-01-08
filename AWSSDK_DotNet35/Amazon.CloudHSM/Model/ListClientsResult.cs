/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListClientsResult : AmazonWebServiceResponse
    {
        private List<string> _clientList = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientList.
        /// </summary>
        public List<string> ClientList
        {
            get { return this._clientList; }
            set { this._clientList = value; }
        }

        // Check to see if ClientList property is set
        internal bool IsSetClientList()
        {
            return this._clientList != null && this._clientList.Count > 0; 
        }

    }
}