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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateActivation operation.
    /// Registers your on-premises server or virtual machine with Amazon EC2 so that you can
    /// manage these resources using Run Command. An on-premises server or virtual machine
    /// that has been registered with EC2 is called a managed instance. For more information
    /// about activations, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
    /// Up Systems Manager in Hybrid Environments</a>.
    /// </summary>
    public partial class CreateActivationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _defaultInstanceName;
        private string _description;
        private DateTime? _expirationDate;
        private string _iamRole;
        private int? _registrationLimit;

        /// <summary>
        /// Gets and sets the property DefaultInstanceName. 
        /// <para>
        /// The name of the registered, managed instance as it will appear in the Amazon EC2 console
        /// or when you use the AWS command line tools to list EC2 resources.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
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
        /// A user-defined description of the resource that you want to register with Amazon EC2.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
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
        /// managed instance. 
        /// </para>
        /// </summary>
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

    }
}