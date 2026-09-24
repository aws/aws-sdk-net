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
    public partial class SparkEmrPropertiesInput
    {
        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The compute ARN of Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ComputeArn { get; set; }

        /// <summary>
        /// Checks to see if the ComputeArn property is set.
        /// </summary>
        internal bool IsSetComputeArn() => this.ComputeArn != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The instance profile ARN of Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string InstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetInstanceProfileArn() => this.InstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property JavaVirtualEnv. 
        /// <para>
        /// The java virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string JavaVirtualEnv { get; set; }

        /// <summary>
        /// Checks to see if the JavaVirtualEnv property is set.
        /// </summary>
        internal bool IsSetJavaVirtualEnv() => this.JavaVirtualEnv != null;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The log URI of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
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
        /// Gets and sets the property PythonVirtualEnv. 
        /// <para>
        /// The Python virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
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
        /// The certificates S3 URI of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string TrustedCertificatesS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the TrustedCertificatesS3Uri property is set.
        /// </summary>
        internal bool IsSetTrustedCertificatesS3Uri() => this.TrustedCertificatesS3Uri != null;
    }
}
