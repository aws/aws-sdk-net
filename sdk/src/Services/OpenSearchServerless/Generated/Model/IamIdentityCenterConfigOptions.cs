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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Describes IAM Identity Center options for an OpenSearch Serverless security configuration
    /// in the form of a key-value map.
    /// </summary>
    public partial class IamIdentityCenterConfigOptions
    {
        private string _applicationArn;
        private string _applicationDescription;
        private string _applicationName;
        private IamIdentityCenterGroupAttribute _groupAttribute;
        private string _instanceArn;
        private IamIdentityCenterUserAttribute _userAttribute;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The ARN of the IAM Identity Center application used to integrate with OpenSearch Serverless.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// The description of the IAM Identity Center application used to integrate with OpenSearch
        /// Serverless.
        /// </para>
        /// </summary>
        public string ApplicationDescription
        {
            get { return this._applicationDescription; }
            set { this._applicationDescription = value; }
        }

        // Check to see if ApplicationDescription property is set
        internal bool IsSetApplicationDescription()
        {
            return this._applicationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the IAM Identity Center application used to integrate with OpenSearch
        /// Serverless.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GroupAttribute. 
        /// <para>
        /// The group attribute for this IAM Identity Center integration. Defaults to <c>GroupId</c>.
        /// </para>
        /// </summary>
        public IamIdentityCenterGroupAttribute GroupAttribute
        {
            get { return this._groupAttribute; }
            set { this._groupAttribute = value; }
        }

        // Check to see if GroupAttribute property is set
        internal bool IsSetGroupAttribute()
        {
            return this._groupAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center instance used to integrate with OpenSearch Serverless.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// The user attribute for this IAM Identity Center integration. Defaults to <c>UserId</c>
        /// 
        /// </para>
        /// </summary>
        public IamIdentityCenterUserAttribute UserAttribute
        {
            get { return this._userAttribute; }
            set { this._userAttribute = value; }
        }

        // Check to see if UserAttribute property is set
        internal bool IsSetUserAttribute()
        {
            return this._userAttribute != null;
        }

    }
}