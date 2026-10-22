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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// A snapshot of the resilience policy captured onto a test run from the service when
    /// the run was started.
    /// </summary>
    public partial class TestRunPolicySnapshot
    {
        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The availability SLO targets.
        /// </para>
        /// </summary>
        public AvailabilitySlo AvailabilitySlo { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilitySlo property is set.
        /// </summary>
        internal bool IsSetAvailabilitySlo() => this.AvailabilitySlo != null;

        /// <summary>
        /// Gets and sets the property DataRecovery. 
        /// <para>
        /// The data recovery targets.
        /// </para>
        /// </summary>
        public DataRecoveryTargets DataRecovery { get; set; }

        /// <summary>
        /// Checks to see if the DataRecovery property is set.
        /// </summary>
        internal bool IsSetDataRecovery() => this.DataRecovery != null;

        /// <summary>
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// The multi-AZ resilience targets.
        /// </para>
        /// </summary>
        public MultiAzTargets MultiAz { get; set; }

        /// <summary>
        /// Checks to see if the MultiAz property is set.
        /// </summary>
        internal bool IsSetMultiAz() => this.MultiAz != null;

        /// <summary>
        /// Gets and sets the property MultiRegion. 
        /// <para>
        /// The multi-Region resilience targets.
        /// </para>
        /// </summary>
        public MultiRegionTargets MultiRegion { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegion property is set.
        /// </summary>
        internal bool IsSetMultiRegion() => this.MultiRegion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 60)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;
    }
}
