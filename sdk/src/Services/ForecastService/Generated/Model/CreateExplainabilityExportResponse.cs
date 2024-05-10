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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the CreateExplainabilityExport operation.
    /// </summary>
    public partial class CreateExplainabilityExportResponse : AmazonWebServiceResponse
    {
        private string _explainabilityExportArn;

        /// <summary>
        /// Gets and sets the property ExplainabilityExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the export.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ExplainabilityExportArn
        {
            get { return this._explainabilityExportArn; }
            set { this._explainabilityExportArn = value; }
        }

        // Check to see if ExplainabilityExportArn property is set
        internal bool IsSetExplainabilityExportArn()
        {
            return this._explainabilityExportArn != null;
        }

    }
}