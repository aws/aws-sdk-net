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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A contributor to an Amazon QuickSight space.
    /// </summary>
    public partial class SpaceContributor
    {
        private double? _percentage;
        private long? _rawFileSizeBytes;
        private string _userName;

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of total contributions made by the user.
        /// </para>
        /// </summary>
        public double? Percentage
        {
            get { return this._percentage; }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RawFileSizeBytes. 
        /// <para>
        /// The raw file size in bytes contributed by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? RawFileSizeBytes
        {
            get { return this._rawFileSizeBytes; }
            set { this._rawFileSizeBytes = value; }
        }

        // Check to see if RawFileSizeBytes property is set
        internal bool IsSetRawFileSizeBytes()
        {
            return this._rawFileSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name of the contributor.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}