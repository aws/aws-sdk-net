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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains an assessment of a Kubernetes policy violation.
    /// </summary>
    public partial class KubernetesPolicyViolation
    {
        /// <summary>
        /// Gets and sets the property AffectedResource. 
        /// <para>
        /// The Kubernetes resource that the violation affects.
        /// </para>
        /// </summary>
        public string AffectedResource { get; set; }

        /// <summary>
        /// Checks to see if the AffectedResource property is set.
        /// </summary>
        internal bool IsSetAffectedResource() => this.AffectedResource != null;

        /// <summary>
        /// Gets and sets the property ExposureVector. 
        /// <para>
        /// How the misconfiguration exposes the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string ExposureVector { get; set; }

        /// <summary>
        /// Checks to see if the ExposureVector property is set.
        /// </summary>
        internal bool IsSetExposureVector() => this.ExposureVector != null;

        /// <summary>
        /// Gets and sets the property GrantedAccess. 
        /// <para>
        /// The access that the violation grants.
        /// </para>
        /// </summary>
        public string GrantedAccess { get; set; }

        /// <summary>
        /// Checks to see if the GrantedAccess property is set.
        /// </summary>
        internal bool IsSetGrantedAccess() => this.GrantedAccess != null;

        /// <summary>
        /// Gets and sets the property MisconfigurationImpact. 
        /// <para>
        /// The potential impact of the misconfiguration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string MisconfigurationImpact { get; set; }

        /// <summary>
        /// Checks to see if the MisconfigurationImpact property is set.
        /// </summary>
        internal bool IsSetMisconfigurationImpact() => this.MisconfigurationImpact != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The Kubernetes subject, such as a user, a group, or a service account, that the violation
        /// involves.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property ViolationType. 
        /// <para>
        /// The type of the violation.
        /// </para>
        /// </summary>
        public string ViolationType { get; set; }

        /// <summary>
        /// Checks to see if the ViolationType property is set.
        /// </summary>
        internal bool IsSetViolationType() => this.ViolationType != null;
    }
}
