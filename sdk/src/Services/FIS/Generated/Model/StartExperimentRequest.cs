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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Container for the parameters to the StartExperiment operation.
    /// Starts running an experiment from the specified experiment template.
    /// </summary>
    public partial class StartExperimentRequest : AmazonFISRequest
    {
        private string _clientToken;
        private StartExperimentExperimentOptionsInput _experimentOptions;
        private string _experimentTemplateId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentOptions. 
        /// <para>
        /// The experiment options for running the experiment.
        /// </para>
        /// </summary>
        public StartExperimentExperimentOptionsInput ExperimentOptions
        {
            get { return this._experimentOptions; }
            set { this._experimentOptions = value; }
        }

        // Check to see if ExperimentOptions property is set
        internal bool IsSetExperimentOptions()
        {
            return this._experimentOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentTemplateId. 
        /// <para>
        /// The ID of the experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ExperimentTemplateId
        {
            get { return this._experimentTemplateId; }
            set { this._experimentTemplateId = value; }
        }

        // Check to see if ExperimentTemplateId property is set
        internal bool IsSetExperimentTemplateId()
        {
            return this._experimentTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
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

    }
}