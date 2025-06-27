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
    /// Container for the parameters to the PutOrganizationConformancePack operation.
    /// Deploys conformance packs across member accounts in an Amazon Web Services Organization.
    /// For information on how many organization conformance packs and how many Config rules
    /// you can have per account, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/configlimits.html">
    /// <b>Service Limits</b> </a> in the <i>Config Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// Only a management account and a delegated administrator can call this API. When calling
    /// this API with a delegated administrator, you must ensure Organizations <c>ListDelegatedAdministrator</c>
    /// permissions are added. An organization can have up to 3 delegated administrators.
    /// </para>
    ///  <important> 
    /// <para>
    /// When you use <c>PutOrganizationConformancePack</c> to deploy conformance packs across
    /// member accounts, the operation can create Config rules and remediation actions without
    /// requiring <c>config:PutConfigRule</c> or <c>config:PutRemediationConfigurations</c>
    /// permissions in member account IAM policies.
    /// </para>
    ///  
    /// <para>
    /// This API uses the <c>AWSServiceRoleForConfigConforms</c> service-linked role in each
    /// member account to create conformance pack resources. This service-linked role includes
    /// the permissions to create Config rules and remediation configurations, even if member
    /// account IAM policies explicitly deny these actions.
    /// </para>
    ///  </important> 
    /// <para>
    /// This API enables organization service access for <c>config-multiaccountsetup.amazonaws.com</c>
    /// through the <c>EnableAWSServiceAccess</c> action and creates a service-linked role
    /// <c>AWSServiceRoleForConfigMultiAccountSetup</c> in the management or delegated administrator
    /// account of your organization. The service-linked role is created only when the role
    /// does not exist in the caller account. To use this API with delegated administrator,
    /// register a delegated administrator by calling Amazon Web Services Organization <c>register-delegate-admin</c>
    /// for <c>config-multiaccountsetup.amazonaws.com</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Prerequisite: Ensure you call <c>EnableAllFeatures</c> API to enable all features
    /// in an organization.
    /// </para>
    ///  
    /// <para>
    /// You must specify either the <c>TemplateS3Uri</c> or the <c>TemplateBody</c> parameter,
    /// but not both. If you provide both Config uses the <c>TemplateS3Uri</c> parameter and
    /// ignores the <c>TemplateBody</c> parameter.
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
        private List<ConformancePackInputParameter> _conformancePackInputParameters = AWSConfigs.InitializeCollections ? new List<ConformancePackInputParameter>() : null;
        private string _deliveryS3Bucket;
        private string _deliveryS3KeyPrefix;
        private List<string> _excludedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _organizationConformancePackName;
        private string _templateBody;
        private string _templateS3Uri;

        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <c>ConformancePackInputParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._conformancePackInputParameters != null && (this._conformancePackInputParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where Config stores conformance pack templates.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional. If used, it must be prefixed with <c>awsconfigconforms</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._excludedAccounts != null && (this._excludedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// A string that contains the full conformance pack template body. Structure containing
        /// the template body with a minimum length of 1 byte and a maximum length of 51,200 bytes.
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
        /// You must have access to read Amazon S3 bucket. In addition, in order to ensure a successful
        /// deployment, the template object must not be in an <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-class-intro.html">archived
        /// storage class</a> if this parameter is passed.
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