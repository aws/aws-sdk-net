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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataProvider operation.
    /// Deletes the specified data provider.
    /// 
    ///  <note> 
    /// <para>
    /// All migration projects associated with the data provider must be deleted or modified
    /// before you can delete the data provider.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDataProviderRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _dataProviderIdentifier;

        /// <summary>
        /// Gets and sets the property DataProviderIdentifier. 
        /// <para>
        /// The identifier of the data provider to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataProviderIdentifier
        {
            get { return this._dataProviderIdentifier; }
            set { this._dataProviderIdentifier = value; }
        }

        // Check to see if DataProviderIdentifier property is set
        internal bool IsSetDataProviderIdentifier()
        {
            return this._dataProviderIdentifier != null;
        }

    }
}