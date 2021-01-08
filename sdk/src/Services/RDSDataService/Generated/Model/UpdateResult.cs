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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The response elements represent the results of an update.
    /// </summary>
    public partial class UpdateResult
    {
        private List<Field> _generatedFields = new List<Field>();

        /// <summary>
        /// Gets and sets the property GeneratedFields. 
        /// <para>
        /// Values for fields generated during the request.
        /// </para>
        /// </summary>
        public List<Field> GeneratedFields
        {
            get { return this._generatedFields; }
            set { this._generatedFields = value; }
        }

        // Check to see if GeneratedFields property is set
        internal bool IsSetGeneratedFields()
        {
            return this._generatedFields != null && this._generatedFields.Count > 0; 
        }

    }
}