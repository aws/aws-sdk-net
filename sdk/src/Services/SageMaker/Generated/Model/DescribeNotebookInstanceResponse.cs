/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeNotebookInstance operation.
    /// </summary>
    public partial class DescribeNotebookInstanceResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private DirectInternetAccess _directInternetAccess;
        private string _failureReason;
        private InstanceType _instanceType;
        private string _kmsKeyId;
        private DateTime? _lastModifiedTime;
        private string _networkInterfaceId;
        private string _notebookInstanceArn;
        private string _notebookInstanceLifecycleConfigName;
        private string _notebookInstanceName;
        private NotebookInstanceStatus _notebookInstanceStatus;
        private string _roleArn;
        private List<string> _securityGroups = new List<string>();
        private string _subnetId;
        private string _url;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp. Use this parameter to return the time when the notebook instance was
        /// created
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectInternetAccess. 
        /// <para>
        /// Describes whether Amazon SageMaker provides internet access to the notebook instance.
        /// If this value is set to <i>Disabled, he notebook instance does not have internet access,
        /// and cannot connect to Amazon SageMaker training and endpoint services</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>appendix-notebook-and-internet-access</a>.
        /// </para>
        /// </summary>
        public DirectInternetAccess DirectInternetAccess
        {
            get { return this._directInternetAccess; }
            set { this._directInternetAccess = value; }
        }

        // Check to see if DirectInternetAccess property is set
        internal bool IsSetDirectInternetAccess()
        {
            return this._directInternetAccess != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If status is failed, the reason it failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of ML compute instance running on the notebook instance.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  AWS KMS key ID Amazon SageMaker uses to encrypt data when storing it on the ML storage
        /// volume attached to the instance. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp. Use this parameter to retrieve the time when the notebook instance was
        /// last modified. 
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        ///  Network interface IDs that Amazon SageMaker created at the time of creating the instance.
        /// 
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notebook instance.
        /// </para>
        /// </summary>
        public string NotebookInstanceArn
        {
            get { return this._notebookInstanceArn; }
            set { this._notebookInstanceArn = value; }
        }

        // Check to see if NotebookInstanceArn property is set
        internal bool IsSetNotebookInstanceArn()
        {
            return this._notebookInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// Returns the name of a notebook instance lifecycle configuration.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a>notebook-lifecycle-config</a>.
        /// </para>
        /// </summary>
        public string NotebookInstanceLifecycleConfigName
        {
            get { return this._notebookInstanceLifecycleConfigName; }
            set { this._notebookInstanceLifecycleConfigName = value; }
        }

        // Check to see if NotebookInstanceLifecycleConfigName property is set
        internal bool IsSetNotebookInstanceLifecycleConfigName()
        {
            return this._notebookInstanceLifecycleConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        ///  Name of the Amazon SageMaker notebook instance. 
        /// </para>
        /// </summary>
        public string NotebookInstanceName
        {
            get { return this._notebookInstanceName; }
            set { this._notebookInstanceName = value; }
        }

        // Check to see if NotebookInstanceName property is set
        internal bool IsSetNotebookInstanceName()
        {
            return this._notebookInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceStatus. 
        /// <para>
        /// The status of the notebook instance.
        /// </para>
        /// </summary>
        public NotebookInstanceStatus NotebookInstanceStatus
        {
            get { return this._notebookInstanceStatus; }
            set { this._notebookInstanceStatus = value; }
        }

        // Check to see if NotebookInstanceStatus property is set
        internal bool IsSetNotebookInstanceStatus()
        {
            return this._notebookInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  Amazon Resource Name (ARN) of the IAM role associated with the instance. 
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the VPC security groups.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the VPC subnet.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL that you use to connect to the Jupyter notebook that is running in your notebook
        /// instance. 
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}