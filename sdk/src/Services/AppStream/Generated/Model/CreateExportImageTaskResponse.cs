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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the CreateExportImageTask operation.
    /// </summary>
    public partial class CreateExportImageTaskResponse : AmazonWebServiceResponse
    {
        private ExportImageTask _exportImageTask;

        /// <summary>
        /// Gets and sets the property ExportImageTask. 
        /// <para>
        /// Information about the export image task that was created, including the task ID and
        /// initial state.
        /// </para>
        /// </summary>
        public ExportImageTask ExportImageTask
        {
            get { return this._exportImageTask; }
            set { this._exportImageTask = value; }
        }

        // Check to see if ExportImageTask property is set
        internal bool IsSetExportImageTask()
        {
            return this._exportImageTask != null;
        }

    }
}