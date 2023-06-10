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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a custom data identifier that produced a sensitive data
    /// finding, and the sensitive data that it detected for the finding.
    /// </summary>
    public partial class CustomDetection
    {
        private string _arn;
        private long? _count;
        private string _name;
        private Occurrences _occurrences;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique identifier for the custom data identifier.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of occurrences of the sensitive data that the custom data identifier
        /// detected.
        /// </para>
        /// </summary>
        public long Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom data identifier.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Occurrences. 
        /// <para>
        /// The location of 1-15 occurrences of the sensitive data that the custom data identifier
        /// detected. A finding includes location data for a maximum of 15 occurrences of sensitive
        /// data.
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

    }
}