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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The object representing the passwords that were used to encrypt the data related to
    /// the bot recommendation, as well as the KMS key ARN used to encrypt the associated
    /// metadata.
    /// </summary>
    public partial class EncryptionSetting
    {
        private string _associatedTranscriptsPassword;
        private string _botLocaleExportPassword;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property AssociatedTranscriptsPassword. 
        /// <para>
        /// The password used to encrypt the associated transcript file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string AssociatedTranscriptsPassword
        {
            get { return this._associatedTranscriptsPassword; }
            set { this._associatedTranscriptsPassword = value; }
        }

        // Check to see if AssociatedTranscriptsPassword property is set
        internal bool IsSetAssociatedTranscriptsPassword()
        {
            return this._associatedTranscriptsPassword != null;
        }

        /// <summary>
        /// Gets and sets the property BotLocaleExportPassword. 
        /// <para>
        /// The password used to encrypt the recommended bot recommendation file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string BotLocaleExportPassword
        {
            get { return this._botLocaleExportPassword; }
            set { this._botLocaleExportPassword = value; }
        }

        // Check to see if BotLocaleExportPassword property is set
        internal bool IsSetBotLocaleExportPassword()
        {
            return this._botLocaleExportPassword != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The KMS key ARN used to encrypt the metadata associated with the bot recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}