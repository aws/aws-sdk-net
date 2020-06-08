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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeServiceActionExecutionParameters operation.
    /// </summary>
    public partial class DescribeServiceActionExecutionParametersResponse : AmazonWebServiceResponse
    {
        private List<ExecutionParameter> _serviceActionParameters = new List<ExecutionParameter>();

        /// <summary>
        /// Gets and sets the property ServiceActionParameters. 
        /// <para>
        /// The parameters of the self-service action.
        /// </para>
        /// </summary>
        public List<ExecutionParameter> ServiceActionParameters
        {
            get { return this._serviceActionParameters; }
            set { this._serviceActionParameters = value; }
        }

        // Check to see if ServiceActionParameters property is set
        internal bool IsSetServiceActionParameters()
        {
            return this._serviceActionParameters != null && this._serviceActionParameters.Count > 0; 
        }

    }
}