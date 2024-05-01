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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The Quality of Protection (QOP) configuration specifies the Remote Procedure Call
    /// (RPC) and data transfer privacy settings configured on the Hadoop Distributed File
    /// System (HDFS) cluster.
    /// </summary>
    public partial class QopConfiguration
    {
        private HdfsDataTransferProtection _dataTransferProtection;
        private HdfsRpcProtection _rpcProtection;

        /// <summary>
        /// Gets and sets the property DataTransferProtection. 
        /// <para>
        /// The data transfer protection setting configured on the HDFS cluster. This setting
        /// corresponds to your <c>dfs.data.transfer.protection</c> setting in the <c>hdfs-site.xml</c>
        /// file on your Hadoop cluster.
        /// </para>
        /// </summary>
        public HdfsDataTransferProtection DataTransferProtection
        {
            get { return this._dataTransferProtection; }
            set { this._dataTransferProtection = value; }
        }

        // Check to see if DataTransferProtection property is set
        internal bool IsSetDataTransferProtection()
        {
            return this._dataTransferProtection != null;
        }

        /// <summary>
        /// Gets and sets the property RpcProtection. 
        /// <para>
        /// The RPC protection setting configured on the HDFS cluster. This setting corresponds
        /// to your <c>hadoop.rpc.protection</c> setting in your <c>core-site.xml</c> file on
        /// your Hadoop cluster.
        /// </para>
        /// </summary>
        public HdfsRpcProtection RpcProtection
        {
            get { return this._rpcProtection; }
            set { this._rpcProtection = value; }
        }

        // Check to see if RpcProtection property is set
        internal bool IsSetRpcProtection()
        {
            return this._rpcProtection != null;
        }

    }
}