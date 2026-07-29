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
    /// Container for the parameters to the StartExtensionPackAssociation operation.
    /// Queues the installation of the extension pack on your target database. If other requests
    /// created by <c>Start*</c> operations are already in the migration project's queue,
    /// the installation begins after they complete.
    /// 
    ///  
    /// <para>
    /// This operation requires a non-virtual target data provider.
    /// </para>
    ///  
    /// <para>
    /// If the extension pack already exists, the operation reinstalls it. To ensure compatibility,
    /// reconvert your database objects if the version has changed since your last conversion.
    /// For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/extension-pack.html">Using
    /// extension packs in DMS Schema Conversion</a>.
    /// </para>
    ///  
    /// <para>
    /// To check the status of the request, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DescribeExtensionPackAssociations.html">DescribeExtensionPackAssociations</a>
    /// using the returned <c>RequestIdentifier</c> as a filter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions:</b> <c>dms:AssociateExtensionPack</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>.
    /// </para>
    /// </summary>
    public partial class StartExtensionPackAssociationRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _migrationProjectIdentifier;

        /// <summary>
        /// Gets and sets the property MigrationProjectIdentifier. 
        /// <para>
        /// The migration project name or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string MigrationProjectIdentifier
        {
            get { return this._migrationProjectIdentifier; }
            set { this._migrationProjectIdentifier = value; }
        }

        // Check to see if MigrationProjectIdentifier property is set
        internal bool IsSetMigrationProjectIdentifier()
        {
            return this._migrationProjectIdentifier != null;
        }

    }
}