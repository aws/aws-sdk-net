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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExtension operation. Creates an AppConfig
    /// extension. An extension augments your ability to inject logic or behavior at different
    /// points during the AppConfig workflow of creating or deploying a configuration. <para>
    /// You can create your own extensions or use the Amazon Web Services authored extensions
    /// provided by AppConfig. For an AppConfig extension that uses Lambda, you must create
    /// a Lambda function to perform any computation and processing defined in the extension.
    /// If you plan to create custom versions of the Amazon Web Services authored notification
    /// extensions, you only need to specify an Amazon Resource Name (ARN) in the <c>Uri</c>
    /// field for the new extension version. </para> <ul> <li> <para> For a custom EventBridge
    /// notification extension, enter the ARN of the EventBridge default events in the <c>Uri</c>
    /// field. </para> </li> <li> <para> For a custom Amazon SNS notification extension, enter
    /// the ARN of an Amazon SNS topic in the <c>Uri</c> field. </para> </li> <li> <para>
    /// For a custom Amazon SQS notification extension, enter the ARN of an Amazon SQS message
    /// queue in the <c>Uri</c> field. </para> </li> </ul> <para> For more information about
    /// extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
    /// workflows</a> in the <i>AppConfig User Guide</i>. </para>
    /// </summary>
    public partial class CreateExtensionRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions defined in the extension.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public Dictionary<string, List<Action>> Actions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<Action>>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        /// You can omit this field when you create an extension. When you create a new version,
        /// specify the most recent current version number. For example, you create version 3,
        /// enter 2 for this field.
        /// </para>
        /// </summary>
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionNumber property is set.
        /// </summary>
        internal bool IsSetLatestVersionNumber() => this.LatestVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the extension. Each extension name in your account must be unique. Extension
        /// versions use the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters accepted by the extension. You specify parameter values when you associate
        /// the extension to an AppConfig resource by using the <c>CreateExtensionAssociation</c>
        /// API action. For Lambda extension actions, these parameters are included in the Lambda
        /// request object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, Parameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Parameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more tags for the specified extension. Tags are metadata that help you
        /// categorize resources in different ways, for example, by purpose, owner, or environment.
        /// Each tag consists of a key and an optional value, both of which you define. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
