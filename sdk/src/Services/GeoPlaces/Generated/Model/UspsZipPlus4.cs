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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The USPS zip+4 code.
    /// </summary>
    public partial class UspsZipPlus4
    {
        private RecordTypeCode _recordTypeCode;

        /// <summary>
        /// Gets and sets the property RecordTypeCode. 
        /// <para>
        /// The USPS ZIP+4 Record Type Code.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RecordTypeCode RecordTypeCode
        {
            get { return this._recordTypeCode; }
            set { this._recordTypeCode = value; }
        }

        // Check to see if RecordTypeCode property is set
        internal bool IsSetRecordTypeCode()
        {
            return this._recordTypeCode != null;
        }

    }
}