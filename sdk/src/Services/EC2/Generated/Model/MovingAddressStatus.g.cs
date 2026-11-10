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
    /// <note> 
    /// <para>
    /// This action is deprecated.
    /// </para>
    ///  </note> 
    /// <para>
    /// Describes the status of a moving Elastic IP address.
    /// </para>
    /// </summary>
    public partial class MovingAddressStatus
    {
        /// <summary>
        /// Gets and sets the property MoveStatus. 
        /// <para>
        /// The status of the Elastic IP address that's being moved or restored.
        /// </para>
        /// </summary>
        public MoveStatus MoveStatus { get; set; }

        /// <summary>
        /// Checks to see if the MoveStatus property is set.
        /// </summary>
        internal bool IsSetMoveStatus() => this.MoveStatus != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;
    }
}
