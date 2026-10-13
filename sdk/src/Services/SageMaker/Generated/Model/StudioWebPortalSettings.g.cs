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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Studio settings. If these settings are applied on a user level, they take priority
    /// over the settings applied on a domain level.
    /// </summary>
    public partial class StudioWebPortalSettings
    {
        /// <summary>
        /// Gets and sets the property ExecutionRoleSessionNameMode. 
        /// <para>
        /// The execution role session name mode. If this value is set to <c>USER_IDENTITY</c>,
        /// the session name of the execution role corresponds to the user's identity. For IAM
        /// domains, the session name is the IAM session name used to generate the presigned URL.
        /// For IAM Identity Center domains, the session name is the username of the associated
        /// IAM Identity Center user. If this value is set to <c>STATIC</c> or is not set, the
        /// session name defaults to <c>SageMaker</c>.
        /// </para>
        /// </summary>
        public ExecutionRoleSessionNameMode ExecutionRoleSessionNameMode { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleSessionNameMode property is set.
        /// </summary>
        internal bool IsSetExecutionRoleSessionNameMode() => this.ExecutionRoleSessionNameMode != null;

        /// <summary>
        /// Gets and sets the property HiddenAppTypes. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-updated-apps.html">Applications
        /// supported in Studio</a> that are hidden from the Studio left navigation pane.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenAppTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HiddenAppTypes property is set.
        /// </summary>
        internal bool IsSetHiddenAppTypes() => this.HiddenAppTypes != null && (this.HiddenAppTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HiddenInstanceTypes. 
        /// <para>
        ///  The instance types you are hiding from the Studio user interface. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HiddenInstanceTypes property is set.
        /// </summary>
        internal bool IsSetHiddenInstanceTypes() => this.HiddenInstanceTypes != null && (this.HiddenInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HiddenMlTools. 
        /// <para>
        /// The machine learning tools that are hidden from the Studio left navigation pane.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenMlTools { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HiddenMlTools property is set.
        /// </summary>
        internal bool IsSetHiddenMlTools() => this.HiddenMlTools != null && (this.HiddenMlTools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HiddenSageMakerImageVersionAliases. 
        /// <para>
        ///  The version aliases you are hiding from the Studio user interface. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<HiddenSageMakerImage> HiddenSageMakerImageVersionAliases { get; set; } = AWSConfigs.InitializeCollections ? new List<HiddenSageMakerImage>() : null;

        /// <summary>
        /// Checks to see if the HiddenSageMakerImageVersionAliases property is set.
        /// </summary>
        internal bool IsSetHiddenSageMakerImageVersionAliases() => this.HiddenSageMakerImageVersionAliases != null && (this.HiddenSageMakerImageVersionAliases.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
