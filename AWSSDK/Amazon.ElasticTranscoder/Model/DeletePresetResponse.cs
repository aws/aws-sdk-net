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

using System;
using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Returns information about the DeletePresetResult response and response metadata.
    /// </summary>
    public class DeletePresetResponse : AmazonWebServiceResponse
    {
        private DeletePresetResult _deletePresetResult;

        /// <summary>
        /// Gets and sets the DeletePresetResult property.
        /// Represents the output of a DeletePreset operation.
        /// </summary>
        public DeletePresetResult DeletePresetResult
        {
            get
            {
                if(this._deletePresetResult == null)
                {
                    this._deletePresetResult = new DeletePresetResult();
                }
                return this._deletePresetResult;
            }
            set { this._deletePresetResult = value; }
        }
    }
}