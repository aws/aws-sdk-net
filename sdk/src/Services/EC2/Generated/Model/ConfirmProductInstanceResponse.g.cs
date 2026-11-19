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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ConfirmProductInstance operation.
    /// </summary>
    public partial class ConfirmProductInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the instance owner. This is only present if
        /// the product code is attached to the instance.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Return. 
        /// <para>
        /// The return value of the request. Returns <c>true</c> if the specified product code
        /// is owned by the requester and associated with the specified instance.
        /// </para>
        /// </summary>
        public bool? Return { get; set; }

        /// <summary>
        /// Checks to see if the Return property is set.
        /// </summary>
        internal bool IsSetReturn() => this.Return.HasValue;
    }
}
