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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReadinessCheck operation. Creates a readiness
    /// check in an account. A readiness check monitors a resource set in your application,
    /// such as a set of Amazon Aurora instances, that Application Recovery Controller is
    /// auditing recovery readiness for. The audits run once every minute on every resource
    /// that's associated with a readiness check.
    /// </summary>
    public partial class CreateReadinessCheckRequest : AmazonRoute53RecoveryReadinessRequest
    {
        /// <summary>
        /// Gets and sets the property ReadinessCheckName. 
        /// <para>
        /// The name of the readiness check to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReadinessCheckName { get; set; }

        /// <summary>
        /// Checks to see if the ReadinessCheckName property is set.
        /// </summary>
        internal bool IsSetReadinessCheckName() => this.ReadinessCheckName != null;

        /// <summary>
        /// Gets and sets the property ResourceSetName. 
        /// <para>
        /// The name of the resource set to check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceSetName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSetName property is set.
        /// </summary>
        internal bool IsSetResourceSetName() => this.ResourceSetName != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
