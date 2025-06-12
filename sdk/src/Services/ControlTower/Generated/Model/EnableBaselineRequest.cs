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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the EnableBaseline operation.
    /// Enable (apply) a <c>Baseline</c> to a Target. This API starts an asynchronous operation
    /// to deploy resources specified by the <c>Baseline</c> to the specified Target. For
    /// usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
    /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
    /// </summary>
    public partial class EnableBaselineRequest : AmazonControlTowerRequest
    {
        private string _baselineIdentifier;
        private string _baselineVersion;
        private List<EnabledBaselineParameter> _parameters = AWSConfigs.InitializeCollections ? new List<EnabledBaselineParameter>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetIdentifier;

        /// <summary>
        /// Gets and sets the property BaselineIdentifier. 
        /// <para>
        /// The ARN of the baseline to be enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string BaselineIdentifier
        {
            get { return this._baselineIdentifier; }
            set { this._baselineIdentifier = value; }
        }

        // Check to see if BaselineIdentifier property is set
        internal bool IsSetBaselineIdentifier()
        {
            return this._baselineIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property BaselineVersion. 
        /// <para>
        /// The specific version to be enabled of the specified baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string BaselineVersion
        {
            get { return this._baselineVersion; }
            set { this._baselineVersion = value; }
        }

        // Check to see if BaselineVersion property is set
        internal bool IsSetBaselineVersion()
        {
            return this._baselineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <c>key-value</c> objects that specify enablement parameters, where <c>key</c>
        /// is a string and <c>value</c> is a document of any type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledBaselineParameter> Parameters
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with input to <c>EnableBaseline</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The ARN of the target on which the baseline will be enabled. Only OUs are supported
        /// as targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TargetIdentifier
        {
            get { return this._targetIdentifier; }
            set { this._targetIdentifier = value; }
        }

        // Check to see if TargetIdentifier property is set
        internal bool IsSetTargetIdentifier()
        {
            return this._targetIdentifier != null;
        }

    }
}