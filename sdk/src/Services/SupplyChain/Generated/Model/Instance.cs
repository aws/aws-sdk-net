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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The details of the instance.
    /// </summary>
    public partial class Instance
    {
        private string _awsAccountId;
        private DateTime? _createdTime;
        private string _errorMessage;
        private string _instanceDescription;
        private string _instanceId;
        private string _instanceName;
        private string _kmsKeyArn;
        private DateTime? _lastModifiedTime;
        private InstanceState _state;
        private double? _versionNumber;
        private string _webAppDnsDomain;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The instance creation timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance error message. If the instance results
        /// in an unhealthy state, customers need to check the error message, delete the current
        /// instance, and recreate a new one based on the mitigation from the error message.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceDescription. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=501)]
        public string InstanceDescription
        {
            get { return this._instanceDescription; }
            set { this._instanceDescription = value; }
        }

        // Check to see if InstanceDescription property is set
        internal bool IsSetInstanceDescription()
        {
            return this._instanceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you optionally
        /// provided for encryption. If you did not provide anything here, AWS Supply Chain uses
        /// the Amazon Web Services owned KMS key and nothing is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The instance last modified timestamp.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the instance.
        /// </para>
        /// </summary>
        public double? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebAppDnsDomain. 
        /// <para>
        /// The WebApp DNS domain name of the instance.
        /// </para>
        /// </summary>
        public string WebAppDnsDomain
        {
            get { return this._webAppDnsDomain; }
            set { this._webAppDnsDomain = value; }
        }

        // Check to see if WebAppDnsDomain property is set
        internal bool IsSetWebAppDnsDomain()
        {
            return this._webAppDnsDomain != null;
        }

    }
}