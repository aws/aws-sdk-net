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
    /// Represents information about an artifact to be worked on, such as a test or build
    /// artifact.
    /// </summary>
    public partial class InputArtifact
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the artifact to be worked on (for example, "My App").
        /// </para>
        ///  
        /// <para>
        /// Artifacts are the files that are worked on by actions in the pipeline. See the action
        /// configuration for each action for details about artifact parameters. For example,
        /// the S3 source action input artifact is a file name (or file path), and the files are
        /// generally provided as a ZIP file. Example artifact name: SampleApp_Windows.zip
        /// </para>
        ///  
        /// <para>
        /// The input artifact of an action must exactly match the output artifact declared in
        /// a preceding action, but the input artifact does not have to be the next action in
        /// strict sequence from the action that provided the output artifact. Actions in parallel
        /// can declare different output artifacts, which are in turn consumed by different following
        /// actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}