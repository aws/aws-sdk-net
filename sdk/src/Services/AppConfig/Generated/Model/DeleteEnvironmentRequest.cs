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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEnvironment operation.
    /// Deletes an environment.
    /// 
    ///  
    /// <para>
    /// To prevent users from unintentionally deleting actively-used environments, enable
    /// <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/deletion-protection.html">deletion
    /// protection</a>.
    /// </para>
    /// </summary>
    public partial class DeleteEnvironmentRequest : AmazonAppConfigRequest
    {
        private string _applicationId;
        private DeletionProtectionCheck _deletionProtectionCheck;
        private string _environmentId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID that includes the environment that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionCheck. 
        /// <para>
        /// A parameter to configure deletion protection. Deletion protection prevents a user
        /// from deleting an environment if your application called either <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
        /// or in the environment during the specified interval. 
        /// </para>
        ///  
        /// <para>
        /// This parameter supports the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BYPASS</c>: Instructs AppConfig to bypass the deletion protection check and delete
        /// a configuration profile even if deletion protection would have otherwise prevented
        /// it. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLY</c>: Instructs the deletion protection check to run, even if deletion protection
        /// is disabled at the account level. <c>APPLY</c> also forces the deletion protection
        /// check to run against resources created in the past hour, which are normally excluded
        /// from deletion protection checks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT_DEFAULT</c>: The default setting, which instructs AppConfig to implement
        /// the deletion protection value specified in the <c>UpdateAccountSettings</c> API.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeletionProtectionCheck DeletionProtectionCheck
        {
            get { return this._deletionProtectionCheck; }
            set { this._deletionProtectionCheck = value; }
        }

        // Check to see if DeletionProtectionCheck property is set
        internal bool IsSetDeletionProtectionCheck()
        {
            return this._deletionProtectionCheck != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

    }
}