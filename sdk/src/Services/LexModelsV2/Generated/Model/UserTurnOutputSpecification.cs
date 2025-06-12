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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains results that are output for the user turn by the test execution.
    /// </summary>
    public partial class UserTurnOutputSpecification
    {
        private List<ActiveContext> _activeContexts = AWSConfigs.InitializeCollections ? new List<ActiveContext>() : null;
        private UserTurnIntentOutput _intent;
        private string _transcript;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// The contexts that are active in the turn.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ActiveContext> ActiveContexts
        {
            get { return this._activeContexts; }
            set { this._activeContexts = value; }
        }

        // Check to see if ActiveContexts property is set
        internal bool IsSetActiveContexts()
        {
            return this._activeContexts != null && (this._activeContexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// Contains information about the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserTurnIntentOutput Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// The transcript that is output for the user turn by the test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Transcript
        {
            get { return this._transcript; }
            set { this._transcript = value; }
        }

        // Check to see if Transcript property is set
        internal bool IsSetTranscript()
        {
            return this._transcript != null;
        }

    }
}