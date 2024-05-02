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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Data retrieval policy rule.
    /// </summary>
    public partial class DataRetrievalRule
    {
        private long? _bytesPerHour;
        private string _strategy;

        /// <summary>
        /// Gets and sets the property BytesPerHour. 
        /// <para>
        /// The maximum number of bytes that can be retrieved in an hour.
        /// </para>
        ///  
        /// <para>
        /// This field is required only if the value of the Strategy field is <c>BytesPerHour</c>.
        /// Your PUT operation will be rejected if the Strategy field is not set to <c>BytesPerHour</c>
        /// and you set this field.
        /// </para>
        /// </summary>
        public long? BytesPerHour
        {
            get { return this._bytesPerHour; }
            set { this._bytesPerHour = value; }
        }

        // Check to see if BytesPerHour property is set
        internal bool IsSetBytesPerHour()
        {
            return this._bytesPerHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The type of data retrieval policy to set.
        /// </para>
        ///  
        /// <para>
        /// Valid values: BytesPerHour|FreeTier|None
        /// </para>
        /// </summary>
        public string Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}