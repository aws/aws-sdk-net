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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Contains summary information about a MicroVM image build.
    /// </summary>
    public partial class MicrovmImageBuildSummary
    {
        private Architecture _architecture;
        private string _buildId;
        private BuildState _buildState;
        private Chipset _chipset;
        private string _chipsetGeneration;
        private DateTime? _createdAt;
        private string _imageArn;
        private string _imageVersion;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The target CPU architecture for the build. Supported value: ARM_64.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// The build request ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

        /// <summary>
        /// Gets and sets the property BuildState. 
        /// <para>
        /// The current state of the build.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BuildState BuildState
        {
            get { return this._buildState; }
            set { this._buildState = value; }
        }

        // Check to see if BuildState property is set
        internal bool IsSetBuildState()
        {
            return this._buildState != null;
        }

        /// <summary>
        /// Gets and sets the property Chipset. 
        /// <para>
        /// The target chipset for the build.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Chipset Chipset
        {
            get { return this._chipset; }
            set { this._chipset = value; }
        }

        // Check to see if Chipset property is set
        internal bool IsSetChipset()
        {
            return this._chipset != null;
        }

        /// <summary>
        /// Gets and sets the property ChipsetGeneration. 
        /// <para>
        /// The target chipset generation for the build.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ChipsetGeneration
        {
            get { return this._chipsetGeneration; }
            set { this._chipsetGeneration = value; }
        }

        // Check to see if ChipsetGeneration property is set
        internal bool IsSetChipsetGeneration()
        {
            return this._chipsetGeneration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the build was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the build state, if applicable.
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

    }
}