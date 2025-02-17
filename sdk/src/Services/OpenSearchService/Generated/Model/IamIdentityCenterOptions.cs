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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Settings for IAM Identity Center for an OpenSearch Application.
    /// </summary>
    public partial class IamIdentityCenterOptions
    {
        private bool? _enabled;
        private string _iamIdentityCenterApplicationArn;
        private string _iamIdentityCenterInstanceArn;
        private string _iamRoleForIdentityCenterApplicationArn;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// IAM Identity Center is enabled for the OpenSearch Application.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamIdentityCenterApplicationArn.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamIdentityCenterApplicationArn
        {
            get { return this._iamIdentityCenterApplicationArn; }
            set { this._iamIdentityCenterApplicationArn = value; }
        }

        // Check to see if IamIdentityCenterApplicationArn property is set
        internal bool IsSetIamIdentityCenterApplicationArn()
        {
            return this._iamIdentityCenterApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamIdentityCenterInstanceArn.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamIdentityCenterInstanceArn
        {
            get { return this._iamIdentityCenterInstanceArn; }
            set { this._iamIdentityCenterInstanceArn = value; }
        }

        // Check to see if IamIdentityCenterInstanceArn property is set
        internal bool IsSetIamIdentityCenterInstanceArn()
        {
            return this._iamIdentityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleForIdentityCenterApplicationArn. 
        /// <para>
        /// Amazon Resource Name of the IAM Identity Center's Application created for the OpenSearch
        /// Application after enabling IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamRoleForIdentityCenterApplicationArn
        {
            get { return this._iamRoleForIdentityCenterApplicationArn; }
            set { this._iamRoleForIdentityCenterApplicationArn = value; }
        }

        // Check to see if IamRoleForIdentityCenterApplicationArn property is set
        internal bool IsSetIamRoleForIdentityCenterApplicationArn()
        {
            return this._iamRoleForIdentityCenterApplicationArn != null;
        }

    }
}