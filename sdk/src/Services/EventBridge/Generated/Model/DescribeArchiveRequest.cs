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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeArchive operation.
    /// Retrieves details about an archive.
    /// </summary>
    public partial class DescribeArchiveRequest : AmazonEventBridgeRequest
    {
        private string _archiveName;

        /// <summary>
        /// Gets and sets the property ArchiveName. 
        /// <para>
        /// The name of the archive to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string ArchiveName
        {
            get { return this._archiveName; }
            set { this._archiveName = value; }
        }

        // Check to see if ArchiveName property is set
        internal bool IsSetArchiveName()
        {
            return this._archiveName != null;
        }

    }
}