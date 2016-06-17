/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the GetMLModel operation.
    /// Returns an <code>MLModel</code> that includes detailed metadata, data source information,
    /// and the current status of the <code>MLModel</code>.
    /// 
    ///  
    /// <para>
    /// <code>GetMLModel</code> provides results in normal or verbose format. 
    /// </para>
    /// </summary>
    public partial class GetMLModelRequest : AmazonMachineLearningRequest
    {
        private string _mlModelId;
        private bool? _verbose;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID assigned to the <code>MLModel</code> at creation.
        /// </para>
        /// </summary>
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

        /// <summary>
        /// Gets and sets the property Verbose. 
        /// <para>
        /// Specifies whether the <code>GetMLModel</code> operation should return <code>Recipe</code>.
        /// </para>
        ///  
        /// <para>
        /// If true, <code>Recipe</code> is returned.
        /// </para>
        ///  
        /// <para>
        /// If false, <code>Recipe</code> is not returned.
        /// </para>
        /// </summary>
        public bool Verbose
        {
            get { return this._verbose.GetValueOrDefault(); }
            set { this._verbose = value; }
        }

        // Check to see if Verbose property is set
        internal bool IsSetVerbose()
        {
            return this._verbose.HasValue; 
        }

    }
}