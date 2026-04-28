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
    /// Application summary for list operations
    /// </summary>
    public partial class ApplicationSummary
    {
        private string _applicationId;
        private string _applicationName;
        private string _defaultKmsKeyId;
        private string _domain;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// Unique identifier of the application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application, automatically assigned by the service
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultKmsKeyId. 
        /// <para>
        /// Default KMS key identifier used to encrypt application data
        /// </para>
        /// </summary>
        public string DefaultKmsKeyId
        {
            get { return this._defaultKmsKeyId; }
            set { this._defaultKmsKeyId = value; }
        }

        // Check to see if DefaultKmsKeyId property is set
        internal bool IsSetDefaultKmsKeyId()
        {
            return this._defaultKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Domain where the application is available
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

    }
}