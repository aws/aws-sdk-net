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
    /// Container for the parameters to the GetConfig operation.
    /// Gets the configuration files necessary to connect to all high availability partition
    /// groups the client is associated with.
    /// </summary>
    public partial class GetConfigRequest : AmazonCloudHSMRequest
    {
        private string _clientArn;
        private ClientVersion _clientVersion;
        private List<string> _hapgList = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientArn. 
        /// <para>
        /// The ARN of the client.
        /// </para>
        /// </summary>
        public string ClientArn
        {
            get { return this._clientArn; }
            set { this._clientArn = value; }
        }

        // Check to see if ClientArn property is set
        internal bool IsSetClientArn()
        {
            return this._clientArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVersion. 
        /// <para>
        /// The client version.
        /// </para>
        /// </summary>
        public ClientVersion ClientVersion
        {
            get { return this._clientVersion; }
            set { this._clientVersion = value; }
        }

        // Check to see if ClientVersion property is set
        internal bool IsSetClientVersion()
        {
            return this._clientVersion != null;
        }

        /// <summary>
        /// Gets and sets the property HapgList. 
        /// <para>
        /// A list of ARNs that identify the high-availability partition groups that are associated
        /// with the client.
        /// </para>
        /// </summary>
        public List<string> HapgList
        {
            get { return this._hapgList; }
            set { this._hapgList = value; }
        }

        // Check to see if HapgList property is set
        internal bool IsSetHapgList()
        {
            return this._hapgList != null && this._hapgList.Count > 0; 
        }

    }
}