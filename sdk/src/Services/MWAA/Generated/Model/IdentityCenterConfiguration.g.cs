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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Describes the Amazon Web Services IAM Identity Center configuration used to authenticate
    /// users to the Apache Airflow web UI for your Amazon MWAA environment.
    /// </summary>
    public partial class IdentityCenterConfiguration
    {
        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The identifier of the identity store associated with the IAM Identity Center instance
        /// for your environment. For example, <c>d-1234567890</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property StartUrl. 
        /// <para>
        /// The Amazon Web Services access portal URL of the IAM Identity Center instance associated
        /// with your environment. For example, <c>https://my-portal.awsapps.com/start</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string StartUrl { get; set; }

        /// <summary>
        /// Checks to see if the StartUrl property is set.
        /// </summary>
        internal bool IsSetStartUrl() => this.StartUrl != null;
    }
}
