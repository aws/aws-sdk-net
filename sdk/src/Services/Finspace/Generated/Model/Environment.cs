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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Represents an FinSpace environment.
    /// </summary>
    public partial class Environment
    {
        private string _awsAccountId;
        private string _dedicatedServiceAccountId;
        private string _description;
        private string _environmentArn;
        private string _environmentId;
        private string _environmentUrl;
        private FederationMode _federationMode;
        private FederationParameters _federationParameters;
        private string _kmsKeyId;
        private string _name;
        private string _sageMakerStudioDomainUrl;
        private EnvironmentStatus _status;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the AWS account in which the FinSpace environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedServiceAccountId. 
        /// <para>
        /// The AWS account ID of the dedicated service account associated with your FinSpace
        /// environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DedicatedServiceAccountId
        {
            get { return this._dedicatedServiceAccountId; }
            set { this._dedicatedServiceAccountId = value; }
        }

        // Check to see if DedicatedServiceAccountId property is set
        internal bool IsSetDedicatedServiceAccountId()
        {
            return this._dedicatedServiceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EnvironmentArn
        {
            get { return this._environmentArn; }
            set { this._environmentArn = value; }
        }

        // Check to see if EnvironmentArn property is set
        internal bool IsSetEnvironmentArn()
        {
            return this._environmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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

        /// <summary>
        /// Gets and sets the property EnvironmentUrl. 
        /// <para>
        /// The sign-in URL for the web application of your FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string EnvironmentUrl
        {
            get { return this._environmentUrl; }
            set { this._environmentUrl = value; }
        }

        // Check to see if EnvironmentUrl property is set
        internal bool IsSetEnvironmentUrl()
        {
            return this._environmentUrl != null;
        }

        /// <summary>
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// The authentication mode for the environment.
        /// </para>
        /// </summary>
        public FederationMode FederationMode
        {
            get { return this._federationMode; }
            set { this._federationMode = value; }
        }

        // Check to see if FederationMode property is set
        internal bool IsSetFederationMode()
        {
            return this._federationMode != null;
        }

        /// <summary>
        /// Gets and sets the property FederationParameters. 
        /// <para>
        /// Configuration information when authentication mode is FEDERATED.
        /// </para>
        /// </summary>
        public FederationParameters FederationParameters
        {
            get { return this._federationParameters; }
            set { this._federationParameters = value; }
        }

        // Check to see if FederationParameters property is set
        internal bool IsSetFederationParameters()
        {
            return this._federationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key id used to encrypt in the FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerStudioDomainUrl. 
        /// <para>
        /// The URL of the integrated FinSpace notebook environment in your web application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string SageMakerStudioDomainUrl
        {
            get { return this._sageMakerStudioDomainUrl; }
            set { this._sageMakerStudioDomainUrl = value; }
        }

        // Check to see if SageMakerStudioDomainUrl property is set
        internal bool IsSetSageMakerStudioDomainUrl()
        {
            return this._sageMakerStudioDomainUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of creation of the FinSpace environment.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}