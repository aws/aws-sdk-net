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
    /// This is the response object from the GetProtocolsList operation.
    /// </summary>
    public partial class GetProtocolsListResponse : AmazonWebServiceResponse
    {
        private ProtocolsListData _protocolsList;
        private string _protocolsListArn;

        /// <summary>
        /// Gets and sets the property ProtocolsList. 
        /// <para>
        /// Information about the specified Firewall Manager protocols list.
        /// </para>
        /// </summary>
        public ProtocolsListData ProtocolsList
        {
            get { return this._protocolsList; }
            set { this._protocolsList = value; }
        }

        // Check to see if ProtocolsList property is set
        internal bool IsSetProtocolsList()
        {
            return this._protocolsList != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolsListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ProtocolsListArn
        {
            get { return this._protocolsListArn; }
            set { this._protocolsListArn = value; }
        }

        // Check to see if ProtocolsListArn property is set
        internal bool IsSetProtocolsListArn()
        {
            return this._protocolsListArn != null;
        }

    }
}