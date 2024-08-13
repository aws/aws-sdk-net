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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
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
namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Options that specify the configuration of a persistent buffer. To configure how OpenSearch
    /// Ingestion encrypts this data, set the <c>EncryptionAtRestOptions</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/osis-features-overview.html#persistent-buffering">Persistent
    /// buffering</a>.
    /// </summary>
    public partial class BufferOptions
    {
        private bool? _persistentBufferEnabled;

        /// <summary>
        /// Gets and sets the property PersistentBufferEnabled. 
        /// <para>
        /// Whether persistent buffering should be enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PersistentBufferEnabled
        {
            get { return this._persistentBufferEnabled; }
            set { this._persistentBufferEnabled = value; }
        }

        // Check to see if PersistentBufferEnabled property is set
        internal bool IsSetPersistentBufferEnabled()
        {
            return this._persistentBufferEnabled.HasValue; 
        }

    }
}