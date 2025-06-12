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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateActivation operation.
    /// Generates an activation code and activation ID you can use to register your on-premises
    /// servers, edge devices, or virtual machine (VM) with Amazon Web Services Systems Manager.
    /// Registering these machines with Systems Manager makes it possible to manage them using
    /// Systems Manager tools. You use the activation code and ID when installing SSM Agent
    /// on machines in your hybrid environment. For more information about requirements for
    /// managing on-premises machines using Systems Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-hybrid-multicloud.html">Using
    /// Amazon Web Services Systems Manager in hybrid and multicloud environments</a> in the
    /// <i>Amazon Web Services Systems Manager User Guide</i>. 
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) instances, edge devices, and on-premises
    /// servers and VMs that are configured for Systems Manager are all called <i>managed
    /// nodes</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateActivationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _defaultInstanceName;
        private string _description;
        private DateTime? _expirationDate;
        private string _iamRole;
        private int? _registrationLimit;
        private List<RegistrationMetadataItem> _registrationMetadata = AWSConfigs.InitializeCollections ? new List<RegistrationMetadataItem>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DefaultInstanceName. 
        /// <para>
        /// The name of the registered, managed node as it will appear in the Amazon Web Services
        /// Systems Manager console or when you use the Amazon Web Services command line tools
        /// to list Systems Manager resources.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DefaultInstanceName
        {
            get { return this._defaultInstanceName; }
            set { this._defaultInstanceName = value; }
        }

        // Check to see if DefaultInstanceName property is set
        internal bool IsSetDefaultInstanceName()
        {
            return this._defaultInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-defined description of the resource that you want to register with Systems
        /// Manager. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date by which this activation request should expire, in timestamp format, such
        /// as "2024-07-07T00:00:00". You can specify a date up to 30 days in advance. If you
        /// don't provide an expiration date, the activation code expires in 24 hours.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The name of the Identity and Access Management (IAM) role that you want to assign
        /// to the managed node. This IAM role must provide AssumeRole permissions for the Amazon
        /// Web Services Systems Manager service principal <c>ssm.amazonaws.com</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/hybrid-multicloud-service-role.html">Create
        /// the IAM service role required for Systems Manager in a hybrid and multicloud environments</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify an IAM service-linked role for this parameter. You must create a
        /// unique role.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationLimit. 
        /// <para>
        /// Specify the maximum number of managed nodes you want to register. The default value
        /// is <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? RegistrationLimit
        {
            get { return this._registrationLimit; }
            set { this._registrationLimit = value; }
        }

        // Check to see if RegistrationLimit property is set
        internal bool IsSetRegistrationLimit()
        {
            return this._registrationLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationMetadata. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegistrationMetadataItem> RegistrationMetadata
        {
            get { return this._registrationMetadata; }
            set { this._registrationMetadata = value; }
        }

        // Check to see if RegistrationMetadata property is set
        internal bool IsSetRegistrationMetadata()
        {
            return this._registrationMetadata != null && (this._registrationMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag an activation to identify which servers or virtual machines (VMs) in your
        /// on-premises environment you intend to activate. In this case, you could specify the
        /// following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key=OS,Value=Windows</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Environment,Value=Production</c> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When you install SSM Agent on your on-premises servers and VMs, you specify an activation
        /// ID and code. When you specify the activation ID and code, tags assigned to the activation
        /// are automatically applied to the on-premises servers or VMs.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can't add tags to or delete tags from an existing activation. You can tag your
        /// on-premises servers, edge devices, and VMs after they connect to Systems Manager for
        /// the first time and are assigned a managed node ID. This means they are listed in the
        /// Amazon Web Services Systems Manager console with an ID that is prefixed with "mi-".
        /// For information about how to add tags to your managed nodes, see <a>AddTagsToResource</a>.
        /// For information about how to remove tags from your managed nodes, see <a>RemoveTagsFromResource</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}