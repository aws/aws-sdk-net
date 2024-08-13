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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInventory operation.
    /// Delete a custom inventory type or the data associated with a custom Inventory type.
    /// Deleting a custom inventory type is also referred to as deleting a custom inventory
    /// schema.
    /// </summary>
    public partial class DeleteInventoryRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _clientToken;
        private bool? _dryRun;
        private InventorySchemaDeleteOption _schemaDeleteOption;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Use this option to view a summary of the deletion request without deleting any data
        /// or the data type. This option is useful when you only want to understand what will
        /// be deleted. Once you validate that the data to be deleted is what you intend to delete,
        /// you can run the same command without specifying the <c>DryRun</c> option.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaDeleteOption. 
        /// <para>
        /// Use the <c>SchemaDeleteOption</c> to delete a custom inventory type (schema). If you
        /// don't choose this option, the system only deletes existing inventory data associated
        /// with the custom inventory type. Choose one of the following options:
        /// </para>
        ///  
        /// <para>
        /// DisableSchema: If you choose this option, the system ignores all inventory data for
        /// the specified version, and any earlier versions. To enable this schema again, you
        /// must call the <c>PutInventory</c> operation for a version greater than the disabled
        /// version.
        /// </para>
        ///  
        /// <para>
        /// DeleteSchema: This option deletes the specified custom type from the Inventory service.
        /// You can recreate the schema later, if you want.
        /// </para>
        /// </summary>
        public InventorySchemaDeleteOption SchemaDeleteOption
        {
            get { return this._schemaDeleteOption; }
            set { this._schemaDeleteOption = value; }
        }

        // Check to see if SchemaDeleteOption property is set
        internal bool IsSetSchemaDeleteOption()
        {
            return this._schemaDeleteOption != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the custom inventory type for which you want to delete either all previously
        /// collected data or the inventory type itself. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}