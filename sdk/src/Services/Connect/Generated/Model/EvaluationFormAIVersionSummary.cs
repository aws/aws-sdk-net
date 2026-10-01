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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the name and lifecycle information for an AI version that you can use when
    /// creating or updating an evaluation form.
    /// </summary>
    public partial class EvaluationFormAIVersionSummary
    {
        private EvaluationFormAIVersionLifecycle _aiVersionLifecycle;
        private string _aiVersionName;

        /// <summary>
        /// Gets and sets the property AIVersionLifecycle. 
        /// <para>
        /// The lifecycle information for this AI version, including its status and availability
        /// dates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormAIVersionLifecycle AIVersionLifecycle
        {
            get { return this._aiVersionLifecycle; }
            set { this._aiVersionLifecycle = value; }
        }

        // Check to see if AIVersionLifecycle property is set
        internal bool IsSetAIVersionLifecycle()
        {
            return this._aiVersionLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property AIVersionName. 
        /// <para>
        /// The name of the AI version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AIVersionName
        {
            get { return this._aiVersionName; }
            set { this._aiVersionName = value; }
        }

        // Check to see if AIVersionName property is set
        internal bool IsSetAIVersionName()
        {
            return this._aiVersionName != null;
        }

    }
}