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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains summary information about a batch build group.
    /// </summary>
    public partial class BuildSummary
    {
        private string _arn;
        private StatusType _buildStatus;
        private ResolvedArtifact _primaryArtifact;
        private DateTime? _requestedOn;
        private List<ResolvedArtifact> _secondaryArtifacts = AWSConfigs.InitializeCollections ? new List<ResolvedArtifact>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The batch build ARN.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The status of the build group.
        /// </para>
        ///  <dl> <dt>FAILED</dt> <dd> 
        /// <para>
        /// The build group failed.
        /// </para>
        ///  </dd> <dt>FAULT</dt> <dd> 
        /// <para>
        /// The build group faulted.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The build group is still in progress.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The build group stopped.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The build group succeeded.
        /// </para>
        ///  </dd> <dt>TIMED_OUT</dt> <dd> 
        /// <para>
        /// The build group timed out.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public StatusType BuildStatus
        {
            get { return this._buildStatus; }
            set { this._buildStatus = value; }
        }

        // Check to see if BuildStatus property is set
        internal bool IsSetBuildStatus()
        {
            return this._buildStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryArtifact. 
        /// <para>
        /// A <c>ResolvedArtifact</c> object that represents the primary build artifacts for the
        /// build group.
        /// </para>
        /// </summary>
        public ResolvedArtifact PrimaryArtifact
        {
            get { return this._primaryArtifact; }
            set { this._primaryArtifact = value; }
        }

        // Check to see if PrimaryArtifact property is set
        internal bool IsSetPrimaryArtifact()
        {
            return this._primaryArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedOn. 
        /// <para>
        /// When the build was started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? RequestedOn
        {
            get { return this._requestedOn; }
            set { this._requestedOn = value; }
        }

        // Check to see if RequestedOn property is set
        internal bool IsSetRequestedOn()
        {
            return this._requestedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// An array of <c>ResolvedArtifact</c> objects that represents the secondary build artifacts
        /// for the build group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolvedArtifact> SecondaryArtifacts
        {
            get { return this._secondaryArtifacts; }
            set { this._secondaryArtifacts = value; }
        }

        // Check to see if SecondaryArtifacts property is set
        internal bool IsSetSecondaryArtifacts()
        {
            return this._secondaryArtifacts != null && (this._secondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}