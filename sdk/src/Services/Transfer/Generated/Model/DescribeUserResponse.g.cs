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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the DescribeUser operation.
    /// </summary>
    public partial class DescribeUserResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server that has this user assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string ServerId { get; set; }

        /// <summary>
        /// Checks to see if the ServerId property is set.
        /// </summary>
        internal bool IsSetServerId() => this.ServerId != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// An array containing the properties of the Transfer Family user for the <c>ServerID</c>
        /// value that you specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DescribedUser User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
