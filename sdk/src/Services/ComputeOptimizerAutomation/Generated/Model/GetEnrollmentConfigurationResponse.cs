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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// This is the response object from the GetEnrollmentConfiguration operation.
    /// </summary>
    public partial class GetEnrollmentConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _lastUpdatedTimestamp;
        private OrganizationRuleMode _organizationRuleMode;
        private EnrollmentStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        ///  The timestamp of the last update to the enrollment configuration. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationRuleMode. 
        /// <para>
        /// Specifies whether the management account can create Automation rules that implement
        /// optimization actions for this account. 
        /// </para>
        /// </summary>
        public OrganizationRuleMode OrganizationRuleMode
        {
            get { return this._organizationRuleMode; }
            set { this._organizationRuleMode = value; }
        }

        // Check to see if OrganizationRuleMode property is set
        internal bool IsSetOrganizationRuleMode()
        {
            return this._organizationRuleMode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current enrollment status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrollmentStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The reason for the current enrollment status. 
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}