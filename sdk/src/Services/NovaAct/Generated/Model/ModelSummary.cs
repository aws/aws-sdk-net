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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Summary information about an available AI model.
    /// </summary>
    public partial class ModelSummary
    {
        private int? _minimumCompatibilityVersion;
        private string _modelId;
        private ModelLifecycle _modelLifecycle;

        /// <summary>
        /// Gets and sets the property MinimumCompatibilityVersion. 
        /// <para>
        /// The minimum client compatibility version required to use this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinimumCompatibilityVersion
        {
            get { return this._minimumCompatibilityVersion; }
            set { this._minimumCompatibilityVersion = value; }
        }

        // Check to see if MinimumCompatibilityVersion property is set
        internal bool IsSetMinimumCompatibilityVersion()
        {
            return this._minimumCompatibilityVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelLifecycle. 
        /// <para>
        /// The lifecycle information for the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelLifecycle ModelLifecycle
        {
            get { return this._modelLifecycle; }
            set { this._modelLifecycle = value; }
        }

        // Check to see if ModelLifecycle property is set
        internal bool IsSetModelLifecycle()
        {
            return this._modelLifecycle != null;
        }

    }
}