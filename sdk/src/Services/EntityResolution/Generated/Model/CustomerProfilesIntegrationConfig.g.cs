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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Specifies the configuration for integrating with Customer Profiles. This configuration
    /// enables Entity Resolution to send matched output directly to Customer Profiles instead
    /// of Amazon S3, creating a unified customer view by automatically updating customer
    /// profiles based on match clusters.
    /// </summary>
    public partial class CustomerProfilesIntegrationConfig
    {
        /// <summary>
        /// Gets and sets the property DomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Customer Profiles domain where the matched output
        /// will be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainArn property is set.
        /// </summary>
        internal bool IsSetDomainArn() => this.DomainArn != null;

        /// <summary>
        /// Gets and sets the property ObjectTypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Customer Profiles object type that defines the
        /// structure for the matched customer data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ObjectTypeArn { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypeArn property is set.
        /// </summary>
        internal bool IsSetObjectTypeArn() => this.ObjectTypeArn != null;
    }
}
