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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Updates the feature group online store configuration.
    /// </summary>
    public partial class OnlineStoreConfigUpdate
    {
        private TtlDuration _ttlDuration;

        /// <summary>
        /// Gets and sets the property TtlDuration. 
        /// <para>
        /// Time to live duration, where the record is hard deleted after the expiration time
        /// is reached; <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>. For information
        /// on HardDelete, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html">DeleteRecord</a>
        /// API in the Amazon SageMaker API Reference guide.
        /// </para>
        /// </summary>
        public TtlDuration TtlDuration
        {
            get { return this._ttlDuration; }
            set { this._ttlDuration = value; }
        }

        // Check to see if TtlDuration property is set
        internal bool IsSetTtlDuration()
        {
            return this._ttlDuration != null;
        }

    }
}