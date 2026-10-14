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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIntegrationResourceProperty operation. This
    /// API can be used for updating the <c>ResourceProperty</c> of the Glue connection (for
    /// the source) or Glue database ARN (for the target). These properties can include the
    /// role to access the connection or database. Since the same resource can be used across
    /// multiple integrations, updating resource properties will impact all the integrations
    /// using it.
    /// </summary>
    public partial class UpdateIntegrationResourcePropertyRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The connection ARN of the source, or the database ARN of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceProcessingProperties. 
        /// <para>
        /// The resource properties associated with the integration source.
        /// </para>
        /// </summary>
        public SourceProcessingProperties SourceProcessingProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceProcessingProperties property is set.
        /// </summary>
        internal bool IsSetSourceProcessingProperties() => this.SourceProcessingProperties != null;

        /// <summary>
        /// Gets and sets the property TargetProcessingProperties. 
        /// <para>
        /// The resource properties associated with the integration target.
        /// </para>
        /// </summary>
        public TargetProcessingProperties TargetProcessingProperties { get; set; }

        /// <summary>
        /// Checks to see if the TargetProcessingProperties property is set.
        /// </summary>
        internal bool IsSetTargetProcessingProperties() => this.TargetProcessingProperties != null;
    }
}
