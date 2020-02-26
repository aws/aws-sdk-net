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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Exclusive to findings that are generated as the result of a check run against a specific
    /// rule in a supported security standard, such as CIS AWS Foundations. Contains security
    /// standard-related finding details.
    /// 
    ///  
    /// <para>
    /// Values include the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Allowed values are the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>PASSED</code> - Standards check passed for all evaluated resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WARNING</code> - Some information is missing or this check is not supported
    /// given your configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>FAILED</code> - Standards check failed for at least one evaluated resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>NOT_AVAILABLE</code> - Check could not be performed due to a service outage,
    /// API error, or because the result of the AWS Config evaluation was <code>NOT_APPLICABLE</code>.
    /// If the AWS Config evaluation result was <code> NOT_APPLICABLE</code>, then after 3
    /// days, Security Hub automatically archives the finding.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class Compliance
    {
        private List<string> _relatedRequirements = new List<string>();
        private ComplianceStatus _status;

        /// <summary>
        /// Gets and sets the property RelatedRequirements. 
        /// <para>
        /// List of requirements that are related to a standards control.
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
            return this._relatedRequirements != null && this._relatedRequirements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result of a standards check.
        /// </para>
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

    }
}