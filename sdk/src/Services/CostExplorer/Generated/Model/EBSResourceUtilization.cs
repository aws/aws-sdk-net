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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The EBS field that contains a list of EBS metrics that are associated with the current
    /// instance.
    /// </summary>
    public partial class EBSResourceUtilization
    {
        private string _ebsReadBytesPerSecond;
        private string _ebsReadOpsPerSecond;
        private string _ebsWriteBytesPerSecond;
        private string _ebsWriteOpsPerSecond;

        /// <summary>
        /// Gets and sets the property EbsReadBytesPerSecond. 
        /// <para>
        /// The maximum size of read operations per second 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EbsReadBytesPerSecond
        {
            get { return this._ebsReadBytesPerSecond; }
            set { this._ebsReadBytesPerSecond = value; }
        }

        // Check to see if EbsReadBytesPerSecond property is set
        internal bool IsSetEbsReadBytesPerSecond()
        {
            return this._ebsReadBytesPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property EbsReadOpsPerSecond. 
        /// <para>
        /// The maximum number of read operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EbsReadOpsPerSecond
        {
            get { return this._ebsReadOpsPerSecond; }
            set { this._ebsReadOpsPerSecond = value; }
        }

        // Check to see if EbsReadOpsPerSecond property is set
        internal bool IsSetEbsReadOpsPerSecond()
        {
            return this._ebsReadOpsPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property EbsWriteBytesPerSecond. 
        /// <para>
        /// The maximum size of write operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EbsWriteBytesPerSecond
        {
            get { return this._ebsWriteBytesPerSecond; }
            set { this._ebsWriteBytesPerSecond = value; }
        }

        // Check to see if EbsWriteBytesPerSecond property is set
        internal bool IsSetEbsWriteBytesPerSecond()
        {
            return this._ebsWriteBytesPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property EbsWriteOpsPerSecond. 
        /// <para>
        /// The maximum number of write operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EbsWriteOpsPerSecond
        {
            get { return this._ebsWriteOpsPerSecond; }
            set { this._ebsWriteOpsPerSecond = value; }
        }

        // Check to see if EbsWriteOpsPerSecond property is set
        internal bool IsSetEbsWriteOpsPerSecond()
        {
            return this._ebsWriteOpsPerSecond != null;
        }

    }
}