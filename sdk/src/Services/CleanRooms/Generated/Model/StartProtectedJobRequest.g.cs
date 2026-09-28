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
    /// Container for the parameters to the StartProtectedJob operation. Creates a protected
    /// job that is started by Clean Rooms.
    /// </summary>
    public partial class StartProtectedJobRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the protected job.
        /// </para>
        /// </summary>
        public ProtectedJobComputeConfiguration ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobComputePayerAccountId. 
        /// <para>
        /// The account ID of the member that pays for the job compute costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string JobComputePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the JobComputePayerAccountId property is set.
        /// </summary>
        internal bool IsSetJobComputePayerAccountId() => this.JobComputePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property JobParameters. 
        /// <para>
        ///  The job parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectedJobParameters JobParameters { get; set; }

        /// <summary>
        /// Checks to see if the JobParameters property is set.
        /// </summary>
        internal bool IsSetJobParameters() => this.JobParameters != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership to run this job against. Currently accepts
        /// a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The details needed to write the job results.
        /// </para>
        /// </summary>
        public ProtectedJobResultConfigurationInput ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of protected job to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectedJobType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
