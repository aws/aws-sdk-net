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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns information about the resource being evaluated.
    /// </summary>
    public partial class ResourceDetails
    {
        /// <summary>
        /// Gets and sets the property ResourceConfiguration. 
        /// <para>
        /// The resource definition to be evaluated as per the resource configuration schema type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 51200)]
        public string ResourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfiguration property is set.
        /// </summary>
        internal bool IsSetResourceConfiguration() => this.ResourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationSchemaType. 
        /// <para>
        /// The schema type of the resource configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can find the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">Resource
        /// type schema</a>, or <c>CFN_RESOURCE_SCHEMA</c>, in "<i>Amazon Web Services public
        /// extensions</i>" within the CloudFormation registry or with the following CLI commmand:
        /// <c>aws cloudformation describe-type --type-name "AWS::S3::Bucket" --type RESOURCE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry.html#registry-view">Managing
        /// extensions through the CloudFormation registry</a> and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the CloudFormation User
        /// Guide.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceConfigurationSchemaType ResourceConfigurationSchemaType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationSchemaType property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationSchemaType() => this.ResourceConfigurationSchemaType != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// A unique resource ID for an evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 768)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
