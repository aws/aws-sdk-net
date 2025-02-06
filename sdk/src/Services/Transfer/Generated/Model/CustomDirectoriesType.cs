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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains Amazon S3 locations for storing specific types of AS2 message files.
    /// </summary>
    public partial class CustomDirectoriesType
    {
        private string _failedFilesDirectory;
        private string _mdnFilesDirectory;
        private string _payloadFilesDirectory;
        private string _statusFilesDirectory;
        private string _temporaryFilesDirectory;

        /// <summary>
        /// Gets and sets the property FailedFilesDirectory. 
        /// <para>
        /// Specifies a location to store failed AS2 message files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string FailedFilesDirectory
        {
            get { return this._failedFilesDirectory; }
            set { this._failedFilesDirectory = value; }
        }

        // Check to see if FailedFilesDirectory property is set
        internal bool IsSetFailedFilesDirectory()
        {
            return this._failedFilesDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property MdnFilesDirectory. 
        /// <para>
        /// Specifies a location to store MDN files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string MdnFilesDirectory
        {
            get { return this._mdnFilesDirectory; }
            set { this._mdnFilesDirectory = value; }
        }

        // Check to see if MdnFilesDirectory property is set
        internal bool IsSetMdnFilesDirectory()
        {
            return this._mdnFilesDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadFilesDirectory. 
        /// <para>
        /// Specifies a location to store the payload for AS2 message files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string PayloadFilesDirectory
        {
            get { return this._payloadFilesDirectory; }
            set { this._payloadFilesDirectory = value; }
        }

        // Check to see if PayloadFilesDirectory property is set
        internal bool IsSetPayloadFilesDirectory()
        {
            return this._payloadFilesDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property StatusFilesDirectory. 
        /// <para>
        /// Specifies a location to store AS2 status messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string StatusFilesDirectory
        {
            get { return this._statusFilesDirectory; }
            set { this._statusFilesDirectory = value; }
        }

        // Check to see if StatusFilesDirectory property is set
        internal bool IsSetStatusFilesDirectory()
        {
            return this._statusFilesDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property TemporaryFilesDirectory. 
        /// <para>
        /// Specifies a location to store temporary AS2 message files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string TemporaryFilesDirectory
        {
            get { return this._temporaryFilesDirectory; }
            set { this._temporaryFilesDirectory = value; }
        }

        // Check to see if TemporaryFilesDirectory property is set
        internal bool IsSetTemporaryFilesDirectory()
        {
            return this._temporaryFilesDirectory != null;
        }

    }
}