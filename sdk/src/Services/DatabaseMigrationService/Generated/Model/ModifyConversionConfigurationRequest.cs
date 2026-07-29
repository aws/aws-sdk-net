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
    /// Container for the parameters to the ModifyConversionConfiguration operation.
    /// Modifies the specified schema conversion configuration using the provided parameters.
    /// 
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions:</b> <c>dms:UpdateConversionConfiguration</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>.
    /// </para>
    /// </summary>
    public partial class ModifyConversionConfigurationRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _conversionConfiguration;
        private string _migrationProjectIdentifier;

        /// <summary>
        /// Gets and sets the property ConversionConfiguration. 
        /// <para>
        /// A JSON string that contains the schema conversion settings to update. For the format
        /// and available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/schema-conversion-settings.html">Specifying
        /// schema conversion settings for migration projects</a>.
        /// </para>
        ///  
        /// <para>
        /// Usage:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Include only the sections and keys to change. The operation merges supplied values
        /// with the existing configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConversionConfiguration
        {
            get { return this._conversionConfiguration; }
            set { this._conversionConfiguration = value; }
        }

        // Check to see if ConversionConfiguration property is set
        internal bool IsSetConversionConfiguration()
        {
            return this._conversionConfiguration != null;
        }

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