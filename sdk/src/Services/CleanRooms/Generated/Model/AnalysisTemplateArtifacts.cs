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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The analysis template artifacts.
    /// </summary>
    public partial class AnalysisTemplateArtifacts
    {
        private List<AnalysisTemplateArtifact> _additionalArtifacts = AWSConfigs.InitializeCollections ? new List<AnalysisTemplateArtifact>() : null;
        private AnalysisTemplateArtifact _entryPoint;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AdditionalArtifacts. 
        /// <para>
        ///  Additional artifacts for the analysis template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AnalysisTemplateArtifact> AdditionalArtifacts
        {
            get { return this._additionalArtifacts; }
            set { this._additionalArtifacts = value; }
        }

        // Check to see if AdditionalArtifacts property is set
        internal bool IsSetAdditionalArtifacts()
        {
            return this._additionalArtifacts != null && (this._additionalArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        ///  The entry point for the analysis template artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisTemplateArtifact EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The role ARN for the analysis template artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=512)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}