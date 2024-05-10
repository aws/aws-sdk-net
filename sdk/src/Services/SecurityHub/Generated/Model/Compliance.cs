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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// Contains finding details that are specific to control-based findings. Only returned
    /// for findings generated from controls.
    /// </summary>
    public partial class Compliance
    {
        private List<AssociatedStandard> _associatedStandards = AWSConfigs.InitializeCollections ? new List<AssociatedStandard>() : null;
        private List<string> _relatedRequirements = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _securityControlId;
        private List<SecurityControlParameter> _securityControlParameters = AWSConfigs.InitializeCollections ? new List<SecurityControlParameter>() : null;
        private ComplianceStatus _status;
        private List<StatusReason> _statusReasons = AWSConfigs.InitializeCollections ? new List<StatusReason>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedStandards. 
        /// <para>
        /// The enabled security standards in which a security control is currently enabled. 
        /// </para>
        /// </summary>
        public List<AssociatedStandard> AssociatedStandards
        {
            get { return this._associatedStandards; }
            set { this._associatedStandards = value; }
        }

        // Check to see if AssociatedStandards property is set
        internal bool IsSetAssociatedStandards()
        {
            return this._associatedStandards != null && (this._associatedStandards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelatedRequirements. 
        /// <para>
        /// For a control, the industry or regulatory framework requirements that are related
        /// to the control. The check for that control is aligned with these requirements.
        /// </para>
        /// </summary>
        public List<string> RelatedRequirements
        {
            get { return this._relatedRequirements; }
            set { this._relatedRequirements = value; }
        }

        // Check to see if RelatedRequirements property is set
        internal bool IsSetRelatedRequirements()
        {
            return this._relatedRequirements != null && (this._relatedRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The unique identifier of a control across standards. Values for this field typically
        /// consist of an Amazon Web Service and a number, such as APIGateway.5. 
        /// </para>
        /// </summary>
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityControlParameters. 
        /// <para>
        ///  An object that includes security control parameter names and values. 
        /// </para>
        /// </summary>
        public List<SecurityControlParameter> SecurityControlParameters
        {
            get { return this._securityControlParameters; }
            set { this._securityControlParameters = value; }
        }

        // Check to see if SecurityControlParameters property is set
        internal bool IsSetSecurityControlParameters()
        {
            return this._securityControlParameters != null && (this._securityControlParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result of a standards check.
        /// </para>
        ///  
        /// <para>
        /// The valid values for <c>Status</c> are as follows.
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
        /// the Config evaluation result was <c>NOT_APPLICABLE</c>, then after 3 days, Security
        /// Hub automatically archives the finding.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ComplianceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// For findings generated from controls, a list of reasons behind the value of <c>Status</c>.
        /// For the list of status reason codes and their meanings, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards-results.html#securityhub-standards-results-asff">Standards-related
        /// information in the ASFF</a> in the <i>Security Hub User Guide</i>. 
        /// </para>
        /// </summary>
        public List<StatusReason> StatusReasons
        {
            get { return this._statusReasons; }
            set { this._statusReasons = value; }
        }

        // Check to see if StatusReasons property is set
        internal bool IsSetStatusReasons()
        {
            return this._statusReasons != null && (this._statusReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}