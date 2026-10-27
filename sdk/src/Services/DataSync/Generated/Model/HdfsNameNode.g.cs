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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The NameNode of the Hadoop Distributed File System (HDFS). The NameNode manages the
    /// file system's namespace. The NameNode performs operations such as opening, closing,
    /// and renaming files and directories. The NameNode contains the information to map blocks
    /// of data to the DataNodes.
    /// </summary>
    public partial class HdfsNameNode
    {
        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname of the NameNode in the HDFS cluster. This value is the IP address or
        /// Domain Name Service (DNS) name of the NameNode. An agent that's installed on-premises
        /// uses this hostname to communicate with the NameNode in the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the NameNode uses to listen to client requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
