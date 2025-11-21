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
    public partial class SparkEmrPropertiesInput
    {
        private string _computeArn;
        private string _instanceProfileArn;
        private string _javaVirtualEnv;
        private string _logUri;
        private string _managedEndpointArn;
        private string _pythonVirtualEnv;
        private string _runtimeRole;
        private string _trustedCertificatesS3Uri;

        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The compute ARN of Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The instance profile ARN of Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The java virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The log URI of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property PythonVirtualEnv. 
        /// <para>
        /// The Python virtual env of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The certificates S3 URI of the Spark EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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