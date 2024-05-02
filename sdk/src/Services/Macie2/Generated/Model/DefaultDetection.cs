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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a type of sensitive data that was detected by a managed
    /// data identifier and produced a sensitive data finding.
    /// </summary>
    public partial class DefaultDetection
    {
        private long? _count;
        private Occurrences _occurrences;
        private string _type;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of occurrences of the type of sensitive data that was detected.
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
        /// The location of 1-15 occurrences of the sensitive data that was detected. A finding
        /// includes location data for a maximum of 15 occurrences of sensitive data.
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
        /// The type of sensitive data that was detected. For example, AWS_CREDENTIALS, PHONE_NUMBER,
        /// or ADDRESS.
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