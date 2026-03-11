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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the CreateCapacityManagerDataExport operation.
    /// </summary>
    public partial class CreateCapacityManagerDataExportResponse : AmazonWebServiceResponse
    {
        private string _capacityManagerDataExportId;

        /// <summary>
        /// Gets and sets the property CapacityManagerDataExportId. 
        /// <para>
        ///  The unique identifier for the created data export configuration. Use this ID to reference
        /// the export in other API calls. 
        /// </para>
        /// </summary>
        public string CapacityManagerDataExportId
        {
            get { return this._capacityManagerDataExportId; }
            set { this._capacityManagerDataExportId = value; }
        }

        // Check to see if CapacityManagerDataExportId property is set
        internal bool IsSetCapacityManagerDataExportId()
        {
            return this._capacityManagerDataExportId != null;
        }

    }
}