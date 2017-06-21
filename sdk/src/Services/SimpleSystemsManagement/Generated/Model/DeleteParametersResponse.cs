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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DeleteParameters operation.
    /// </summary>
    public partial class DeleteParametersResponse : AmazonWebServiceResponse
    {
        private List<string> _deletedParameters = new List<string>();
        private List<string> _invalidParameters = new List<string>();

        /// <summary>
        /// Gets and sets the property DeletedParameters. 
        /// <para>
        /// The names of the deleted parameters.
        /// </para>
        /// </summary>
        public List<string> DeletedParameters
        {
            get { return this._deletedParameters; }
            set { this._deletedParameters = value; }
        }

        // Check to see if DeletedParameters property is set
        internal bool IsSetDeletedParameters()
        {
            return this._deletedParameters != null && this._deletedParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InvalidParameters. 
        /// <para>
        /// The names of parameters that weren't deleted because the parameters are not valid.
        /// </para>
        /// </summary>
        public List<string> InvalidParameters
        {
            get { return this._invalidParameters; }
            set { this._invalidParameters = value; }
        }

        // Check to see if InvalidParameters property is set
        internal bool IsSetInvalidParameters()
        {
            return this._invalidParameters != null && this._invalidParameters.Count > 0; 
        }

    }
}