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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The wrapper that contains the Amazon Web Services accounts and services that are
    /// in scope for the assessment.
    /// </summary>
    public partial class Scope
    {
        private List<AWSAccount> _awsAccounts = AWSConfigs.InitializeCollections ? new List<AWSAccount>() : null;
        private List<AWSService> _awsServices = AWSConfigs.InitializeCollections ? new List<AWSService>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccounts. 
        /// <para>
        ///  The Amazon Web Services accounts that are included in the scope of the assessment.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public List<AWSAccount> AwsAccounts
        {
            get { return this._awsAccounts; }
            set { this._awsAccounts = value; }
        }

        // Check to see if AwsAccounts property is set
        internal bool IsSetAwsAccounts()
        {
            return this._awsAccounts != null && (this._awsAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        ///  The Amazon Web Services services that are included in the scope of the assessment.
        /// 
        /// </para>
        /// </summary>
        public List<AWSService> AwsServices
        {
            get { return this._awsServices; }
            set { this._awsServices = value; }
        }

        // Check to see if AwsServices property is set
        internal bool IsSetAwsServices()
        {
            return this._awsServices != null && (this._awsServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}