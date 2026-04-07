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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Specifies a rule that controls when cached data expires from the file system based
    /// on last access time.
    /// </summary>
    public partial class ExpirationDataRule
    {
        private int? _daysAfterLastAccess;

        /// <summary>
        /// Gets and sets the property DaysAfterLastAccess. 
        /// <para>
        /// The number of days after last access before cached data expires from the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=365)]
        public int? DaysAfterLastAccess
        {
            get { return this._daysAfterLastAccess; }
            set { this._daysAfterLastAccess = value; }
        }

        // Check to see if DaysAfterLastAccess property is set
        internal bool IsSetDaysAfterLastAccess()
        {
            return this._daysAfterLastAccess.HasValue; 
        }

    }
}