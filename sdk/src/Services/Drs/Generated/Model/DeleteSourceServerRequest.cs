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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSourceServer operation.
    /// Deletes a single Source Server by ID. The Source Server must be disconnected first.
    /// </summary>
    public partial class DeleteSourceServerRequest : AmazonDrsRequest
    {
        private string _sourceServerID;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

    }
}