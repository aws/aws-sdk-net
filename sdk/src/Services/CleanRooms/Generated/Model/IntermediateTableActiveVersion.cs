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
    /// Contains the details of the currently active version of an intermediate table.
    /// </summary>
    public partial class IntermediateTableActiveVersion
    {
        private string _analysisId;
        private PopulateIntermediateTableAnalysisType _analysisType;
        private DateTime? _expirationTime;
        private IntermediateTableInheritedConstraints _inheritedConstraints;
        private string _kmsKeyArn;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The identifier of the protected query that created this version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis that created this version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PopulateIntermediateTableAnalysisType AnalysisType
        {
            get { return this._analysisType; }
            set { this._analysisType = value; }
        }

        // Check to see if AnalysisType property is set
        internal bool IsSetAnalysisType()
        {
            return this._analysisType != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time when this version expires based on the retention period.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InheritedConstraints. 
        /// <para>
        /// The privacy constraints inherited from parent tables at the time this version was
        /// populated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntermediateTableInheritedConstraints InheritedConstraints
        {
            get { return this._inheritedConstraints; }
            set { this._inheritedConstraints = value; }
        }

        // Check to see if InheritedConstraints property is set
        internal bool IsSetInheritedConstraints()
        {
            return this._inheritedConstraints != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt this version's data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The runtime parameters that were used when populating this version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The unique identifier of the active version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}