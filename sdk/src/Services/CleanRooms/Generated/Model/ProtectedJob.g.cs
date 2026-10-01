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
    /// The parameters for an Clean Rooms protected job.
    /// </summary>
    public partial class ProtectedJob
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  The creation time of the protected job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        ///  The error from the protected job.
        /// </para>
        /// </summary>
        public ProtectedJobError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for a protected job instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        ///  The job parameters for the protected job.
        /// </para>
        /// </summary>
        public ProtectedJobParameters JobParameters { get; set; }

        /// <summary>
        /// Checks to see if the JobParameters property is set.
        /// </summary>
        internal bool IsSetJobParameters() => this.JobParameters != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The ARN of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// he identifier for the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        ///  The result of the protected job.
        /// </para>
        /// </summary>
        public ProtectedJobResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// Contains any details needed to write the job results.
        /// </para>
        /// </summary>
        public ProtectedJobResultConfigurationOutput ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        ///  The statistics of the protected job.
        /// </para>
        /// </summary>
        public ProtectedJobStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the protected job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectedJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
