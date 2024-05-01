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
    /// Container for the parameters to the GetMigrations operation.
    /// Gets a list of migrations between Amazon Lex V1 and Amazon Lex V2.
    /// </summary>
    public partial class GetMigrationsRequest : AmazonLexModelBuildingServiceRequest
    {
        private int? _maxResults;
        private MigrationStatus _migrationStatusEquals;
        private string _nextToken;
        private MigrationSortAttribute _sortByAttribute;
        private SortOrder _sortByOrder;
        private string _v1BotNameContains;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of migrations to return in the response. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationStatusEquals. 
        /// <para>
        /// Filters the list to contain only migrations in the specified state.
        /// </para>
        /// </summary>
        public MigrationStatus MigrationStatusEquals
        {
            get { return this._migrationStatusEquals; }
            set { this._migrationStatusEquals = value; }
        }

        // Check to see if MigrationStatusEquals property is set
        internal bool IsSetMigrationStatusEquals()
        {
            return this._migrationStatusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of migrations. If the response to this
        /// operation is truncated, Amazon Lex returns a pagination token in the response. To
        /// fetch the next page of migrations, specify the pagination token in the request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortByAttribute. 
        /// <para>
        /// The field to sort the list of migrations by. You can sort by the Amazon Lex V1 bot
        /// name or the date and time that the migration was started.
        /// </para>
        /// </summary>
        public MigrationSortAttribute SortByAttribute
        {
            get { return this._sortByAttribute; }
            set { this._sortByAttribute = value; }
        }

        // Check to see if SortByAttribute property is set
        internal bool IsSetSortByAttribute()
        {
            return this._sortByAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property SortByOrder. 
        /// <para>
        /// The order so sort the list.
        /// </para>
        /// </summary>
        public SortOrder SortByOrder
        {
            get { return this._sortByOrder; }
            set { this._sortByOrder = value; }
        }

        // Check to see if SortByOrder property is set
        internal bool IsSetSortByOrder()
        {
            return this._sortByOrder != null;
        }

        /// <summary>
        /// Gets and sets the property V1BotNameContains. 
        /// <para>
        /// Filters the list to contain only bots whose name contains the specified string. The
        /// string is matched anywhere in bot name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string V1BotNameContains
        {
            get { return this._v1BotNameContains; }
            set { this._v1BotNameContains = value; }
        }

        // Check to see if V1BotNameContains property is set
        internal bool IsSetV1BotNameContains()
        {
            return this._v1BotNameContains != null;
        }

    }
}