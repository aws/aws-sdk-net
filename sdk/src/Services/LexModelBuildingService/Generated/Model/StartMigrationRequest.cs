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
    /// Container for the parameters to the StartMigration operation.
    /// Starts migrating a bot from Amazon Lex V1 to Amazon Lex V2. Migrate your bot when
    /// you want to take advantage of the new features of Amazon Lex V2.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/migrate.html">Migrating
    /// a bot</a> in the <i>Amazon Lex developer guide</i>.
    /// </para>
    /// </summary>
    public partial class StartMigrationRequest : AmazonLexModelBuildingServiceRequest
    {
        private MigrationStrategy _migrationStrategy;
        private string _v1BotName;
        private string _v1BotVersion;
        private string _v2BotName;
        private string _v2BotRole;

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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property V1BotName. 
        /// <para>
        /// The name of the Amazon Lex V1 bot that you are migrating to Amazon Lex V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
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
        /// The version of the bot to migrate to Amazon Lex V2. You can migrate the <c>$LATEST</c>
        /// version as well as any numbered version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property V2BotName. 
        /// <para>
        /// The name of the Amazon Lex V2 bot that you are migrating the Amazon Lex V1 bot to.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the Amazon Lex V2 bot doesn't exist, you must use the <c>CREATE_NEW</c> migration
        /// strategy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the Amazon Lex V2 bot exists, you must use the <c>UPDATE_EXISTING</c> migration
        /// strategy to change the contents of the Amazon Lex V2 bot.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string V2BotName
        {
            get { return this._v2BotName; }
            set { this._v2BotName = value; }
        }

        // Check to see if V2BotName property is set
        internal bool IsSetV2BotName()
        {
            return this._v2BotName != null;
        }

        /// <summary>
        /// Gets and sets the property V2BotRole. 
        /// <para>
        /// The IAM role that Amazon Lex uses to run the Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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