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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// AWS resource configurations associated with the agent space
    /// </summary>
    public partial class AWSResources
    {
        private List<string> _iamRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _lambdaFunctionArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _s3Buckets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _secretArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<VpcConfig> _vpcs = AWSConfigs.InitializeCollections ? new List<VpcConfig>() : null;

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// IAM role ARNs that the Security Agent can assume to access customer resources
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && (this._iamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionArns. 
        /// <para>
        /// Lambda function ARNs or names used to retrieve tester credentials for pentests
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LambdaFunctionArns
        {
            get { return this._lambdaFunctionArns; }
            set { this._lambdaFunctionArns = value; }
        }

        // Check to see if LambdaFunctionArns property is set
        internal bool IsSetLambdaFunctionArns()
        {
            return this._lambdaFunctionArns != null && (this._lambdaFunctionArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogGroups. 
        /// <para>
        /// CloudWatch log group ARNs or names used to store Security Agent logs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogGroups
        {
            get { return this._logGroups; }
            set { this._logGroups = value; }
        }

        // Check to see if LogGroups property is set
        internal bool IsSetLogGroups()
        {
            return this._logGroups != null && (this._logGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Buckets. 
        /// <para>
        /// S3 bucket ARNs or names used to store Security Agent artifacts
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> S3Buckets
        {
            get { return this._s3Buckets; }
            set { this._s3Buckets = value; }
        }

        // Check to see if S3Buckets property is set
        internal bool IsSetS3Buckets()
        {
            return this._s3Buckets != null && (this._s3Buckets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecretArns. 
        /// <para>
        /// SecretsManager secret ARNs or names used to store tester credentials for pentests
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecretArns
        {
            get { return this._secretArns; }
            set { this._secretArns = value; }
        }

        // Check to see if SecretArns property is set
        internal bool IsSetSecretArns()
        {
            return this._secretArns != null && (this._secretArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Vpcs. 
        /// <para>
        /// VPC configurations that the Security Agent accesses in the customer environment
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcConfig> Vpcs
        {
            get { return this._vpcs; }
            set { this._vpcs = value; }
        }

        // Check to see if Vpcs property is set
        internal bool IsSetVpcs()
        {
            return this._vpcs != null && (this._vpcs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}