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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetImport operation.
    /// Gets information about an import job started with the <code>StartImport</code> operation.
    /// </summary>
    public partial class GetImportRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _importId;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The identifier of the import job information to return.
        /// </para>
        /// </summary>
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

    }
}