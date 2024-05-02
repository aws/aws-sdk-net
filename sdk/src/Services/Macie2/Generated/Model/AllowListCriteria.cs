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
    /// Specifies the criteria for an allow list. The criteria must specify a regular expression
    /// (regex) or an S3 object (s3WordsList). It can't specify both.
    /// </summary>
    public partial class AllowListCriteria
    {
        private string _regex;
        private S3WordsList _s3WordsList;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regular expression (<i>regex</i>) that defines the text pattern to ignore. The
        /// expression can contain as many as 512 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

        /// <summary>
        /// Gets and sets the property S3WordsList. 
        /// <para>
        /// The location and name of the S3 object that lists specific text to ignore.
        /// </para>
        /// </summary>
        public S3WordsList S3WordsList
        {
            get { return this._s3WordsList; }
            set { this._s3WordsList = value; }
        }

        // Check to see if S3WordsList property is set
        internal bool IsSetS3WordsList()
        {
            return this._s3WordsList != null;
        }

    }
}