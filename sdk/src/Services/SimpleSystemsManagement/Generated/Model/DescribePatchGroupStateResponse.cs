/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribePatchGroupState operation.
    /// </summary>
    public partial class DescribePatchGroupStateResponse : AmazonWebServiceResponse
    {
        private int? _instances;
        private int? _instancesWithFailedPatches;
        private int? _instancesWithInstalledOtherPatches;
        private int? _instancesWithInstalledPatches;
        private int? _instancesWithMissingPatches;
        private int? _instancesWithNotApplicablePatches;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The number of instances in the patch group.
        /// </para>
        /// </summary>
        public int Instances
        {
            get { return this._instances.GetValueOrDefault(); }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithFailedPatches. 
        /// <para>
        /// The number of instances with patches from the patch baseline that failed to install.
        /// </para>
        /// </summary>
        public int InstancesWithFailedPatches
        {
            get { return this._instancesWithFailedPatches.GetValueOrDefault(); }
            set { this._instancesWithFailedPatches = value; }
        }

        // Check to see if InstancesWithFailedPatches property is set
        internal bool IsSetInstancesWithFailedPatches()
        {
            return this._instancesWithFailedPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledOtherPatches. 
        /// <para>
        /// The number of instances with patches installed that aren’t defined in the patch baseline.
        /// </para>
        /// </summary>
        public int InstancesWithInstalledOtherPatches
        {
            get { return this._instancesWithInstalledOtherPatches.GetValueOrDefault(); }
            set { this._instancesWithInstalledOtherPatches = value; }
        }

        // Check to see if InstancesWithInstalledOtherPatches property is set
        internal bool IsSetInstancesWithInstalledOtherPatches()
        {
            return this._instancesWithInstalledOtherPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledPatches. 
        /// <para>
        /// The number of instances with installed patches.
        /// </para>
        /// </summary>
        public int InstancesWithInstalledPatches
        {
            get { return this._instancesWithInstalledPatches.GetValueOrDefault(); }
            set { this._instancesWithInstalledPatches = value; }
        }

        // Check to see if InstancesWithInstalledPatches property is set
        internal bool IsSetInstancesWithInstalledPatches()
        {
            return this._instancesWithInstalledPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithMissingPatches. 
        /// <para>
        /// The number of instances with missing patches from the patch baseline.
        /// </para>
        /// </summary>
        public int InstancesWithMissingPatches
        {
            get { return this._instancesWithMissingPatches.GetValueOrDefault(); }
            set { this._instancesWithMissingPatches = value; }
        }

        // Check to see if InstancesWithMissingPatches property is set
        internal bool IsSetInstancesWithMissingPatches()
        {
            return this._instancesWithMissingPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithNotApplicablePatches. 
        /// <para>
        /// The number of instances with patches that aren’t applicable.
        /// </para>
        /// </summary>
        public int InstancesWithNotApplicablePatches
        {
            get { return this._instancesWithNotApplicablePatches.GetValueOrDefault(); }
            set { this._instancesWithNotApplicablePatches = value; }
        }

        // Check to see if InstancesWithNotApplicablePatches property is set
        internal bool IsSetInstancesWithNotApplicablePatches()
        {
            return this._instancesWithNotApplicablePatches.HasValue; 
        }

    }
}