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

namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// A summary of a support permit.
    /// </summary>
    public partial class SupportPermitSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the permit was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Permit. 
        /// <para>
        /// The permit definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Permit Permit { get; set; }

        /// <summary>
        /// Checks to see if the Permit property is set.
        /// </summary>
        internal bool IsSetPermit() => this.Permit != null;

        /// <summary>
        /// Gets and sets the property SigningKeyInfo. 
        /// <para>
        /// The signing key information for the permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SigningKeyInfo SigningKeyInfo { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyInfo property is set.
        /// </summary>
        internal bool IsSetSigningKeyInfo() => this.SigningKeyInfo != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupportPermitStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SupportCaseDisplayId. 
        /// <para>
        /// The display identifier of the support case associated with the permit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SupportCaseDisplayId { get; set; }

        /// <summary>
        /// Checks to see if the SupportCaseDisplayId property is set.
        /// </summary>
        internal bool IsSetSupportCaseDisplayId() => this.SupportCaseDisplayId != null;
    }
}
