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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the DescribeImport operation.
    /// </summary>
    public partial class DescribeImportResponse : AmazonWebServiceResponse
    {
        private ImportTableDescription _importTableDescription;

        /// <summary>
        /// Gets and sets the property ImportTableDescription. 
        /// <para>
        ///  Represents the properties of the table created for the import, and parameters of
        /// the import. The import parameters include import status, how many items were processed,
        /// and how many errors were encountered. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportTableDescription ImportTableDescription
        {
            get { return this._importTableDescription; }
            set { this._importTableDescription = value; }
        }

        // Check to see if ImportTableDescription property is set
        internal bool IsSetImportTableDescription()
        {
            return this._importTableDescription != null;
        }

    }
}