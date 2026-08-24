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
    /// This is the response object from the CreateExtractionDefinition operation.
    /// </summary>
    public partial class CreateExtractionDefinitionResponse : AmazonWebServiceResponse
    {
        private string _extractionDefinitionArn;
        private string _extractionDefinitionId;

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExtractionDefinitionArn
        {
            get { return this._extractionDefinitionArn; }
            set { this._extractionDefinitionArn = value; }
        }

        // Check to see if ExtractionDefinitionArn property is set
        internal bool IsSetExtractionDefinitionArn()
        {
            return this._extractionDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionId. 
        /// <para>
        /// The identifier of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExtractionDefinitionId
        {
            get { return this._extractionDefinitionId; }
            set { this._extractionDefinitionId = value; }
        }

        // Check to see if ExtractionDefinitionId property is set
        internal bool IsSetExtractionDefinitionId()
        {
            return this._extractionDefinitionId != null;
        }

    }
}