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
    /// Container for the parameters to the GetTargetSelectionRules operation.
    /// Converts source selection rules into their target counterparts for schema conversion
    /// operations.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions:</b> <c>dms:GetTargetSelectionRules</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>.
    /// </para>
    /// </summary>
    public partial class GetTargetSelectionRulesRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _migrationProjectIdentifier;
        private string _selectionRules;

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

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// A JSON string that contains the source selection rules to convert into their target
        /// counterparts. For the selection rule format and examples, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/sc-selection-rules.html">Selection
        /// rules in DMS Schema Conversion</a>.
        /// </para>
        ///  
        /// <para>
        /// Usage:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Accepts only source selection rules, where <c>server-name</c> in the object locator
        /// matches the source data provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Supports only <c>explicit</c> rule actions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Does not support <c>category-name</c> in the object locator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Up to 10 rules are allowed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SelectionRules
        {
            get { return this._selectionRules; }
            set { this._selectionRules = value; }
        }

        // Check to see if SelectionRules property is set
        internal bool IsSetSelectionRules()
        {
            return this._selectionRules != null;
        }

    }
}