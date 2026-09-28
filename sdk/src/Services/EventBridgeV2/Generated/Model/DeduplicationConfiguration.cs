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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Deduplication settings for a publish request.
    /// </summary>
    public partial class DeduplicationConfiguration
    {
        private DeduplicationType _deduplicationType;

        /// <summary>
        /// Gets and sets the property DeduplicationType.
        /// </summary>
        [AWSProperty(Required=true)]
        public DeduplicationType DeduplicationType
        {
            get { return this._deduplicationType; }
            set { this._deduplicationType = value; }
        }

        // Check to see if DeduplicationType property is set
        internal bool IsSetDeduplicationType()
        {
            return this._deduplicationType != null;
        }

    }
}