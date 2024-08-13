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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
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
namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// The section of the contact audio where that category rule was detected.
    /// </summary>
    public partial class PointOfInterest
    {
        private int? _beginOffsetMillis;
        private int? _endOffsetMillis;

        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The beginning offset in milliseconds where the category rule was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? BeginOffsetMillis
        {
            get { return this._beginOffsetMillis; }
            set { this._beginOffsetMillis = value; }
        }

        // Check to see if BeginOffsetMillis property is set
        internal bool IsSetBeginOffsetMillis()
        {
            return this._beginOffsetMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The ending offset in milliseconds where the category rule was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? EndOffsetMillis
        {
            get { return this._endOffsetMillis; }
            set { this._endOffsetMillis = value; }
        }

        // Check to see if EndOffsetMillis property is set
        internal bool IsSetEndOffsetMillis()
        {
            return this._endOffsetMillis.HasValue; 
        }

    }
}