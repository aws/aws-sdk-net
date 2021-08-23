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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchGetBlueprints operation.
    /// </summary>
    public partial class BatchGetBlueprintsResponse : AmazonWebServiceResponse
    {
        private List<Blueprint> _blueprints = new List<Blueprint>();
        private List<string> _missingBlueprints = new List<string>();

        /// <summary>
        /// Gets and sets the property Blueprints. 
        /// <para>
        /// Returns a list of blueprint as a <code>Blueprints</code> object.
        /// </para>
        /// </summary>
        public List<Blueprint> Blueprints
        {
            get { return this._blueprints; }
            set { this._blueprints = value; }
        }

        // Check to see if Blueprints property is set
        internal bool IsSetBlueprints()
        {
            return this._blueprints != null && this._blueprints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MissingBlueprints. 
        /// <para>
        /// Returns a list of <code>BlueprintNames</code> that were not found.
        /// </para>
        /// </summary>
        public List<string> MissingBlueprints
        {
            get { return this._missingBlueprints; }
            set { this._missingBlueprints = value; }
        }

        // Check to see if MissingBlueprints property is set
        internal bool IsSetMissingBlueprints()
        {
            return this._missingBlueprints != null && this._missingBlueprints.Count > 0; 
        }

    }
}