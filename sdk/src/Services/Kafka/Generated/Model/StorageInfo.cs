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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Contains information about storage volumes attached to MSK broker nodes.
    /// </summary>
    public partial class StorageInfo
    {
        private EBSStorageInfo _ebsStorageInfo;

        /// <summary>
        /// Gets and sets the property EbsStorageInfo.             
        /// <para>
        /// EBS volume information.
        /// </para>
        /// </summary>
        public EBSStorageInfo EbsStorageInfo
        {
            get { return this._ebsStorageInfo; }
            set { this._ebsStorageInfo = value; }
        }

        // Check to see if EbsStorageInfo property is set
        internal bool IsSetEbsStorageInfo()
        {
            return this._ebsStorageInfo != null;
        }

    }
}