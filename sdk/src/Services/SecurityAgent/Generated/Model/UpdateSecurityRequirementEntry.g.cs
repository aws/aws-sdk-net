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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains the details for updating an existing security requirement within a pack.
    /// The name is an immutable identifier used to locate the requirement and cannot be modified.
    /// </summary>
    public partial class UpdateSecurityRequirementEntry
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the security requirement.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The updated security domain the requirement belongs to.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Evaluation. 
        /// <para>
        /// The updated evaluation criteria used to assess compliance with this requirement.
        /// </para>
        /// </summary>
        public string Evaluation { get; set; }

        /// <summary>
        /// Checks to see if the Evaluation property is set.
        /// </summary>
        internal bool IsSetEvaluation() => this.Evaluation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the security requirement to update. This is an immutable identifier and
        /// cannot be changed once the requirement is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// The updated remediation steps when the requirement is not met.
        /// </para>
        /// </summary>
        public string Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;
    }
}
