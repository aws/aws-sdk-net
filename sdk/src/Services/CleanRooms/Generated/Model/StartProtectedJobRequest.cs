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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
    /// Container for the parameters to the StartProtectedJob operation.
    /// Creates a protected job that is started by Clean Rooms.
    /// </summary>
    public partial class StartProtectedJobRequest : AmazonCleanRoomsRequest
    {
        private ProtectedJobComputeConfiguration _computeConfiguration;
        private ProtectedJobParameters _jobParameters;
        private string _membershipIdentifier;
        private ProtectedJobResultConfigurationInput _resultConfiguration;
        private ProtectedJobType _type;

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the protected job.
        /// </para>
        /// </summary>
        public ProtectedJobComputeConfiguration ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JobParameters. 
        /// <para>
        ///  The job parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectedJobParameters JobParameters
        {
            get { return this._jobParameters; }
            set { this._jobParameters = value; }
        }

        // Check to see if JobParameters property is set
        internal bool IsSetJobParameters()
        {
            return this._jobParameters != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership to run this job against. Currently accepts
        /// a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The details needed to write the job results.
        /// </para>
        /// </summary>
        public ProtectedJobResultConfigurationInput ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of protected job to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectedJobType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}