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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon EKS cluster.
    /// </summary>
    public partial class AwsEksClusterDetails
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the cluster.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityData. 
        /// <para>
        /// The certificate authority data for the cluster.
        /// </para>
        /// </summary>
        public string CertificateAuthorityData { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityData property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityData() => this.CertificateAuthorityData != null;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the cluster. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterStatus property is set.
        /// </summary>
        internal bool IsSetClusterStatus() => this.ClusterStatus != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the Amazon EKS API server.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for the cluster.
        /// </para>
        /// </summary>
        public AwsEksClusterLoggingDetails Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourcesVpcConfig. 
        /// <para>
        /// The VPC configuration used by the cluster control plane.
        /// </para>
        /// </summary>
        public AwsEksClusterResourcesVpcConfigDetails ResourcesVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesVpcConfig property is set.
        /// </summary>
        internal bool IsSetResourcesVpcConfig() => this.ResourcesVpcConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides permissions for the Amazon EKS control plane
        /// to make calls to Amazon Web Services API operations on your behalf.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Amazon EKS server version for the cluster.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
