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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A list of service integrations.
    /// </summary>
    public partial class ServiceIntegrationsUnion
    {
        private List<LakeFormationScopeUnion> _lakeFormation = AWSConfigs.InitializeCollections ? new List<LakeFormationScopeUnion>() : null;

        /// <summary>
        /// Gets and sets the property LakeFormation. 
        /// <para>
        /// A list of scopes set up for Lake Formation integration.
        /// </para>
        /// </summary>
        public List<LakeFormationScopeUnion> LakeFormation
        {
            get { return this._lakeFormation; }
            set { this._lakeFormation = value; }
        }

        // Check to see if LakeFormation property is set
        internal bool IsSetLakeFormation()
        {
            return this._lakeFormation != null && (this._lakeFormation.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}