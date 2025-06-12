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
    /// This is the response object from the GetMigration operation.
    /// </summary>
    public partial class GetMigrationResponse : AmazonWebServiceResponse
    {
        private List<MigrationAlert> _alerts = AWSConfigs.InitializeCollections ? new List<MigrationAlert>() : null;
        private string _migrationId;
        private MigrationStatus _migrationStatus;
        private MigrationStrategy _migrationStrategy;
        private DateTime? _migrationTimestamp;
        private Locale _v1BotLocale;
        private string _v1BotName;
        private string _v1BotVersion;
        private string _v2BotId;
        private string _v2BotRole;

        /// <summary>
        /// Gets and sets the property Alerts. 
        /// <para>
        /// A list of alerts and warnings that indicate issues with the migration for the Amazon
        /// Lex V1 bot to Amazon Lex V2. You receive a warning when an Amazon Lex V1 feature has
        /// a different implementation if Amazon Lex V2.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/migrate.html">Migrating
        /// a bot</a> in the <i>Amazon Lex V2 developer guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MigrationAlert> Alerts
        {
            get { return this._alerts; }
            set { this._alerts = value; }
        }

        // Check to see if Alerts property is set
        internal bool IsSetAlerts()
        {
            return this._alerts != null && (this._alerts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The unique identifier of the migration. This is the same as the identifier used when
        /// calling the <c>GetMigration</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
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

        /// <summary>
        /// Gets and sets the property MigrationStatus. 
        /// <para>
        /// Indicates the status of the migration. When the status is <c>COMPLETE</c> the migration
        /// is finished and the bot is available in Amazon Lex V2. There may be alerts and warnings
        /// that need to be resolved to complete the migration.
        /// </para>
        /// </summary>
        public MigrationStatus MigrationStatus
        {
            get { return this._migrationStatus; }
            set { this._migrationStatus = value; }
        }

        // Check to see if MigrationStatus property is set
        internal bool IsSetMigrationStatus()
        {
            return this._migrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationStrategy. 
        /// <para>
        /// The strategy used to conduct the migration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_NEW</c> - Creates a new Amazon Lex V2 bot and migrates the Amazon Lex V1
        /// bot to the new bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_EXISTING</c> - Overwrites the existing Amazon Lex V2 bot metadata and the
        /// locale being migrated. It doesn't change any other locales in the Amazon Lex V2 bot.
        /// If the locale doesn't exist, a new locale is created in the Amazon Lex V2 bot.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MigrationStrategy MigrationStrategy
        {
            get { return this._migrationStrategy; }
            set { this._migrationStrategy = value; }
        }

        // Check to see if MigrationStrategy property is set
        internal bool IsSetMigrationStrategy()
        {
            return this._migrationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationTimestamp. 
        /// <para>
        /// The date and time that the migration started.
        /// </para>
        /// </summary>
        public DateTime? MigrationTimestamp
        {
            get { return this._migrationTimestamp; }
            set { this._migrationTimestamp = value; }
        }

        // Check to see if MigrationTimestamp property is set
        internal bool IsSetMigrationTimestamp()
        {
            return this._migrationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property V1BotLocale. 
        /// <para>
        /// The locale of the Amazon Lex V1 bot migrated to Amazon Lex V2.
        /// </para>
        /// </summary>
        public Locale V1BotLocale
        {
            get { return this._v1BotLocale; }
            set { this._v1BotLocale = value; }
        }

        // Check to see if V1BotLocale property is set
        internal bool IsSetV1BotLocale()
        {
            return this._v1BotLocale != null;
        }

        /// <summary>
        /// Gets and sets the property V1BotName. 
        /// <para>
        /// The name of the Amazon Lex V1 bot migrated to Amazon Lex V2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string V1BotName
        {
            get { return this._v1BotName; }
            set { this._v1BotName = value; }
        }

        // Check to see if V1BotName property is set
        internal bool IsSetV1BotName()
        {
            return this._v1BotName != null;
        }

        /// <summary>
        /// Gets and sets the property V1BotVersion. 
        /// <para>
        /// The version of the Amazon Lex V1 bot migrated to Amazon Lex V2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string V1BotVersion
        {
            get { return this._v1BotVersion; }
            set { this._v1BotVersion = value; }
        }

        // Check to see if V1BotVersion property is set
        internal bool IsSetV1BotVersion()
        {
            return this._v1BotVersion != null;
        }

        /// <summary>
        /// Gets and sets the property V2BotId. 
        /// <para>
        /// The unique identifier of the Amazon Lex V2 bot that the Amazon Lex V1 is being migrated
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string V2BotId
        {
            get { return this._v2BotId; }
            set { this._v2BotId = value; }
        }

        // Check to see if V2BotId property is set
        internal bool IsSetV2BotId()
        {
            return this._v2BotId != null;
        }

        /// <summary>
        /// Gets and sets the property V2BotRole. 
        /// <para>
        /// The IAM role that Amazon Lex uses to run the Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string V2BotRole
        {
            get { return this._v2BotRole; }
            set { this._v2BotRole = value; }
        }

        // Check to see if V2BotRole property is set
        internal bool IsSetV2BotRole()
        {
            return this._v2BotRole != null;
        }

    }
}