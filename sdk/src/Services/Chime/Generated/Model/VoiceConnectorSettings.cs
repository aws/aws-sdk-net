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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// The Amazon Chime Voice Connector settings. Includes any Amazon S3 buckets designated
    /// for storing call detail records.
    /// </summary>
    public partial class VoiceConnectorSettings
    {
        private string _cdrBucket;

        /// <summary>
        /// Gets and sets the property CdrBucket. 
        /// <para>
        /// The Amazon S3 bucket designated for call detail record storage.
        /// </para>
        /// </summary>
        public string CdrBucket
        {
            get { return this._cdrBucket; }
            set { this._cdrBucket = value; }
        }

        // Check to see if CdrBucket property is set
        internal bool IsSetCdrBucket()
        {
            return this._cdrBucket != null;
        }

    }
}