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
    /// This is the response object from the GetIntegrationResourceProperty operation.
    /// </summary>
    public partial class GetIntegrationResourcePropertyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The connection ARN of the source, or the database ARN of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourcePropertyArn. 
        /// <para>
        /// The resource ARN created through this create API. The format is something like arn:aws:glue:&lt;region&gt;:&lt;account_id&gt;:integrationresourceproperty/*
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ResourcePropertyArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePropertyArn property is set.
        /// </summary>
        internal bool IsSetResourcePropertyArn() => this.ResourcePropertyArn != null;

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
