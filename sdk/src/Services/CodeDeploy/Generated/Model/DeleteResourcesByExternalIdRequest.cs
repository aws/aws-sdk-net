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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourcesByExternalId operation.
    /// Deletes resources linked to an external ID. This action only applies if you have configured
    /// blue/green deployments through CloudFormation. 
    /// 
    ///  <note> 
    /// <para>
    /// It is not necessary to call this action directly. CloudFormation calls it on your
    /// behalf when it needs to delete stack resources. This action is offered publicly in
    /// case you need to delete resources to comply with General Data Protection Regulation
    /// (GDPR) requirements.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteResourcesByExternalIdRequest : AmazonCodeDeployRequest
    {
        private string _externalId;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The unique ID of an external resource (for example, a CloudFormation stack ID) that
        /// is linked to one or more CodeDeploy resources.
        /// </para>
        /// </summary>
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