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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This object typically provides details about a control finding, such as applicable
    /// standards and the status of control checks. While finding providers can add custom
    /// content in <c>Compliance</c> object fields, they are typically used to review details
    /// of Security Hub CSPM control findings.
    /// </summary>
    public partial class Compliance
    {
        /// <summary>
        /// Gets and sets the property AssociatedStandards. 
        /// <para>
        /// Typically provides an array of enabled security standards in which a security control
        /// is currently enabled. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedStandard> AssociatedStandards { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedStandard>() : null;

        /// <summary>
        /// Checks to see if the AssociatedStandards property is set.
        /// </summary>
        internal bool IsSetAssociatedStandards() => this.AssociatedStandards != null && (this.AssociatedStandards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedRequirements. 
        /// <para>
        /// Typically provides the industry or regulatory framework requirements that are related
        /// to a control. The check for that control is aligned with these requirements.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 32 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelatedRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelatedRequirements property is set.
        /// </summary>
        internal bool IsSetRelatedRequirements() => this.RelatedRequirements != null && (this.RelatedRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  Typically provides the unique identifier of a control across standards. For Security
        /// Hub CSPM controls, this field consists of an Amazon Web Services service and a unique
        /// number, such as <c>APIGateway.5</c>. 
        /// </para>
        /// </summary>
        public string SecurityControlId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityControlId property is set.
        /// </summary>
        internal bool IsSetSecurityControlId() => this.SecurityControlId != null;

        /// <summary>
        /// Gets and sets the property SecurityControlParameters. 
        /// <para>
        ///  Typically an object that includes security control parameter names and values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityControlParameter> SecurityControlParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<SecurityControlParameter>() : null;

        /// <summary>
        /// Checks to see if the SecurityControlParameters property is set.
        /// </summary>
        internal bool IsSetSecurityControlParameters() => this.SecurityControlParameters != null && (this.SecurityControlParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Typically summarizes the result of a control check.
        /// </para>
        ///  
        /// <para>
        /// For Security Hub CSPM controls, valid values for <c>Status</c> are as follows.
        /// </para>
        ///  <ul> <li> <ul> <li> 
        /// <para>
        ///  <c>PASSED</c> - Standards check passed for all evaluated resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARNING</c> - Some information is missing or this check is not supported for your
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Standards check failed for at least one evaluated resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_AVAILABLE</c> - Check could not be performed due to a service outage, API
        /// error, or because the result of the Config evaluation was <c>NOT_APPLICABLE</c>. If
        /// the Config evaluation result was <c>NOT_APPLICABLE</c> for a Security Hub CSPM control,
        /// Security Hub CSPM automatically archives the finding after 3 days.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ComplianceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Typically used to provide a list of reasons for the value of <c>Status</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatusReason> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<StatusReason>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
