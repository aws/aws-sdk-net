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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConditionalForwarders operation.
    /// Obtains information about the conditional forwarders for this account.
    /// 
    ///  
    /// <para>
    /// If no input parameters are provided for RemoteDomainNames, this request describes
    /// all conditional forwarders for the specified directory ID.
    /// </para>
    /// </summary>
    public partial class DescribeConditionalForwardersRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private List<string> _remoteDomainNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID for which to get the list of associated conditional forwarders.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainNames. 
        /// <para>
        /// The fully qualified domain names (FQDN) of the remote domains for which to get the
        /// list of associated conditional forwarders. If this member is null, all conditional
        /// forwarders are returned.
        /// </para>
        /// </summary>
        public List<string> RemoteDomainNames
        {
            get { return this._remoteDomainNames; }
            set { this._remoteDomainNames = value; }
        }

        // Check to see if RemoteDomainNames property is set
        internal bool IsSetRemoteDomainNames()
        {
            return this._remoteDomainNames != null && this._remoteDomainNames.Count > 0; 
        }

    }
}