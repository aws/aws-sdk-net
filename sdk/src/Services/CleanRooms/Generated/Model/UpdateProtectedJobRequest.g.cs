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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProtectedJob operation. Updates the processing
    /// of a currently running job.
    /// </summary>
    public partial class UpdateProtectedJobRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The identifier for a member of a protected job instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProtectedJobIdentifier. 
        /// <para>
        ///  The identifier of the protected job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ProtectedJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedJobIdentifier property is set.
        /// </summary>
        internal bool IsSetProtectedJobIdentifier() => this.ProtectedJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property TargetStatus. 
        /// <para>
        /// The target status of a protected job. Used to update the execution status of a currently
        /// running job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetProtectedJobStatus TargetStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetStatus property is set.
        /// </summary>
        internal bool IsSetTargetStatus() => this.TargetStatus != null;
    }
}
