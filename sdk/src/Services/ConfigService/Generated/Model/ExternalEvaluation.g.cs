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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Identifies an Amazon Web Services resource and indicates whether it complies with
    /// the Config rule that it was evaluated against.
    /// </summary>
    public partial class ExternalEvaluation
    {
        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// Supplementary information about the reason of compliance. For example, this task was
        /// completed on a specific date.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Annotation { get; set; }

        /// <summary>
        /// Checks to see if the Annotation property is set.
        /// </summary>
        internal bool IsSetAnnotation() => this.Annotation != null;

        /// <summary>
        /// Gets and sets the property ComplianceResourceId. 
        /// <para>
        /// The evaluated compliance resource ID. Config accepts only Amazon Web Services account
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 768)]
        public string ComplianceResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceResourceId property is set.
        /// </summary>
        internal bool IsSetComplianceResourceId() => this.ComplianceResourceId != null;

        /// <summary>
        /// Gets and sets the property ComplianceResourceType. 
        /// <para>
        /// The evaluated compliance resource type. Config accepts <c>AWS::::Account</c> resource
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ComplianceResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceResourceType property is set.
        /// </summary>
        internal bool IsSetComplianceResourceType() => this.ComplianceResourceType != null;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance of the Amazon Web Services resource. The valid values are <c>COMPLIANT,
        /// NON_COMPLIANT, </c> and <c>NOT_APPLICABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComplianceType ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property OrderingTimestamp. 
        /// <para>
        /// The time when the compliance was recorded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? OrderingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the OrderingTimestamp property is set.
        /// </summary>
        internal bool IsSetOrderingTimestamp() => this.OrderingTimestamp.HasValue;
    }
}
