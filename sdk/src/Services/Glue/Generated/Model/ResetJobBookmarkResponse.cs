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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ResetJobBookmark operation.
    /// </summary>
    public partial class ResetJobBookmarkResponse : AmazonWebServiceResponse
    {
        private JobBookmarkEntry _jobBookmarkEntry;

        /// <summary>
        /// Gets and sets the property JobBookmarkEntry. 
        /// <para>
        /// The reset bookmark entry.
        /// </para>
        /// </summary>
        public JobBookmarkEntry JobBookmarkEntry
        {
            get { return this._jobBookmarkEntry; }
            set { this._jobBookmarkEntry = value; }
        }

        // Check to see if JobBookmarkEntry property is set
        internal bool IsSetJobBookmarkEntry()
        {
            return this._jobBookmarkEntry != null;
        }

    }
}