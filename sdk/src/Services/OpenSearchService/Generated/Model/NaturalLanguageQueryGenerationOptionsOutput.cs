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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for parameters representing the state of the natural language query generation
    /// feature on the specified domain.
    /// </summary>
    public partial class NaturalLanguageQueryGenerationOptionsOutput
    {
        private NaturalLanguageQueryGenerationCurrentState _currentState;
        private NaturalLanguageQueryGenerationDesiredState _desiredState;

        /// <summary>
        /// Gets and sets the property CurrentState. 
        /// <para>
        /// The current state of the natural language query generation feature, indicating completion,
        /// in progress, or failure.
        /// </para>
        /// </summary>
        public NaturalLanguageQueryGenerationCurrentState CurrentState
        {
            get { return this._currentState; }
            set { this._currentState = value; }
        }

        // Check to see if CurrentState property is set
        internal bool IsSetCurrentState()
        {
            return this._currentState != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The desired state of the natural language query generation feature. Valid values are
        /// ENABLED and DISABLED.
        /// </para>
        /// </summary>
        public NaturalLanguageQueryGenerationDesiredState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

    }
}