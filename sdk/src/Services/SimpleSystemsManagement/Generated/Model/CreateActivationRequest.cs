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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateActivation operation.
    /// Generates an activation code and activation ID you can use to register your on-premises
    /// server or virtual machine (VM) with Systems Manager. Registering these machines with
    /// Systems Manager makes it possible to manage them using Systems Manager capabilities.
    /// You use the activation code and ID when installing SSM Agent on machines in your hybrid
    /// environment. For more information about requirements for managing on-premises instances
    /// and VMs using Systems Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
    /// up AWS Systems Manager for hybrid environments</a> in the <i>AWS Systems Manager User
    /// Guide</i>. 
    /// 
    ///  <note> 
    /// <para>
    /// On-premises servers or VMs that are registered with Systems Manager and EC2 instances
    /// that you manage with Systems Manager are all called <i>managed instances</i>.
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
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DefaultInstanceName. 
        /// <para>
        /// The name of the registered, managed instance as it will appear in the Systems Manager
        /// console or when you use the AWS command line tools to list Systems Manager resources.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not enter personally identifiable information in this field.
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
        /// Do not enter personally identifiable information in this field.
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
        /// The date by which this activation request should expire. The default value is 24 hours.
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
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
        /// The Amazon Identity and Access Management (IAM) role that you want to assign to the
        /// managed instance. This IAM role must provide AssumeRole permissions for the Systems
        /// Manager service principal <code>ssm.amazonaws.com</code>. For more information, see
        /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-service-role.html">Create
        /// an IAM service role for a hybrid environment</a> in the <i>AWS Systems Manager User
        /// Guide</i>.
        /// </para>
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
        /// Specify the maximum number of managed instances you want to register. The default
        /// value is 1 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int RegistrationLimit
        {
            get { return this._registrationLimit.GetValueOrDefault(); }
            set { this._registrationLimit = value; }
        }

        // Check to see if RegistrationLimit property is set
        internal bool IsSetRegistrationLimit()
        {
            return this._registrationLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag an activation to identify which servers or virtual machines (VMs) in your
        /// on-premises environment you intend to activate. In this case, you could specify the
        /// following key name/value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key=OS,Value=Windows</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Environment,Value=Production</code> 
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
        /// on-premises servers and VMs after they connect to Systems Manager for the first time
        /// and are assigned a managed instance ID. This means they are listed in the AWS Systems
        /// Manager console with an ID that is prefixed with "mi-". For information about how
        /// to add tags to your managed instances, see <a>AddTagsToResource</a>. For information
        /// about how to remove tags from your managed instances, see <a>RemoveTagsFromResource</a>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}