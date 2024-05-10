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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The mapping between a Amazon Web Services Region and the key that's used to encrypt
    /// the data.
    /// </summary>
    public partial class RegionMapInputValue
    {
        private string _sseKmsKeyId;

        /// <summary>
        /// Gets and sets the property SseKmsKeyId. 
        /// <para>
        /// The KMS key used to encrypt the data in your replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SseKmsKeyId
        {
            get { return this._sseKmsKeyId; }
            set { this._sseKmsKeyId = value; }
        }

        // Check to see if SseKmsKeyId property is set
        internal bool IsSetSseKmsKeyId()
        {
            return this._sseKmsKeyId != null;
        }

    }
}