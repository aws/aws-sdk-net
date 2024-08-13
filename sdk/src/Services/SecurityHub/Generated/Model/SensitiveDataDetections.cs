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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The list of detected instances of sensitive data.
    /// </summary>
    public partial class SensitiveDataDetections
    {
        private long? _count;
        private Occurrences _occurrences;
        private string _type;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of occurrences of sensitive data that were detected.
        /// </para>
        /// </summary>
        public long? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Occurrences. 
        /// <para>
        /// Details about the sensitive data that was detected.
        /// </para>
        /// </summary>
        public Occurrences Occurrences
        {
            get { return this._occurrences; }
            set { this._occurrences = value; }
        }

        // Check to see if Occurrences property is set
        internal bool IsSetOccurrences()
        {
            return this._occurrences != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of sensitive data that was detected. For example, the type might indicate
        /// that the data is an email address.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}