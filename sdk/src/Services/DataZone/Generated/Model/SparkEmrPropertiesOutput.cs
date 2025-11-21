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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Spark EMR properties.
    /// </summary>
    public partial class SparkEmrPropertiesOutput
    {
        private string _certificateData;
        private string _computeArn;
        private UsernamePassword _credentials;
        private DateTime? _credentialsExpiration;
        private GovernanceType _governanceType;
        private string _instanceProfileArn;
        private string _javaVirtualEnv;
        private string _livyEndpoint;
        private string _logUri;
        private string _managedEndpointArn;
        private ManagedEndpointCredentials _managedEndpointCredentials;
        private string _pythonVirtualEnv;
        private string _runtimeRole;
        private string _trustedCertificatesS3Uri;

        /// <summary>
        /// Gets and sets the property CertificateData. 
        /// <para>
        /// The certificate data of the EMR on EKS cluster.
        /// </para>
        /// </summary>
        public string CertificateData
        {
            get { return this._certificateData; }
            set { this._certificateData = value; }
        }

        // Check to see if CertificateData property is set
        internal bool IsSetCertificateData()
        {
            return this._certificateData != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The compute ARN of the Spark EMR.
        /// </para>
        /// </summary>
        public string ComputeArn
        {
            get { return this._computeArn; }
            set { this._computeArn = value; }
        }

        // Check to see if ComputeArn property is set
        internal bool IsSetComputeArn()
        {
            return this._computeArn != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public UsernamePassword Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsExpiration. 
        /// <para>
        /// The credential expiration of the Spark EMR.
        /// </para>
        /// </summary>
        public DateTime? CredentialsExpiration
        {
            get { return this._credentialsExpiration; }
            set { this._credentialsExpiration = value; }
        }

        // Check to see if CredentialsExpiration property is set
        internal bool IsSetCredentialsExpiration()
        {
            return this._credentialsExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GovernanceType. 
        /// <para>
        /// The governance type of the Spark EMR.
        /// </para>
        /// </summary>
        public GovernanceType GovernanceType
        {
            get { return this._governanceType; }
            set { this._governanceType = value; }
        }

        // Check to see if GovernanceType property is set
        internal bool IsSetGovernanceType()
        {
            return this._governanceType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The instance profile ARN of the Spark EMR.
        /// </para>
        /// </summary>
        public string InstanceProfileArn
        {
            get { return this._instanceProfileArn; }
            set { this._instanceProfileArn = value; }
        }

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this._instanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property JavaVirtualEnv. 
        /// <para>
        /// The Java virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        public string JavaVirtualEnv
        {
            get { return this._javaVirtualEnv; }
            set { this._javaVirtualEnv = value; }
        }

        // Check to see if JavaVirtualEnv property is set
        internal bool IsSetJavaVirtualEnv()
        {
            return this._javaVirtualEnv != null;
        }

        /// <summary>
        /// Gets and sets the property LivyEndpoint. 
        /// <para>
        /// The livy endpoint of the Spark EMR.
        /// </para>
        /// </summary>
        public string LivyEndpoint
        {
            get { return this._livyEndpoint; }
            set { this._livyEndpoint = value; }
        }

        // Check to see if LivyEndpoint property is set
        internal bool IsSetLivyEndpoint()
        {
            return this._livyEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The log URI of the Spark EMR.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedEndpointArn. 
        /// <para>
        /// The managed endpoint ARN of the EMR on EKS cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ManagedEndpointArn
        {
            get { return this._managedEndpointArn; }
            set { this._managedEndpointArn = value; }
        }

        // Check to see if ManagedEndpointArn property is set
        internal bool IsSetManagedEndpointArn()
        {
            return this._managedEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedEndpointCredentials. 
        /// <para>
        /// The managed endpoint credentials of the EMR on EKS cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ManagedEndpointCredentials ManagedEndpointCredentials
        {
            get { return this._managedEndpointCredentials; }
            set { this._managedEndpointCredentials = value; }
        }

        // Check to see if ManagedEndpointCredentials property is set
        internal bool IsSetManagedEndpointCredentials()
        {
            return this._managedEndpointCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property PythonVirtualEnv. 
        /// <para>
        /// The Python virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        public string PythonVirtualEnv
        {
            get { return this._pythonVirtualEnv; }
            set { this._pythonVirtualEnv = value; }
        }

        // Check to see if PythonVirtualEnv property is set
        internal bool IsSetPythonVirtualEnv()
        {
            return this._pythonVirtualEnv != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeRole. 
        /// <para>
        /// The runtime role of the Spark EMR.
        /// </para>
        /// </summary>
        public string RuntimeRole
        {
            get { return this._runtimeRole; }
            set { this._runtimeRole = value; }
        }

        // Check to see if RuntimeRole property is set
        internal bool IsSetRuntimeRole()
        {
            return this._runtimeRole != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedCertificatesS3Uri. 
        /// <para>
        /// The trusted certificate S3 URL of the Spark EMR.
        /// </para>
        /// </summary>
        public string TrustedCertificatesS3Uri
        {
            get { return this._trustedCertificatesS3Uri; }
            set { this._trustedCertificatesS3Uri = value; }
        }

        // Check to see if TrustedCertificatesS3Uri property is set
        internal bool IsSetTrustedCertificatesS3Uri()
        {
            return this._trustedCertificatesS3Uri != null;
        }

    }
}