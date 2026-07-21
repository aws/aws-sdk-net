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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Identity Center related configuration for the security configuration.
    /// </summary>
    public partial class IdentityCenterConfiguration
    {
        private string _emrIdentityCenterApplicationARN;
        private bool? _enableIdentityCenter;
        private bool? _identityCenterApplicationAssignmentRequired;
        private string _identityCenterInstanceARN;

        /// <summary>
        /// Gets and sets the property EmrIdentityCenterApplicationARN. 
        /// <para>
        /// The ARN of the EMR Identity Center application.
        /// </para>
        /// </summary>
        public string EmrIdentityCenterApplicationARN
        {
            get { return this._emrIdentityCenterApplicationARN; }
            set { this._emrIdentityCenterApplicationARN = value; }
        }

        // Check to see if EmrIdentityCenterApplicationARN property is set
        internal bool IsSetEmrIdentityCenterApplicationARN()
        {
            return this._emrIdentityCenterApplicationARN != null;
        }

        /// <summary>
        /// Gets and sets the property EnableIdentityCenter. 
        /// <para>
        /// Determines whether Identity Center is enabled for the security configuration.
        /// </para>
        /// </summary>
        public bool? EnableIdentityCenter
        {
            get { return this._enableIdentityCenter; }
            set { this._enableIdentityCenter = value; }
        }

        // Check to see if EnableIdentityCenter property is set
        internal bool IsSetEnableIdentityCenter()
        {
            return this._enableIdentityCenter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationAssignmentRequired. 
        /// <para>
        /// Determines whether user assignment is required for the Identity Center application.
        /// </para>
        /// </summary>
        public bool? IdentityCenterApplicationAssignmentRequired
        {
            get { return this._identityCenterApplicationAssignmentRequired; }
            set { this._identityCenterApplicationAssignmentRequired = value; }
        }

        // Check to see if IdentityCenterApplicationAssignmentRequired property is set
        internal bool IsSetIdentityCenterApplicationAssignmentRequired()
        {
            return this._identityCenterApplicationAssignmentRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceARN. 
        /// <para>
        /// The ARN of the Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterInstanceARN
        {
            get { return this._identityCenterInstanceARN; }
            set { this._identityCenterInstanceARN = value; }
        }

        // Check to see if IdentityCenterInstanceARN property is set
        internal bool IsSetIdentityCenterInstanceARN()
        {
            return this._identityCenterInstanceARN != null;
        }

    }
}