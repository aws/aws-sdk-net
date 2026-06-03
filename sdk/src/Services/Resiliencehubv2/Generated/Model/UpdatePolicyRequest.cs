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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
    /// Container for the parameters to the UpdatePolicy operation.
    /// Updates an existing resilience policy.
    /// </summary>
    public partial class UpdatePolicyRequest : AmazonResiliencehubv2Request
    {
        private AvailabilitySlo _availabilitySlo;
        private DataRecoveryTargets _dataRecovery;
        private string _description;
        private MultiAzTargets _multiAz;
        private MultiRegionTargets _multiRegion;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The updated availability SLO for the policy.
        /// </para>
        /// </summary>
        public AvailabilitySlo AvailabilitySlo
        {
            get { return this._availabilitySlo; }
            set { this._availabilitySlo = value; }
        }

        // Check to see if AvailabilitySlo property is set
        internal bool IsSetAvailabilitySlo()
        {
            return this._availabilitySlo != null;
        }

        /// <summary>
        /// Gets and sets the property DataRecovery. 
        /// <para>
        /// The updated data recovery targets for the policy.
        /// </para>
        /// </summary>
        public DataRecoveryTargets DataRecovery
        {
            get { return this._dataRecovery; }
            set { this._dataRecovery = value; }
        }

        // Check to see if DataRecovery property is set
        internal bool IsSetDataRecovery()
        {
            return this._dataRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=615)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// The updated multi-AZ disaster recovery targets for the policy.
        /// </para>
        /// </summary>
        public MultiAzTargets MultiAz
        {
            get { return this._multiAz; }
            set { this._multiAz = value; }
        }

        // Check to see if MultiAz property is set
        internal bool IsSetMultiAz()
        {
            return this._multiAz != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegion. 
        /// <para>
        /// The updated multi-Region disaster recovery targets for the policy.
        /// </para>
        /// </summary>
        public MultiRegionTargets MultiRegion
        {
            get { return this._multiRegion; }
            set { this._multiRegion = value; }
        }

        // Check to see if MultiRegion property is set
        internal bool IsSetMultiRegion()
        {
            return this._multiRegion != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

    }
}