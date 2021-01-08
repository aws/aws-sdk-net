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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the DescribeOrganizationConfiguration operation.
    /// </summary>
    public partial class DescribeOrganizationConfigurationResponse : AmazonWebServiceResponse
    {
        private bool? _autoEnable;
        private OrganizationDataSourceConfigurationsResult _dataSources;
        private bool? _memberAccountLimitReached;

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Indicates whether GuardDuty is automatically enabled for accounts added to the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AutoEnable
        {
            get { return this._autoEnable.GetValueOrDefault(); }
            set { this._autoEnable = value; }
        }

        // Check to see if AutoEnable property is set
        internal bool IsSetAutoEnable()
        {
            return this._autoEnable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Describes which data sources are enabled automatically for member accounts.
        /// </para>
        /// </summary>
        public OrganizationDataSourceConfigurationsResult DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null;
        }

        /// <summary>
        /// Gets and sets the property MemberAccountLimitReached. 
        /// <para>
        /// Indicates whether the maximum number of allowed member accounts are already associated
        /// with the delegated administrator account for your organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool MemberAccountLimitReached
        {
            get { return this._memberAccountLimitReached.GetValueOrDefault(); }
            set { this._memberAccountLimitReached = value; }
        }

        // Check to see if MemberAccountLimitReached property is set
        internal bool IsSetMemberAccountLimitReached()
        {
            return this._memberAccountLimitReached.HasValue; 
        }

    }
}