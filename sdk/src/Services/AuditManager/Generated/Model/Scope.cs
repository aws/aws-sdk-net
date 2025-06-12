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
    /// The wrapper that contains the Amazon Web Services accounts that are in scope for
    /// the assessment. 
    /// 
    ///  <note> 
    /// <para>
    /// You no longer need to specify which Amazon Web Services services are in scope when
    /// you create or update an assessment. Audit Manager infers the services in scope by
    /// examining your assessment controls and their data sources, and then mapping this information
    /// to the relevant Amazon Web Services services. 
    /// </para>
    ///  
    /// <para>
    /// If an underlying data source changes for your assessment, we automatically update
    /// the services scope as needed to reflect the correct Amazon Web Services services.
    /// This ensures that your assessment collects accurate and comprehensive evidence about
    /// all of the relevant services in your AWS environment.
    /// </para>
    ///  </note>
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        ///  <important> 
        /// <para>
        /// This API parameter is no longer supported. If you use this parameter to specify one
        /// or more Amazon Web Services services, Audit Manager ignores this input. Instead, the
        /// value for <c>awsServices</c> will show as empty.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("You can't specify services in scope when creating/updating an assessment. If you use the parameter to specify one or more AWS services, Audit Manager ignores the input. Instead the value of the parameter will show as empty indicating that the services are defined and managed by Audit Manager.")]
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