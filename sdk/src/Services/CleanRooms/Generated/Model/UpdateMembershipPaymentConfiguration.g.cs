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
    /// An object representing the payment responsibilities to update for the membership.
    /// </summary>
    public partial class UpdateMembershipPaymentConfiguration
    {
        /// <summary>
        /// Gets and sets the property JobCompute.
        /// </summary>
        public MembershipJobComputePaymentConfig JobCompute { get; set; }

        /// <summary>
        /// Checks to see if the JobCompute property is set.
        /// </summary>
        internal bool IsSetJobCompute() => this.JobCompute != null;

        /// <summary>
        /// Gets and sets the property MachineLearning.
        /// </summary>
        public MembershipMLPaymentConfig MachineLearning { get; set; }

        /// <summary>
        /// Checks to see if the MachineLearning property is set.
        /// </summary>
        internal bool IsSetMachineLearning() => this.MachineLearning != null;

        /// <summary>
        /// Gets and sets the property QueryCompute.
        /// </summary>
        public MembershipQueryComputePaymentConfig QueryCompute { get; set; }

        /// <summary>
        /// Checks to see if the QueryCompute property is set.
        /// </summary>
        internal bool IsSetQueryCompute() => this.QueryCompute != null;
    }
}
