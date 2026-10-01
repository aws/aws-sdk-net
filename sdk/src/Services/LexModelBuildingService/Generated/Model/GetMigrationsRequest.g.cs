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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetMigrations operation. Gets a list of migrations
    /// between Amazon Lex V1 and Amazon Lex V2.
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetMigrationsRequest : AmazonLexModelBuildingServiceRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of migrations to return in the response. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationStatusEquals. 
        /// <para>
        /// Filters the list to contain only migrations in the specified state.
        /// </para>
        /// </summary>
        public MigrationStatus MigrationStatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the MigrationStatusEquals property is set.
        /// </summary>
        internal bool IsSetMigrationStatusEquals() => this.MigrationStatusEquals != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of migrations. If the response to this
        /// operation is truncated, Amazon Lex returns a pagination token in the response. To
        /// fetch the next page of migrations, specify the pagination token in the request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortByAttribute. 
        /// <para>
        /// The field to sort the list of migrations by. You can sort by the Amazon Lex V1 bot
        /// name or the date and time that the migration was started.
        /// </para>
        /// </summary>
        public MigrationSortAttribute SortByAttribute { get; set; }

        /// <summary>
        /// Checks to see if the SortByAttribute property is set.
        /// </summary>
        internal bool IsSetSortByAttribute() => this.SortByAttribute != null;

        /// <summary>
        /// Gets and sets the property SortByOrder. 
        /// <para>
        /// The order so sort the list.
        /// </para>
        /// </summary>
        public SortOrder SortByOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortByOrder property is set.
        /// </summary>
        internal bool IsSetSortByOrder() => this.SortByOrder != null;

        /// <summary>
        /// Gets and sets the property V1BotNameContains. 
        /// <para>
        /// Filters the list to contain only bots whose name contains the specified string. The
        /// string is matched anywhere in bot name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string V1BotNameContains { get; set; }

        /// <summary>
        /// Checks to see if the V1BotNameContains property is set.
        /// </summary>
        internal bool IsSetV1BotNameContains() => this.V1BotNameContains != null;
    }
}
