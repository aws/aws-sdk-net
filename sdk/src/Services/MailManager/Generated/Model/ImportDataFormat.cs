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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The import data format contains the specifications of the input file that would be
    /// passed to the address list import job.
    /// </summary>
    public partial class ImportDataFormat
    {
        private ImportDataType _importDataType;

        /// <summary>
        /// Gets and sets the property ImportDataType. 
        /// <para>
        /// The type of file that would be passed as an input for the address list import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportDataType ImportDataType
        {
            get { return this._importDataType; }
            set { this._importDataType = value; }
        }

        // Check to see if ImportDataType property is set
        internal bool IsSetImportDataType()
        {
            return this._importDataType != null;
        }

    }
}