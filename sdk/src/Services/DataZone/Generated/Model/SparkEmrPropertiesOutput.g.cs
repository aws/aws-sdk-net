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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CertificateData. 
        /// <para>
        /// The certificate data of the EMR on EKS cluster.
        /// </para>
        /// </summary>
        public string CertificateData { get; set; }

        /// <summary>
        /// Checks to see if the CertificateData property is set.
        /// </summary>
        internal bool IsSetCertificateData() => this.CertificateData != null;

        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The compute ARN of the Spark EMR.
        /// </para>
        /// </summary>
        public string ComputeArn { get; set; }

        /// <summary>
        /// Checks to see if the ComputeArn property is set.
        /// </summary>
        internal bool IsSetComputeArn() => this.ComputeArn != null;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public UsernamePassword Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property CredentialsExpiration. 
        /// <para>
        /// The credential expiration of the Spark EMR.
        /// </para>
        /// </summary>
        public DateTime? CredentialsExpiration { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsExpiration property is set.
        /// </summary>
        internal bool IsSetCredentialsExpiration() => this.CredentialsExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property GovernanceType. 
        /// <para>
        /// The governance type of the Spark EMR.
        /// </para>
        /// </summary>
        public GovernanceType GovernanceType { get; set; }

        /// <summary>
        /// Checks to see if the GovernanceType property is set.
        /// </summary>
        internal bool IsSetGovernanceType() => this.GovernanceType != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The instance profile ARN of the Spark EMR.
        /// </para>
        /// </summary>
        public string InstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetInstanceProfileArn() => this.InstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property JavaVirtualEnv. 
        /// <para>
        /// The Java virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        public string JavaVirtualEnv { get; set; }

        /// <summary>
        /// Checks to see if the JavaVirtualEnv property is set.
        /// </summary>
        internal bool IsSetJavaVirtualEnv() => this.JavaVirtualEnv != null;

        /// <summary>
        /// Gets and sets the property LivyEndpoint. 
        /// <para>
        /// The livy endpoint of the Spark EMR.
        /// </para>
        /// </summary>
        public string LivyEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the LivyEndpoint property is set.
        /// </summary>
        internal bool IsSetLivyEndpoint() => this.LivyEndpoint != null;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The log URI of the Spark EMR.
        /// </para>
        /// </summary>
        public string LogUri { get; set; }

        /// <summary>
        /// Checks to see if the LogUri property is set.
        /// </summary>
        internal bool IsSetLogUri() => this.LogUri != null;

        /// <summary>
        /// Gets and sets the property ManagedEndpointArn. 
        /// <para>
        /// The managed endpoint ARN of the EMR on EKS cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ManagedEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedEndpointArn property is set.
        /// </summary>
        internal bool IsSetManagedEndpointArn() => this.ManagedEndpointArn != null;

        /// <summary>
        /// Gets and sets the property ManagedEndpointCredentials. 
        /// <para>
        /// The managed endpoint credentials of the EMR on EKS cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ManagedEndpointCredentials ManagedEndpointCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ManagedEndpointCredentials property is set.
        /// </summary>
        internal bool IsSetManagedEndpointCredentials() => this.ManagedEndpointCredentials != null;

        /// <summary>
        /// Gets and sets the property PythonVirtualEnv. 
        /// <para>
        /// The Python virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        public string PythonVirtualEnv { get; set; }

        /// <summary>
        /// Checks to see if the PythonVirtualEnv property is set.
        /// </summary>
        internal bool IsSetPythonVirtualEnv() => this.PythonVirtualEnv != null;

        /// <summary>
        /// Gets and sets the property RuntimeRole. 
        /// <para>
        /// The runtime role of the Spark EMR.
        /// </para>
        /// </summary>
        public string RuntimeRole { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeRole property is set.
        /// </summary>
        internal bool IsSetRuntimeRole() => this.RuntimeRole != null;

        /// <summary>
        /// Gets and sets the property TrustedCertificatesS3Uri. 
        /// <para>
        /// The trusted certificate S3 URL of the Spark EMR.
        /// </para>
        /// </summary>
        public string TrustedCertificatesS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the TrustedCertificatesS3Uri property is set.
        /// </summary>
        internal bool IsSetTrustedCertificatesS3Uri() => this.TrustedCertificatesS3Uri != null;
    }
}
