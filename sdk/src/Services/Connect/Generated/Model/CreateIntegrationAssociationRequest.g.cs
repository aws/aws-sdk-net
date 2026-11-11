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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegrationAssociation operation. Creates
    /// an Amazon Web Services resource association with an Connect Customer instance.
    /// </summary>
    public partial class CreateIntegrationAssociationRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the integration.
        /// </para>
        ///  <note> 
        /// <para>
        /// When integrating with Amazon Web Services End User Messaging, the Connect Customer
        /// and Amazon Web Services End User Messaging instances must be in the same account.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationArn() => this.IntegrationArn != null;

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The type of information to be ingested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property SourceApplicationName. 
        /// <para>
        /// The name of the external application. This field is only required for the EVENT integration
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SourceApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceApplicationName property is set.
        /// </summary>
        internal bool IsSetSourceApplicationName() => this.SourceApplicationName != null;

        /// <summary>
        /// Gets and sets the property SourceApplicationUrl. 
        /// <para>
        /// The URL for the external application. This field is only required for the EVENT integration
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string SourceApplicationUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceApplicationUrl property is set.
        /// </summary>
        internal bool IsSetSourceApplicationUrl() => this.SourceApplicationUrl != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the data source. This field is only required for the EVENT integration
        /// type.
        /// </para>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
