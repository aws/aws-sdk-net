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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the StartTransformerJob operation.
    /// </summary>
    public partial class StartTransformerJobResponse : AmazonWebServiceResponse
    {
        private string _transformerJobId;

        /// <summary>
        /// Gets and sets the property TransformerJobId. 
        /// <para>
        /// Returns the unique, system-generated identifier for a transformer run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=25, Max=25)]
        public string TransformerJobId
        {
            get { return this._transformerJobId; }
            set { this._transformerJobId = value; }
        }

        // Check to see if TransformerJobId property is set
        internal bool IsSetTransformerJobId()
        {
            return this._transformerJobId != null;
        }

    }
}