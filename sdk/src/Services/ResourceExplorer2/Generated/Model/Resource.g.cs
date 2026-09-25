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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// A resource in Amazon Web Services that Amazon Web Services Resource Explorer has discovered,
    /// and for which it has stored information in the index of the Amazon Web Services Region
    /// that contains the resource.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the resource.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CfnResourceType. 
        /// <para>
        /// The CloudFormation resource type identifier for the resource, such as <c>AWS::EC2::Instance</c>
        /// or <c>AWS::S3::Bucket</c>.
        /// </para>
        /// </summary>
        public string CfnResourceType { get; set; }

        /// <summary>
        /// Checks to see if the CfnResourceType property is set.
        /// </summary>
        internal bool IsSetCfnResourceType() => this.CfnResourceType != null;

        /// <summary>
        /// Gets and sets the property LastReportedAt. 
        /// <para>
        /// The date and time that Resource Explorer last queried this resource and updated the
        /// index with the latest information about the resource.
        /// </para>
        /// </summary>
        public DateTime? LastReportedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastReportedAt property is set.
        /// </summary>
        internal bool IsSetLastReportedAt() => this.LastReportedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OwningAccountId. 
        /// <para>
        /// The Amazon Web Services account that owns the resource.
        /// </para>
        /// </summary>
        public string OwningAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwningAccountId property is set.
        /// </summary>
        internal bool IsSetOwningAccountId() => this.OwningAccountId != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A structure with additional type-specific details about the resource. These properties
        /// can be added by turning on integration between Resource Explorer and other Amazon
        /// Web Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceProperty> Properties { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceProperty>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the resource was created and exists.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The Amazon Web Services service that owns the resource and is responsible for creating
        /// and updating it.
        /// </para>
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;
    }
}
