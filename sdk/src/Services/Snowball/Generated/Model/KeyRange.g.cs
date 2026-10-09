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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Contains a key range. For export jobs, a <c>S3Resource</c> object can have an optional
    /// <c>KeyRange</c> value. The length of the range is defined at job creation, and has
    /// either an inclusive <c>BeginMarker</c>, an inclusive <c>EndMarker</c>, or both. Ranges
    /// are UTF-8 binary sorted.
    /// </summary>
    public partial class KeyRange
    {
        /// <summary>
        /// Gets and sets the property BeginMarker. 
        /// <para>
        /// The key that starts an optional key range for an export job. Ranges are inclusive
        /// and UTF-8 binary sorted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string BeginMarker { get; set; }

        /// <summary>
        /// Checks to see if the BeginMarker property is set.
        /// </summary>
        internal bool IsSetBeginMarker() => this.BeginMarker != null;

        /// <summary>
        /// Gets and sets the property EndMarker. 
        /// <para>
        /// The key that ends an optional key range for an export job. Ranges are inclusive and
        /// UTF-8 binary sorted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string EndMarker { get; set; }

        /// <summary>
        /// Checks to see if the EndMarker property is set.
        /// </summary>
        internal bool IsSetEndMarker() => this.EndMarker != null;
    }
}
