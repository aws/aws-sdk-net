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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIdentityPropagationConfig operation.
    /// Deletes all access scopes and authorized targets that are associated with a service
    /// from the QuickSight IAM Identity Center application.
    /// 
    ///  
    /// <para>
    /// This operation is only supported for QuickSight accounts that use IAM Identity Center.
    /// </para>
    /// </summary>
    public partial class DeleteIdentityPropagationConfigRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private ServiceType _service;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that you want to delete an identity propagation
        /// configuration from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the Amazon Web Services service that you want to delete the associated
        /// access scopes and authorized targets from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceType Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}