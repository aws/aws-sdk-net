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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// This is the response object from the DisassociateNode operation.
    /// </summary>
    public partial class DisassociateNodeResponse : AmazonWebServiceResponse
    {
        private string _nodeAssociationStatusToken;

        /// <summary>
        /// Gets and sets the property NodeAssociationStatusToken. 
        /// <para>
        /// Contains a token which can be passed to the <code>DescribeNodeAssociationStatus</code>
        /// API call to get the status of the disassociation request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string NodeAssociationStatusToken
        {
            get { return this._nodeAssociationStatusToken; }
            set { this._nodeAssociationStatusToken = value; }
        }

        // Check to see if NodeAssociationStatusToken property is set
        internal bool IsSetNodeAssociationStatusToken()
        {
            return this._nodeAssociationStatusToken != null;
        }

    }
}