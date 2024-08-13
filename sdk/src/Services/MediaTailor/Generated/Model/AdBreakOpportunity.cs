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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// A location at which a zero-duration ad marker was detected in a VOD source manifest.
    /// </summary>
    public partial class AdBreakOpportunity
    {
        private long? _offsetMillis;

        /// <summary>
        /// Gets and sets the property OffsetMillis. 
        /// <para>
        /// The offset in milliseconds from the start of the VOD source at which an ad marker
        /// was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? OffsetMillis
        {
            get { return this._offsetMillis; }
            set { this._offsetMillis = value; }
        }

        // Check to see if OffsetMillis property is set
        internal bool IsSetOffsetMillis()
        {
            return this._offsetMillis.HasValue; 
        }

    }
}