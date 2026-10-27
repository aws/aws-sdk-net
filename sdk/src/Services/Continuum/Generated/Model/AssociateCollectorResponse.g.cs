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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// This is the response object from the AssociateCollector operation.
    /// </summary>
    public partial class AssociateCollectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedCollector. The Collector identifier and ARN validated
        /// by this operation.
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociatedCollector AssociatedCollector { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedCollector property is set.
        /// </summary>
        internal bool IsSetAssociatedCollector() => this.AssociatedCollector != null;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. The ARN of the Environment making the association.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The unique identifier of the Environment
        /// making the association.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;
    }
}
