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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetMigration operation.
    /// Provides details about an ongoing or complete migration from an Amazon Lex V1 bot
    /// to an Amazon Lex V2 bot. Use this operation to view the migration alerts and warnings
    /// related to the migration.
    /// </summary>
    public partial class GetMigrationRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _migrationId;

        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The unique identifier of the migration to view. The <c>migrationID</c> is returned
        /// by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string MigrationId
        {
            get { return this._migrationId; }
            set { this._migrationId = value; }
        }

        // Check to see if MigrationId property is set
        internal bool IsSetMigrationId()
        {
            return this._migrationId != null;
        }

    }
}