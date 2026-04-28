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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the CreateLookupTable operation.
    /// </summary>
    public partial class CreateLookupTableResponse : AmazonWebServiceResponse
    {
        private long? _createdAt;
        private string _lookupTableArn;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the lookup table was created, expressed as the number of milliseconds
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LookupTableArn. 
        /// <para>
        /// The ARN of the lookup table that was created.
        /// </para>
        /// </summary>
        public string LookupTableArn
        {
            get { return this._lookupTableArn; }
            set { this._lookupTableArn = value; }
        }

        // Check to see if LookupTableArn property is set
        internal bool IsSetLookupTableArn()
        {
            return this._lookupTableArn != null;
        }

    }
}