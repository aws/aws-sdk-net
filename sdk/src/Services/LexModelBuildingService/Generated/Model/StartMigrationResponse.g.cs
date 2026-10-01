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
    /// This is the response object from the StartMigration operation.
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class StartMigrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The unique identifier that Amazon Lex assigned to the migration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string MigrationId { get; set; }

        /// <summary>
        /// Checks to see if the MigrationId property is set.
        /// </summary>
        internal bool IsSetMigrationId() => this.MigrationId != null;

        /// <summary>
        /// Gets and sets the property MigrationStrategy. 
        /// <para>
        /// The strategy used to conduct the migration.
        /// </para>
        /// </summary>
        public MigrationStrategy MigrationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MigrationStrategy property is set.
        /// </summary>
        internal bool IsSetMigrationStrategy() => this.MigrationStrategy != null;

        /// <summary>
        /// Gets and sets the property MigrationTimestamp. 
        /// <para>
        /// The date and time that the migration started.
        /// </para>
        /// </summary>
        public DateTime? MigrationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the MigrationTimestamp property is set.
        /// </summary>
        internal bool IsSetMigrationTimestamp() => this.MigrationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property V1BotLocale. 
        /// <para>
        /// The locale used for the Amazon Lex V1 bot. 
        /// </para>
        /// </summary>
        public Locale V1BotLocale { get; set; }

        /// <summary>
        /// Checks to see if the V1BotLocale property is set.
        /// </summary>
        internal bool IsSetV1BotLocale() => this.V1BotLocale != null;

        /// <summary>
        /// Gets and sets the property V1BotName. 
        /// <para>
        /// The name of the Amazon Lex V1 bot that you are migrating to Amazon Lex V2.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string V1BotName { get; set; }

        /// <summary>
        /// Checks to see if the V1BotName property is set.
        /// </summary>
        internal bool IsSetV1BotName() => this.V1BotName != null;

        /// <summary>
        /// Gets and sets the property V1BotVersion. 
        /// <para>
        /// The version of the bot to migrate to Amazon Lex V2. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string V1BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the V1BotVersion property is set.
        /// </summary>
        internal bool IsSetV1BotVersion() => this.V1BotVersion != null;

        /// <summary>
        /// Gets and sets the property V2BotId. 
        /// <para>
        /// The unique identifier for the Amazon Lex V2 bot. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string V2BotId { get; set; }

        /// <summary>
        /// Checks to see if the V2BotId property is set.
        /// </summary>
        internal bool IsSetV2BotId() => this.V2BotId != null;

        /// <summary>
        /// Gets and sets the property V2BotRole. 
        /// <para>
        /// The IAM role that Amazon Lex uses to run the Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string V2BotRole { get; set; }

        /// <summary>
        /// Checks to see if the V2BotRole property is set.
        /// </summary>
        internal bool IsSetV2BotRole() => this.V2BotRole != null;
    }
}
