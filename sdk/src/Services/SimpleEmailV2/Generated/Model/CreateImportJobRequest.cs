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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImportJob operation.
    /// Creates an import job for a data destination.
    /// </summary>
    public partial class CreateImportJobRequest : AmazonSimpleEmailServiceV2Request
    {
        private ImportDataSource _importDataSource;
        private ImportDestination _importDestination;

        /// <summary>
        /// Gets and sets the property ImportDataSource. 
        /// <para>
        /// The data source for the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportDataSource ImportDataSource
        {
            get { return this._importDataSource; }
            set { this._importDataSource = value; }
        }

        // Check to see if ImportDataSource property is set
        internal bool IsSetImportDataSource()
        {
            return this._importDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property ImportDestination. 
        /// <para>
        /// The destination for the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportDestination ImportDestination
        {
            get { return this._importDestination; }
            set { this._importDestination = value; }
        }

        // Check to see if ImportDestination property is set
        internal bool IsSetImportDestination()
        {
            return this._importDestination != null;
        }

    }
}