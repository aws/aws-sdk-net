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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveIpRoutes operation.
    /// Removes IP address blocks from a directory.
    /// </summary>
    public partial class RemoveIpRoutesRequest : AmazonDirectoryServiceRequest
    {
        private List<string> _cidrIps = new List<string>();
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property CidrIps. 
        /// <para>
        /// IP address blocks that you want to remove.
        /// </para>
        /// </summary>
        public List<string> CidrIps
        {
            get { return this._cidrIps; }
            set { this._cidrIps = value; }
        }

        // Check to see if CidrIps property is set
        internal bool IsSetCidrIps()
        {
            return this._cidrIps != null && this._cidrIps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier (ID) of the directory from which you want to remove the IP addresses.
        /// </para>
        /// </summary>
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

    }
}