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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
    /// Container for the parameters to the DeleteOrganizationConformancePack operation.
    /// Deletes the specified organization conformance pack and all of the Config rules and
    /// remediation actions from all member accounts in that organization. 
    /// 
    ///  
    /// <para>
    ///  Only a management account or a delegated administrator account can delete an organization
    /// conformance pack. When calling this API with a delegated administrator, you must ensure
    /// Organizations <c>ListDelegatedAdministrator</c> permissions are added.
    /// </para>
    ///  
    /// <para>
    /// Config sets the state of a conformance pack to DELETE_IN_PROGRESS until the deletion
    /// is complete. You cannot update a conformance pack while it is in this state. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Recommendation: Consider excluding the <c>AWS::Config::ResourceCompliance</c>
    /// resource type from recording before deleting rules</b> 
    /// </para>
    ///  
    /// <para>
    /// Deleting rules creates configuration items (CIs) for <c>AWS::Config::ResourceCompliance</c>
    /// that can affect your costs for the configuration recorder. If you are deleting rules
    /// which evaluate a large number of resource types, this can lead to a spike in the number
    /// of CIs recorded.
    /// </para>
    ///  
    /// <para>
    /// To avoid the associated costs, you can opt to disable recording for the <c>AWS::Config::ResourceCompliance</c>
    /// resource type before deleting rules, and re-enable recording after the rules have
    /// been deleted.
    /// </para>
    ///  
    /// <para>
    /// However, since deleting rules is an asynchronous process, it might take an hour or
    /// more to complete. During the time when recording is disabled for <c>AWS::Config::ResourceCompliance</c>,
    /// rule evaluations will not be recorded in the associated resource’s history.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteOrganizationConformancePackRequest : AmazonConfigServiceRequest
    {
        private string _organizationConformancePackName;

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackName. 
        /// <para>
        /// The name of organization conformance pack that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OrganizationConformancePackName
        {
            get { return this._organizationConformancePackName; }
            set { this._organizationConformancePackName = value; }
        }

        // Check to see if OrganizationConformancePackName property is set
        internal bool IsSetOrganizationConformancePackName()
        {
            return this._organizationConformancePackName != null;
        }

    }
}