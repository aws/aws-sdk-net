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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the specified trigger configuration, such as the filter
    /// criteria and the source stage for the action that contains the trigger.
    /// 
    ///  <note> 
    /// <para>
    /// This is only supported for the <c>CodeStarSourceConnection</c> action type.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// When a trigger configuration is specified, default change detection for repository
    /// and branch commits is disabled.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PipelineTriggerDeclaration
    {
        private GitConfiguration _gitConfiguration;
        private PipelineTriggerProviderType _providerType;

        /// <summary>
        /// Gets and sets the property GitConfiguration. 
        /// <para>
        /// Provides the filter criteria and the source stage for the repository event that starts
        /// the pipeline, such as Git tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GitConfiguration GitConfiguration
        {
            get { return this._gitConfiguration; }
            set { this._gitConfiguration = value; }
        }

        // Check to see if GitConfiguration property is set
        internal bool IsSetGitConfiguration()
        {
            return this._gitConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The source provider for the event, such as connections configured for a repository
        /// with Git tags, for the specified trigger configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PipelineTriggerProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

    }
}