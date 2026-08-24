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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the DescribeExtractionDefinition operation.
    /// </summary>
    public partial class DescribeExtractionDefinitionResponse : AmazonWebServiceResponse
    {
        private ExtractionDefinition _extractionDefinition;

        /// <summary>
        /// Gets and sets the property ExtractionDefinition. 
        /// <para>
        /// The extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExtractionDefinition ExtractionDefinition
        {
            get { return this._extractionDefinition; }
            set { this._extractionDefinition = value; }
        }

        // Check to see if ExtractionDefinition property is set
        internal bool IsSetExtractionDefinition()
        {
            return this._extractionDefinition != null;
        }

    }
}