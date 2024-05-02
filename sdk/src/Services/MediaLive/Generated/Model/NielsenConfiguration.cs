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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Nielsen Configuration
    /// </summary>
    public partial class NielsenConfiguration
    {
        private string _distributorId;
        private NielsenPcmToId3TaggingState _nielsenPcmToId3Tagging;

        /// <summary>
        /// Gets and sets the property DistributorId. Enter the Distributor ID assigned to your
        /// organization by Nielsen.
        /// </summary>
        public string DistributorId
        {
            get { return this._distributorId; }
            set { this._distributorId = value; }
        }

        // Check to see if DistributorId property is set
        internal bool IsSetDistributorId()
        {
            return this._distributorId != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenPcmToId3Tagging. Enables Nielsen PCM to ID3 tagging
        /// </summary>
        public NielsenPcmToId3TaggingState NielsenPcmToId3Tagging
        {
            get { return this._nielsenPcmToId3Tagging; }
            set { this._nielsenPcmToId3Tagging = value; }
        }

        // Check to see if NielsenPcmToId3Tagging property is set
        internal bool IsSetNielsenPcmToId3Tagging()
        {
            return this._nielsenPcmToId3Tagging != null;
        }

    }
}