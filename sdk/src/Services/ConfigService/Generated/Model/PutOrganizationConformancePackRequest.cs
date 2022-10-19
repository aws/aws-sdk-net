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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutOrganizationConformancePack operation.
    /// Deploys conformance packs across member accounts in an Amazon Web Services Organization.
    /// For information on how many organization conformance packs and how many Config rules
    /// you can have per account, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/configlimits.html">
    /// <b>Service Limits</b> </a> in the Config Developer Guide.
    /// 
    ///  
    /// <para>
    /// Only a management account and a delegated administrator can call this API. When calling
    /// this API with a delegated administrator, you must ensure Organizations <code>ListDelegatedAdministrator</code>
    /// permissions are added. An organization can have up to 3 delegated administrators.
    /// </para>
    ///  
    /// <para>
    /// This API enables organization service access for <code>config-multiaccountsetup.amazonaws.com</code>
    /// through the <code>EnableAWSServiceAccess</code> action and creates a service-linked
    /// role <code>AWSServiceRoleForConfigMultiAccountSetup</code> in the management or delegated
    /// administrator account of your organization. The service-linked role is created only
    /// when the role does not exist in the caller account. To use this API with delegated
    /// administrator, register a delegated administrator by calling Amazon Web Services Organization
    /// <code>register-delegate-admin</code> for <code>config-multiaccountsetup.amazonaws.com</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Prerequisite: Ensure you call <code>EnableAllFeatures</code> API to enable all features
    /// in an organization.
    /// </para>
    ///  
    /// <para>
    /// You must specify either the <code>TemplateS3Uri</code> or the <code>TemplateBody</code>
    /// parameter, but not both. If you provide both Config uses the <code>TemplateS3Uri</code>
    /// parameter and ignores the <code>TemplateBody</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// Config sets the state of a conformance pack to CREATE_IN_PROGRESS and UPDATE_IN_PROGRESS
    /// until the conformance pack is created or updated. You cannot update a conformance
    /// pack while it is in this state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutOrganizationConformancePackRequest : AmazonConfigServiceRequest
    {
        private List<ConformancePackInputParameter> _conformancePackInputParameters = new List<ConformancePackInputParameter>();
        private string _deliveryS3Bucket;
        private string _deliveryS3KeyPrefix;
        private List<string> _excludedAccounts = new List<string>();
        private string _organizationConformancePackName;
        private string _templateBody;
        private string _templateS3Uri;

        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <code>ConformancePackInputParameter</code> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters
        {
            get { return this._conformancePackInputParameters; }
            set { this._conformancePackInputParameters = value; }
        }

        // Check to see if ConformancePackInputParameters property is set
        internal bool IsSetConformancePackInputParameters()
        {
            return this._conformancePackInputParameters != null && this._conformancePackInputParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where Config stores conformance pack templates.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional. If used, it must be prefixed with <code>awsconfigconforms</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string DeliveryS3Bucket
        {
            get { return this._deliveryS3Bucket; }
            set { this._deliveryS3Bucket = value; }
        }

        // Check to see if DeliveryS3Bucket property is set
        internal bool IsSetDeliveryS3Bucket()
        {
            return this._deliveryS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3KeyPrefix. 
        /// <para>
        /// The prefix for the Amazon S3 bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DeliveryS3KeyPrefix
        {
            get { return this._deliveryS3KeyPrefix; }
            set { this._deliveryS3KeyPrefix = value; }
        }

        // Check to see if DeliveryS3KeyPrefix property is set
        internal bool IsSetDeliveryS3KeyPrefix()
        {
            return this._deliveryS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A list of Amazon Web Services accounts to be excluded from an organization conformance
        /// pack while deploying a conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ExcludedAccounts
        {
            get { return this._excludedAccounts; }
            set { this._excludedAccounts = value; }
        }

        // Check to see if ExcludedAccounts property is set
        internal bool IsSetExcludedAccounts()
        {
            return this._excludedAccounts != null && this._excludedAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackName. 
        /// <para>
        /// Name of the organization conformance pack you want to create.
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

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// A string containing full conformance pack template body. Structure containing the
        /// template body with a minimum length of 1 byte and a maximum length of 51,200 bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=51200)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateS3Uri. 
        /// <para>
        /// Location of file containing the template body. The uri must point to the conformance
        /// pack template (max size: 300 KB).
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have access to read Amazon S3 bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TemplateS3Uri
        {
            get { return this._templateS3Uri; }
            set { this._templateS3Uri = value; }
        }

        // Check to see if TemplateS3Uri property is set
        internal bool IsSetTemplateS3Uri()
        {
            return this._templateS3Uri != null;
        }

    }
}