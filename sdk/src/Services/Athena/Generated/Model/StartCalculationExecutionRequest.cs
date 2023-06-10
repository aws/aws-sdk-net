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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the StartCalculationExecution operation.
    /// Submits calculations for execution within a session. You can supply the code to run
    /// as an inline code block within the request.
    /// </summary>
    public partial class StartCalculationExecutionRequest : AmazonAthenaRequest
    {
        private CalculationConfiguration _calculationConfiguration;
        private string _clientRequestToken;
        private string _codeBlock;
        private string _description;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property CalculationConfiguration. 
        /// <para>
        /// Contains configuration information for the calculation.
        /// </para>
        /// </summary>
        [Obsolete("Kepler Post GA Tasks : https://sim.amazon.com/issues/ATHENA-39828")]
        public CalculationConfiguration CalculationConfiguration
        {
            get { return this._calculationConfiguration; }
            set { this._calculationConfiguration = value; }
        }

        // Check to see if CalculationConfiguration property is set
        internal bool IsSetCalculationConfiguration()
        {
            return this._calculationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique case-sensitive string used to ensure the request to create the calculation
        /// is idempotent (executes only once). If another <code>StartCalculationExecutionRequest</code>
        /// is received, the same response is returned and another calculation is not created.
        /// If a parameter has changed, an error is returned.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token is listed as not required because Amazon Web Services SDKs (for example
        /// the Amazon Web Services SDK for Java) auto-generate the token for users. If you are
        /// not using the Amazon Web Services SDK or the Amazon Web Services CLI, you must provide
        /// this token or the action will fail.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CodeBlock. 
        /// <para>
        /// A string that contains the code of the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=68000)]
        public string CodeBlock
        {
            get { return this._codeBlock; }
            set { this._codeBlock = value; }
        }

        // Check to see if CodeBlock property is set
        internal bool IsSetCodeBlock()
        {
            return this._codeBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}