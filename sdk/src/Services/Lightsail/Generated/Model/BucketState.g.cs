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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the state of an Amazon Lightsail bucket.
    /// </summary>
    public partial class BucketState
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The state code of the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following codes are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OK</c> - The bucket is in a running state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unknown</c> - Creation of the bucket might have timed-out. You might want to delete
        /// the bucket and create a new one.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that describes the state of the bucket.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
