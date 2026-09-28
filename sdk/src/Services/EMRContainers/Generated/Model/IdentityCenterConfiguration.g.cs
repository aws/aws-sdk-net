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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Contains the IAM Identity Center settings for a security configuration, including
    /// instance ARN, application assignment requirements, and application ARN.
    /// </summary>
    public partial class IdentityCenterConfiguration
    {
        /// <summary>
        /// Gets and sets the property EmrIdentityCenterApplicationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EMR Identity Center application.
        /// </para>
        /// </summary>
        public string EmrIdentityCenterApplicationARN { get; set; }

        /// <summary>
        /// Checks to see if the EmrIdentityCenterApplicationARN property is set.
        /// </summary>
        internal bool IsSetEmrIdentityCenterApplicationARN() => this.EmrIdentityCenterApplicationARN != null;

        /// <summary>
        /// Gets and sets the property EnableIdentityCenter. 
        /// <para>
        /// Specifies whether Identity Center is enabled for the security configuration.
        /// </para>
        /// </summary>
        public bool? EnableIdentityCenter { get; set; }

        /// <summary>
        /// Checks to see if the EnableIdentityCenter property is set.
        /// </summary>
        internal bool IsSetEnableIdentityCenter() => this.EnableIdentityCenter.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationAssignmentRequired. 
        /// <para>
        /// Specifies whether user assignment is required for the Identity Center application.
        /// </para>
        /// </summary>
        public bool? IdentityCenterApplicationAssignmentRequired { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterApplicationAssignmentRequired property is set.
        /// </summary>
        internal bool IsSetIdentityCenterApplicationAssignmentRequired() => this.IdentityCenterApplicationAssignmentRequired.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string IdentityCenterInstanceARN { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceARN property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceARN() => this.IdentityCenterInstanceARN != null;
    }
}
