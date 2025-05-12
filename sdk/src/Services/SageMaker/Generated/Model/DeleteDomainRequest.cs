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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDomain operation.
    /// Used to delete a domain. If you onboarded with IAM mode, you will need to delete your
    /// domain to onboard again using IAM Identity Center. Use with caution. All of the members
    /// of the domain will lose access to their EFS volume, including data, notebooks, and
    /// other artifacts.
    /// </summary>
    public partial class DeleteDomainRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private RetentionPolicy _retentionPolicy;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPolicy. 
        /// <para>
        /// The retention policy for this domain, which specifies whether resources will be retained
        /// after the Domain is deleted. By default, all resources are retained (not automatically
        /// deleted). 
        /// </para>
        /// </summary>
        public RetentionPolicy RetentionPolicy
        {
            get { return this._retentionPolicy; }
            set { this._retentionPolicy = value; }
        }

        // Check to see if RetentionPolicy property is set
        internal bool IsSetRetentionPolicy()
        {
            return this._retentionPolicy != null;
        }

    }
}