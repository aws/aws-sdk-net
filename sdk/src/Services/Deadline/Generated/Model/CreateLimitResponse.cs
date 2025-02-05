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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the CreateLimit operation.
    /// </summary>
    public partial class CreateLimitResponse : AmazonWebServiceResponse
    {
        private string _limitId;

        /// <summary>
        /// Gets and sets the property LimitId. 
        /// <para>
        /// A unique identifier for the limit. Use this identifier in other operations, such as
        /// <c>CreateQueueLimitAssociation</c> and <c>DeleteLimit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LimitId
        {
            get { return this._limitId; }
            set { this._limitId = value; }
        }

        // Check to see if LimitId property is set
        internal bool IsSetLimitId()
        {
            return this._limitId != null;
        }

    }
}