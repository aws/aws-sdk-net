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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// A versioned snapshot of a response edit.
    /// </summary>
    public partial class ResponseVersion
    {
        private string _responseText;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ResponseText. 
        /// <para>
        /// The response text for this version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResponseText
        {
            get { return this._responseText; }
            set { this._responseText = value; }
        }

        // Check to see if ResponseText property is set
        internal bool IsSetResponseText()
        {
            return this._responseText != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// ISO 8601 timestamp of when this edit was made.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}