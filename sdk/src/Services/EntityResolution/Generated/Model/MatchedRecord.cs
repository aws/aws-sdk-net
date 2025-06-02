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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The matched record.
    /// </summary>
    public partial class MatchedRecord
    {
        private string _inputSourceARN;
        private string _recordId;

        /// <summary>
        /// Gets and sets the property InputSourceARN. 
        /// <para>
        ///  The input source ARN of the matched record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputSourceARN
        {
            get { return this._inputSourceARN; }
            set { this._inputSourceARN = value; }
        }

        // Check to see if InputSourceARN property is set
        internal bool IsSetInputSourceARN()
        {
            return this._inputSourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        ///  The record ID of the matched record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

    }
}