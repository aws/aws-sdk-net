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
    /// Specifications for the current state of the dialog between the user and the bot in
    /// the test set.
    /// </summary>
    public partial class InputSessionStateSpecification
    {
        private List<ActiveContext> _activeContexts = AWSConfigs.InitializeCollections ? new List<ActiveContext>() : null;
        private RuntimeHints _runtimeHints;
        private Dictionary<string, string> _sessionAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// Active contexts for the session state.
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
        /// Gets and sets the property RuntimeHints. 
        /// <para>
        /// Runtime hints for the session state.
        /// </para>
        /// </summary>
        public RuntimeHints RuntimeHints
        {
            get { return this._runtimeHints; }
            set { this._runtimeHints = value; }
        }

        // Check to see if RuntimeHints property is set
        internal bool IsSetRuntimeHints()
        {
            return this._runtimeHints != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Session attributes for the session state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && (this._sessionAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}