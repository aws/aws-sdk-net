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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Specifies a cross-account IAM role ARN and optional external ID.
    /// </summary>
    public partial class CrossAccountRole
    {
        private string _crossAccountRoleArn;
        private string _externalId;

        /// <summary>
        /// Gets and sets the property CrossAccountRoleArn.
        /// </summary>
        [AWSProperty(Required=true, Min=32)]
        public string CrossAccountRoleArn
        {
            get { return this._crossAccountRoleArn; }
            set { this._crossAccountRoleArn = value; }
        }

        // Check to see if CrossAccountRoleArn property is set
        internal bool IsSetCrossAccountRoleArn()
        {
            return this._crossAccountRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID used for assuming the cross-account role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=1224)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

    }
}