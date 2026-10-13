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
    /// The JupyterServer app settings.
    /// </summary>
    public partial class JupyterServerAppSettings
    {
        /// <summary>
        /// Gets and sets the property CodeRepositories. 
        /// <para>
        /// A list of Git repositories that SageMaker AI automatically displays to users for cloning
        /// in the JupyterServer application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<CodeRepository> CodeRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeRepository>() : null;

        /// <summary>
        /// Checks to see if the CodeRepositories property is set.
        /// </summary>
        internal bool IsSetCodeRepositories() => this.CodeRepositories != null && (this.CodeRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultResourceSpec. 
        /// <para>
        /// The default instance type and the Amazon Resource Name (ARN) of the default SageMaker
        /// AI image used by the JupyterServer app. If you use the <c>LifecycleConfigArns</c>
        /// parameter, then this parameter is also required.
        /// </para>
        /// </summary>
        public ResourceSpec DefaultResourceSpec { get; set; }

        /// <summary>
        /// Checks to see if the DefaultResourceSpec property is set.
        /// </summary>
        internal bool IsSetDefaultResourceSpec() => this.DefaultResourceSpec != null;

        /// <summary>
        /// Gets and sets the property LifecycleConfigArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lifecycle Configurations attached to the JupyterServerApp.
        /// If you use this parameter, the <c>DefaultResourceSpec</c> parameter is also required.
        /// </para>
        ///  <note> 
        /// <para>
        /// To remove a Lifecycle Config, you must set <c>LifecycleConfigArns</c> to an empty
        /// list.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LifecycleConfigArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LifecycleConfigArns property is set.
        /// </summary>
        internal bool IsSetLifecycleConfigArns() => this.LifecycleConfigArns != null && (this.LifecycleConfigArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
