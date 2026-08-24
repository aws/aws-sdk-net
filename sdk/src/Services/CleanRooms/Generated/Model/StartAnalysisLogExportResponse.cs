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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// This is the response object from the StartAnalysisLogExport operation.
    /// </summary>
    public partial class StartAnalysisLogExportResponse : AmazonWebServiceResponse
    {
        private AnalysisLogExport _analysisLogExport;

        /// <summary>
        /// Gets and sets the property AnalysisLogExport. 
        /// <para>
        /// The analysis log export that was started. The <c>status</c> is <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisLogExport AnalysisLogExport
        {
            get { return this._analysisLogExport; }
            set { this._analysisLogExport = value; }
        }

        // Check to see if AnalysisLogExport property is set
        internal bool IsSetAnalysisLogExport()
        {
            return this._analysisLogExport != null;
        }

    }
}